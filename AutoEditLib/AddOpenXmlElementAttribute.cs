using DocumentFormat.OpenXml.Wordprocessing;

using Qhta.Collections;

namespace AutoEdit;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

using DocumentFormat.OpenXml;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

/// <summary>
/// Adds <c>[OpenXmlElement]</c> attributes to model classes based on their Open XML backing types.
/// </summary>
public static class AddOpenXmlElementAttribute
{
  /// <summary>
  /// Processes the supplied C# file, rewriting properties that require an <c>[OpenXmlElement]</c> attribute.
  /// </summary>
  /// <param name="filePath">The path to the source file to inspect and update.</param>
  public static void Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetCompilationUnitRoot();
    var aliasMap = AliasHelper.BuildAliasMap(filePath, root);
    var rewriter = new AddOpenXmlElementAttributeRewriter(aliasMap);
    var newRoot = rewriter.Visit(root);
    if (rewriter.Changed)
    {
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace("  ").ToFullString());
      Console.WriteLine($"Updated: {filePath}");
    }
  }
}

/// <summary>
/// Syntax rewriter that annotates properties inside <c>ModelElement&lt;TOpenXml&gt;</c> classes with <c>[OpenXmlElement]</c> attributes.
/// </summary>
/// <param name="aliasMap">Namespace aliases discovered in the processed file.</param>
public class AddOpenXmlElementAttributeRewriter(BiDiDictionary<string, string> aliasMap): CSharpSyntaxRewriter
{
  private readonly Dictionary<string, Type?> _typeCache = new(StringComparer.Ordinal);
  private readonly Dictionary<string, IReadOnlyList<Type>> _childElementTypesCache = new(StringComparer.Ordinal);
  private readonly Dictionary<string, XDocument?> _xmlDocumentationCache = new(StringComparer.OrdinalIgnoreCase);
  private static readonly Assembly? OpenXmlFrameworkAssembly = typeof(OpenXmlElement).Assembly;
  private static readonly Assembly? OpenXmlAssembly = typeof(Document).Assembly;

  /// <summary>
  /// Indicates whether the rewriter produced any modifications.
  /// </summary>
  public bool Changed { get; private set; } = false;

  /// <summary>
  /// Visits model classes and adds missing <c>[OpenXmlElement]</c> attributes to eligible properties.
  /// </summary>
  /// <param name="classNode">The class declaration being analyzed.</param>
  /// <returns>The updated class declaration, or the original node when no changes were required.</returns>
  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax classNode)
  {
    var openXmlTypeAttribute = classNode.AttributeLists.SelectMany(al => al.Attributes).FirstOrDefault(attr =>
    {
      var attrName = attr.Name.ToString();
      return attrName == "OpenXmlType" || attrName == "OpenXmlTypeAttribute" || attrName.EndsWith(".OpenXmlType") ||
             attrName.EndsWith(".OpenXmlTypeAttribute");
    });
    if (openXmlTypeAttribute?.ArgumentList == null)
      return base.VisitClassDeclaration(classNode);
    if (openXmlTypeAttribute.ArgumentList.Arguments.Count < 1)
      return base.VisitClassDeclaration(classNode);

    var openXmlTypeExpression = openXmlTypeAttribute.ArgumentList.Arguments[0].Expression;
    if (openXmlTypeExpression is not TypeOfExpressionSyntax typeOfExpression)
      return base.VisitClassDeclaration(classNode);

    var openXmlTypeName = typeOfExpression.Type.ToString();
    if (openXmlTypeName == "T")
    {
      var typeParamClause =
        classNode.ConstraintClauses.FirstOrDefault(clause => clause.Name.Identifier.Text == openXmlTypeName);
      if (typeParamClause?.Constraints == null)
        return base.VisitClassDeclaration(classNode);

      var constraint = typeParamClause.Constraints.OfType<TypeConstraintSyntax>().FirstOrDefault();
      if (constraint == null)
        return base.VisitClassDeclaration(classNode);

      var qualifiedName = constraint.Type is QualifiedNameSyntax constraintType
        ? constraintType.ToString()
        : constraint.Type.ToString();
      if (qualifiedName == "DX.OpenXmlElement")
        return base.VisitClassDeclaration(classNode);

      openXmlTypeName = qualifiedName;
    }
    var childElementTypes = GetChildElementTypes(openXmlTypeName);
    var newMembers = classNode.Members.Select(member =>
    {
      if (member is PropertyDeclarationSyntax prop)
      {
        var hasSetter = prop.AccessorList?.Accessors
          .Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration) == true;
        if (!hasSetter)
          return member;

        var hasElementAttr = prop.AttributeLists.SelectMany(al => al.Attributes)
          .Any(attr => attr.Name.ToString().Contains("OpenXmlElement"));
        if (hasElementAttr)
          return member;

        var hasPropertyAttr = prop.AttributeLists.SelectMany(al => al.Attributes)
          .Any(attr => attr.Name.ToString().Contains("OpenXmlProperty"));
        if (hasPropertyAttr)
          return member;
        if (PropertyExistsInOpenXmlType(openXmlTypeName, prop.Identifier.Text))
          return member;

        var targetElementTypeName = ResolveTargetElementTypeName(openXmlTypeName, prop, childElementTypes);
        var leadingTrivia = prop.GetLeadingTrivia();
        var docTrivia = leadingTrivia.Where(t =>
          t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) ||
          t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)).ToList();
        var otherTrivia = leadingTrivia.Except(docTrivia).ToList();
        var attr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName("OpenXmlElement"),
          SyntaxFactory.AttributeArgumentList(SyntaxFactory.SingletonSeparatedList(
            SyntaxFactory.AttributeArgument(
              SyntaxFactory.TypeOfExpression(SyntaxFactory.ParseTypeName(targetElementTypeName))))));
        var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attr))
          .WithLeadingTrivia(SyntaxFactory.TriviaList(docTrivia));
        var newProp = prop.WithLeadingTrivia(SyntaxFactory.TriviaList(otherTrivia))
          .WithAttributeLists(prop.AttributeLists.Add(attrList)).WithTrailingTrivia(prop.GetTrailingTrivia());
        Changed = true;
        return newProp;
      }
      return member;
    }).ToList();
    return classNode.WithMembers(SyntaxFactory.List(newMembers));
  }

  /// <summary>
  /// Determines when an Open XML type already exposes a property with the supplied name.
  /// </summary>
  /// <param name="openXmlTypeName">Fully-qualified Open XML type name.</param>
  /// <param name="propertyName">Property name to search for.</param>
  /// <returns><see langword="true"/> if the property exists; otherwise <see langword="false"/>.</returns>
  private bool PropertyExistsInOpenXmlType(string openXmlTypeName, string propertyName)
  {
    if (!TryResolveOpenXmlType(openXmlTypeName, out var type))
      return false;

    return type!.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase) !=
           null;
  }

  /// <summary>
  /// Attempts to resolve a type using alias expansion and loaded assemblies.
  /// </summary>
  /// <param name="typeName">Candidate type name, possibly using an alias.</param>
  /// <param name="type">Resolved <see cref="Type"/> when successful.</param>
  /// <returns><see langword="true"/> if the type is resolved; otherwise <see langword="false"/>.</returns>
  private bool TryResolveOpenXmlType(string typeName, out Type? type)
  {
    if (_typeCache.TryGetValue(typeName, out var cached))
    {
      type = cached!;
      return cached != null;
    }
    var resolvedName = ResolveNsAlias(typeName);
    type = Type.GetType(resolvedName, throwOnError: false, ignoreCase: false) ??
           OpenXmlFrameworkAssembly?.GetType(resolvedName, throwOnError: false, ignoreCase: false) ??
           OpenXmlAssembly?.GetType(resolvedName, throwOnError: false, ignoreCase: false);
    if (type == null)
    {
      var assembliesToSearch = AppDomain.CurrentDomain.GetAssemblies().ToList();
      foreach (var asm in assembliesToSearch)
      {
        type = asm.GetType(resolvedName, false, false);
        if (type != null)
          break;
      }
    }
    _typeCache[typeName] = type;
    return type != null;
  }

  /// <summary>
  /// Resolves namespace alias in the provided type name..
  /// </summary>
  /// <param name="typeName">Type name that may use an alias prefix.</param>
  /// <returns>The fully-qualified type name.</returns>
  private string ResolveNsAlias(string typeName)
  {
    var dotIndex = typeName.LastIndexOf('.');
    if (dotIndex > 0)
    {
      var alias = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue2(alias, out var ns))
        return ns + "." + typeName.Substring(dotIndex + 1);
    }
    return typeName;
  }

  /// <summary>
  /// Gets the namespace used in the provided type name, if any.
  /// </summary>
  /// <param name="typeName">Type name that may use an alias prefix.</param>
  /// <returns>The namespace if present; otherwise <see langword="null"/>.</returns>
  private string? GetNamespace(string typeName)
  {
    var dotIndex = typeName.LastIndexOf('.');
    if (dotIndex > 0)
    {
      var ns = typeName.Substring(0, dotIndex);
      return ns;
    }
    return null;
  }

  /// <summary>
  /// Set namespace alias for the type name.
  /// </summary>
  /// <param name="typeName">Type name that may use an alias prefix.</param>
  /// <returns>Aliased type name.</returns>
  private string SetAlias(string typeName)
  {
    var dotIndex = typeName.LastIndexOf('.');
    if (dotIndex > 0)
    {
      var ns = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue1(ns, out var alias))
        return alias + "." + typeName.Substring(dotIndex + 1);
    }
    return typeName;
  }

  /// Determines the most appropriate Open XML element type to reference in the <c>[OpenXmlElement]</c> attribute
  /// based on the property name, type, and child elements of the Open XML type.
  private string ResolveTargetElementTypeName
    (string openXmlTypeName, PropertyDeclarationSyntax prop, IReadOnlyList<Type> childElementTypes)
  {
    string? targetElementTypeName = null;
    var bestType = PickBestType(childElementTypes, prop);
    if (bestType != null)
      targetElementTypeName = bestType.FullName ?? bestType.Name;
    else
    {
      targetElementTypeName = prop.Identifier.Text;
      var ns = GetNamespace(openXmlTypeName);
      if (ns != null)
        targetElementTypeName = ns + "." + targetElementTypeName;
      if (TryResolveOpenXmlType(targetElementTypeName, out var elementType))
        targetElementTypeName = elementType!.FullName ?? elementType!.Name;
    }
    return SetAlias(targetElementTypeName);
  }

  /// <summary>
  /// Selects the most appropriate type from a list of candidates based on the specified property's name and type.
  /// </summary>
  /// <remarks>The selection process prioritizes exact matches by property name or type name, and otherwise
  /// ranks candidates by name similarity. If the candidates list is empty, the method returns null.</remarks>
  /// <param name="candidates">A read-only list of candidate types to evaluate for the best match.</param>
  /// <param name="prop">The property declaration for which to determine the most suitable type.</param>
  /// <returns>The type from the candidates that best matches the property's name or type;
  /// or null if no suitable match is found.</returns>
  private static Type? PickBestType(IReadOnlyList<Type> candidates, PropertyDeclarationSyntax prop)
  {
    if (candidates.Count == 0)
      return null;

    var propName = prop.Identifier.Text;
    var propTypeName = GetSimpleTypeName(prop.Type);
    var exact = candidates.FirstOrDefault(type => type.Name.Equals(propName, StringComparison.OrdinalIgnoreCase)) ??
                candidates.FirstOrDefault(type => type.Name.Equals(propTypeName, StringComparison.OrdinalIgnoreCase));
    if (exact != null)
      return exact;

    var nameCandidates = GetPropertyNameCandidates(propName).ToList();
    var useTypeName = !IsNonInformativeTypeName(propTypeName);
    return candidates
      .OrderByDescending(type =>
        nameCandidates.Count(name => type.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0))
      .ThenBy(type => nameCandidates.Min(name => GetLevenshteinDistance(type.Name, name)))
      .ThenBy(type => useTypeName ? GetLevenshteinDistance(type.Name, propTypeName) : int.MaxValue)
      .ThenBy(type => type.Name, StringComparer.OrdinalIgnoreCase).FirstOrDefault();
  }

  /// <summary>
  /// Generates a collection of candidate property names by considering common Boolean prefixes.
  /// </summary>
  /// <remarks>This method checks for the prefixes 'Is', 'Has', and 'Can' at the start of the property name and,
  /// if present, returns additional candidates with these prefixes removed. This can be useful for scenarios such as
  /// attribute mapping or code generation where alternative property name forms are needed.</remarks>
  /// <param name="propName">The name of the property for which to generate candidate names. This parameter cannot be null or consist only of
  /// white-space characters.</param>
  /// <returns>An enumerable collection of strings containing possible property name candidates derived from the input name. The
  /// collection may include the original name and variations with common prefixes removed.</returns>
  private static IEnumerable<string> GetPropertyNameCandidates(string propName)
  {
    if (!string.IsNullOrWhiteSpace(propName))
      yield return propName;

    if (propName.StartsWith("Is", StringComparison.Ordinal) && propName.Length > 2)
      yield return propName.Substring(2);
    else if (propName.StartsWith("Has", StringComparison.Ordinal) && propName.Length > 3)
      yield return propName.Substring(3);
    else if (propName.StartsWith("Can", StringComparison.Ordinal) && propName.Length > 3)
      yield return propName.Substring(3);
  }

  /// <summary>
  /// Determines whether the specified type name is considered non-informative, such as primitive types and common data
  /// types.
  /// </summary>
  /// <remarks>This method checks against a predefined list of common type names that are generally not
  /// informative in a descriptive context.</remarks>
  /// <param name="typeName">The name of the type to evaluate for informativity.
  /// This should be a string representation of a type name.</param>
  /// <returns>true if the type name is one of the predefined non-informative types; otherwise, false.</returns>
  private static bool IsNonInformativeTypeName(string typeName)
  {
    return typeName.Equals("bool", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("boolean", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("string", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("int", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("int32", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("long", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("int64", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("short", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("int16", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("byte", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("double", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("decimal", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("float", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("single", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("char", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("guid", StringComparison.OrdinalIgnoreCase) ||
           typeName.Equals("datetime", StringComparison.OrdinalIgnoreCase);
  }

  /// <summary>
  /// Calculates the Levenshtein distance between two strings, representing the minimum number of single-character edits
  /// required to transform one string into the other.
  /// </summary>
  /// <remarks>The comparison is case-insensitive. This method treats character substitutions, insertions, and
  /// deletions as valid edit operations.</remarks>
  /// <param name="a">The first string to compare.
  /// If null or empty, the distance is equal to the length of <paramref name="b"/>.</param>
  /// <param name="b">The second string to compare.
  /// If null or empty, the distance is equal to the length of <paramref name="a"/>.</param>
  /// <returns>The Levenshtein distance as an integer,
  /// indicating the minimum number of insertions, deletions, or substitutions
  /// needed to convert one string to the other.</returns>
  private static int GetLevenshteinDistance(string a, string b)
  {
    if (string.IsNullOrEmpty(a))
      return b?.Length ?? 0;
    if (string.IsNullOrEmpty(b))
      return a.Length;

    var n = a.Length;
    var m = b.Length;
    var previous = new int[m + 1];
    var current = new int[m + 1];
    for (int j = 0; j <= m; j++)
      previous[j] = j;
    for (int i = 1; i <= n; i++)
    {
      current[0] = i;
      for (int j = 1; j <= m; j++)
      {
        var cost = char.ToUpperInvariant(a[i - 1]) == char.ToUpperInvariant(b[j - 1]) ? 0 : 1;
        current[j] = Math.Min(Math.Min(current[j - 1] + 1, previous[j] + 1), previous[j - 1] + cost);
      }
      (previous, current) = (current, previous);
    }
    return previous[m];
  }

  /// <summary>
  /// Retrieves a read-only list of child element types associated with the specified Open XML type name.
  /// </summary>
  /// <remarks>This method caches the results for improved performance on subsequent calls with the same type
  /// name. It resolves the Open XML type and checks for valid types before retrieving child elements.</remarks>
  /// <param name="openXmlTypeName">The name of the Open XML type for which to retrieve child element types.
  /// This parameter must not be null or empty.</param>
  /// <returns>A read-only list of Type objects representing the child element types.
  /// The list will be empty if no child element
  /// types are found.</returns>
  private IReadOnlyList<Type> GetChildElementTypes(string openXmlTypeName)
  {
    if (_childElementTypesCache.TryGetValue(openXmlTypeName, out var cached))
      return cached;

    var result = new List<Type>();
    if (TryResolveOpenXmlType(openXmlTypeName, out var openXmlType) && openXmlType != null &&
        typeof(OpenXmlElement).IsAssignableFrom(openXmlType) && !openXmlType.IsAbstract &&
        !openXmlType.ContainsGenericParameters)
    {
      var remarksTypes = GetChildElementTypesFromRemarks(openXmlType);
      if (remarksTypes.Count > 0)
      {
        result.AddRange(remarksTypes);
      }
      var ctor = openXmlType.GetConstructor(Type.EmptyTypes);
      if (result.Count == 0 && ctor?.Invoke(Array.Empty<object>()) is OpenXmlElement element)
      {
        var metadata = GetElementMetadata(element);
        var metadataParticle = GetMetadataParticle(metadata);
        if (metadataParticle != null)
        {
          var children = new HashSet<Type>();
          CollectChildElementTypes(metadataParticle, children);
          result.AddRange(children);
        }
      }
    }
    _childElementTypesCache[openXmlTypeName] = result;
    return result;
  }

  /// <summary>
  /// Retrieves a list of child element types referenced in the XML documentation remarks for the specified OpenXml
  /// type.
  /// </summary>
  /// <remarks>This method parses the XML documentation associated with the assembly of the specified OpenXml
  /// type to extract child element types referenced in the remarks section. It specifically looks for 'see' elements
  /// that reference types, ensuring they are valid OpenXmlElement types.</remarks>
  /// <param name="openXmlType">The OpenXml type for which to retrieve child element types.
  /// This parameter must not be null.</param>
  /// <returns>A read-only list of Type objects representing the child element types
  /// defined in the XML documentation remarks.
  /// The list is empty if no child types are found.</returns>
  private IReadOnlyList<Type> GetChildElementTypesFromRemarks(Type openXmlType)
  {
    var xml = GetAssemblyXmlDocumentation(openXmlType.Assembly);
    if (xml == null)
      return [];

    var typeTag = $"T:{openXmlType.FullName}";
    var typeMember =
      xml.Descendants("member")
        .FirstOrDefault(e => string.Equals(e.Attribute("name")?.Value, typeTag, StringComparison.Ordinal)) ?? xml
        .Descendants("member").FirstOrDefault(e =>
          string.Equals(e.Attribute("name")?.Value, typeTag.Replace('+', '.'), StringComparison.Ordinal));
    var remarks = typeMember?.Element("remarks");
    if (remarks == null)
      return [];

    var result = new List<Type>();
    foreach (var crefValue in remarks.Descendants("see").Select(see => see.Attribute("cref")?.Value)
               .Where(cref => !string.IsNullOrWhiteSpace(cref)))
    {
      if (!crefValue!.StartsWith("T:", StringComparison.Ordinal))
        continue;

      var typeName = crefValue.Substring(2);
      if (TryResolveOpenXmlType(typeName, out var childType) && childType != null &&
          typeof(OpenXmlElement).IsAssignableFrom(childType) && !result.Contains(childType))
      {
        result.Add(childType);
      }
    }
    return result;
  }

  /// <summary>
  /// Retrieves the XML documentation for the specified assembly, if available.
  /// </summary>
  /// <remarks>This method checks multiple candidate paths for the XML documentation file and caches the results
  /// to improve performance on subsequent calls.</remarks>
  /// <param name="assembly">The assembly from which to load the XML documentation.</param>
  /// <returns>An XDocument containing the XML documentation for the assembly,
  /// or null if no documentation is found.</returns>
  private XDocument? GetAssemblyXmlDocumentation(Assembly assembly)
  {
    foreach (var xmlPath in GetXmlDocumentationCandidatePaths(assembly))
    {
      if (_xmlDocumentationCache.TryGetValue(xmlPath, out var cached))
      {
        if (cached != null)
          return cached;

        continue;
      }
      XDocument? loaded = null;
      if (File.Exists(xmlPath))
      {
        try
        {
          loaded = XDocument.Load(xmlPath);
        } catch
        {
          loaded = null;
        }
      }
      _xmlDocumentationCache[xmlPath] = loaded;
      if (loaded != null)
        return loaded;
    }
    return null;
  }

  /// <summary>
  /// Retrieves a collection of file paths to XML documentation files that may be associated with the specified
  /// assembly.
  /// </summary>
  /// <remarks>The method searches multiple locations for XML documentation files, including the assembly's
  /// location, the application's base directory, and common NuGet package directories. Each path in the returned
  /// collection is unique and non-empty if present.</remarks>
  /// <param name="assembly">The assembly for which to locate XML documentation files.
  /// This parameter cannot be null.</param>
  /// <returns>An enumerable collection of strings representing the paths to potential XML documentation files.
  /// The collection
  /// may be empty if no documentation files are found.</returns>
  private static IEnumerable<string> GetXmlDocumentationCandidatePaths(Assembly assembly)
  {
    var paths = new List<string>();
    var yielded = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    void YieldIfNew(string? path)
    {
      if (!string.IsNullOrWhiteSpace(path) && yielded.Add(path!))
        paths.Add(path ?? string.Empty);
    }
    var assemblyName = assembly.GetName().Name;
    if (string.IsNullOrWhiteSpace(assemblyName))
      return paths;

    var location = assembly.Location;
    if (!string.IsNullOrWhiteSpace(location))
      YieldIfNew(Path.ChangeExtension(location, ".xml"));
    YieldIfNew(Path.Combine(AppContext.BaseDirectory, assemblyName + ".xml"));
    var nugetPackages = Environment.GetEnvironmentVariable("NUGET_PACKAGES");
    if (string.IsNullOrWhiteSpace(nugetPackages))
    {
      var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
      if (!string.IsNullOrWhiteSpace(userProfile))
        nugetPackages = Path.Combine(userProfile, ".nuget", "packages");
    }
    if (!string.IsNullOrWhiteSpace(nugetPackages) && Directory.Exists(nugetPackages))
    {
      var packageId = assemblyName.ToLowerInvariant();
      var packageFolder = Path.Combine(nugetPackages, packageId);
      if (Directory.Exists(packageFolder))
      {
        var versionFolders = Directory.GetDirectories(packageFolder)
          .OrderByDescending(p => p, StringComparer.OrdinalIgnoreCase).Take(5);
        foreach (var versionFolder in versionFolders)
        {
          foreach (var xmlFile in Directory.EnumerateFiles(versionFolder, assemblyName + ".xml",
                     SearchOption.AllDirectories))
            YieldIfNew(xmlFile);
        }
      }
    }
    return paths;
  }

  /// <summary>
  /// Retrieves the metadata associated with the specified OpenXmlElement instance.
  /// </summary>
  /// <remarks>This method uses reflection to access internal metadata features of the OpenXml framework. Ensure
  /// that the OpenXmlFrameworkAssembly is properly initialized before calling this method.</remarks>
  /// <param name="element">The OpenXmlElement for which to obtain metadata. This parameter cannot be null.</param>
  /// <returns>An object representing the metadata of the specified element, or null if no metadata is available.</returns>
  private static object? GetElementMetadata(OpenXmlElement element)
  {
    var metadataFeatureType = OpenXmlFrameworkAssembly?.GetType(
      "DocumentFormat.OpenXml.Framework.Metadata.ElementMetadataFactoryFeature", throwOnError: false,
      ignoreCase: false);
    if (metadataFeatureType == null)
      return null;

    var metadataFeature = Activator.CreateInstance(metadataFeatureType, nonPublic: true);
    if (metadataFeature == null)
      return null;

    var getMetadataMethod = metadataFeatureType.GetMethod("GetMetadata",
      BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    if (getMetadataMethod == null)
      return null;

    return getMetadataMethod.Invoke(metadataFeature, [element]);
  }

  /// <summary>
  /// Retrieves the inner 'Particle' object from the specified metadata object, if available.
  /// </summary>
  /// <remarks>This method uses reflection to access a property named 'Particle' on the provided metadata object
  /// and its nested object. The metadata object is expected to have a specific structure with a 'Particle' property. If
  /// the required properties are not present, the method returns null.</remarks>
  /// <param name="metadata">The metadata object from which to extract the inner 'Particle'. This parameter can be null.</param>
  /// <returns>An object representing the inner 'Particle' if found; otherwise, null.</returns>
  private static object? GetMetadataParticle(object? metadata)
  {
    if (metadata == null)
      return null;

    var metadataType = metadata.GetType();
    var particleHolder = metadataType
      .GetProperty("Particle",
        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
      ?.GetValue(metadata);
    if (particleHolder == null)
      return null;

    return particleHolder.GetType()
      .GetProperty("Particle",
        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
      ?.GetValue(particleHolder);
  }

  /// <summary>
  /// Recursively collects the types of child elements contained within the specified particle and adds them to the
  /// provided set.
  /// </summary>
  /// <remarks>This method inspects the structure of the particle to determine whether it represents an element
  /// or a composite, and traverses nested particles as needed. It is intended for use with objects that follow a
  /// specific particle model, such as those found in Open XML SDK internal representations.</remarks>
  /// <param name="particle">An object representing a particle, which may contain child elements whose types are to be collected.
  /// The object is  expected to have properties that identify its type and any child particles.</param>
  /// <param name="result">A set that receives the unique types of child elements found within the particle and its descendants.
  /// Must not be null.</param>
  private static void CollectChildElementTypes(object particle, HashSet<Type> result)
  {
    var particleType = particle.GetType();
    var fullName = particleType.FullName;
    if (fullName?.EndsWith(".ElementParticle", StringComparison.Ordinal) == true)
    {
      if (particleType.GetProperty("ElementType",
              BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
            ?.GetValue(particle) is Type elementType)
        result.Add(elementType);
      return;
    }
    if (fullName?.EndsWith(".CompositeParticle", StringComparison.Ordinal) == true)
    {
      var children =
        particleType
          .GetProperty("ChildrenParticles",
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
          ?.GetValue(particle) as System.Collections.IEnumerable;
      if (children == null)
        return;

      foreach (var child in children)
      {
        if (child != null)
          CollectChildElementTypes(child, result);
      }
      return;
    }
    var nestedChildren =
      particleType
        .GetProperty("ChildrenParticles",
          BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
        ?.GetValue(particle) as System.Collections.IEnumerable;
    if (nestedChildren == null)
      return;

    foreach (var child in nestedChildren)
    {
      if (child != null)
        CollectChildElementTypes(child, result);
    }
  }

  /// <summary>
  /// Retrieves the simple type name from the specified type syntax node.
  /// </summary>
  /// <remarks>This method supports various C# type syntax forms, including identifiers, qualified names,
  /// alias-qualified names, nullable types, and generic types. For nullable types, the underlying type name is
  /// returned.</remarks>
  /// <param name="typeSyntax">The type syntax node from which to extract the simple type name.
  /// This can represent an identifier, qualified name,
  /// alias-qualified name, nullable type, or generic type.</param>
  /// <returns>A string containing the simple type name derived from the provided type syntax node.</returns>
  private static string GetSimpleTypeName(TypeSyntax typeSyntax)
  {
    return typeSyntax switch
    {
      IdentifierNameSyntax id => id.Identifier.Text,
      QualifiedNameSyntax qualified => qualified.Right.Identifier.Text,
      AliasQualifiedNameSyntax aliasQualified => aliasQualified.Name.Identifier.Text,
      NullableTypeSyntax nullable => GetSimpleTypeName(nullable.ElementType),
      GenericNameSyntax generic => generic.Identifier.Text,
      _ => typeSyntax.ToString()
    };
  }
}