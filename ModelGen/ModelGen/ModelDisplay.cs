namespace ModelGen;

public static class ModelDisplay
{


  private static IndentedTextWriter Writer { get; set; } = new IndentedTextWriter(Console.Out, "  ");
  //private static int IndentLength = 2;
  private static int LineLength = 0;

  public static void SetOutput(TextWriter textWriter)
  {
    Writer = new IndentedTextWriter(textWriter, "  ");
  }

  public static void WriteLine(string? str)
  {
    Writer.WriteLine(str);
    LineLength = (str?.Length ?? 0);
  }
  public static void WriteLine()
  {
    Writer.WriteLine();
    LineLength = 0;
  }

  public static void WriteSameLine(string str)
  {
    int maxLength = Console.WindowWidth-1;
    if (str.Length>maxLength)
      str = str.Substring(maxLength);
    var l = str?.Length ?? 0;
    int n = (l < LineLength) ? LineLength - l : 0;
    Writer.Write($"\r{str}");
    if (n > 0)
      Writer.Write(new String(' ',n));
    LineLength = l;
  }

  public static void ShowNamespaces(OTS filter)
  {
    var namespaces = TypeManager.GetNamespaces(filter);
    if (namespaces.Any())
    {
      var maxNamespaceLength = namespaces.Max(item => item.Length);
      foreach (var nspace in namespaces)
      {
        var aSpace = nspace;
        if (aSpace.Length < maxNamespaceLength)
          aSpace = aSpace + new string(' ', maxNamespaceLength - aSpace.Length);
        var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToArray();
        var nSpaceTypesCount = nSpaceTypes.Count();
        var nSpaceAcceptedCount = nSpaceTypes.Count(item => item.IsAccepted == true);
        var nSpaceClassesCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Class);
        var nSpaceEnumsCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Enum);
        var nSpaceOtherCount = nSpaceTypes.Count(item => item.TypeKind == TypeKind.Type);
        var str = $"{aSpace} {nSpaceTypesCount} types";
        str += $", {AllNone(nSpaceAcceptedCount, nSpaceTypesCount)} accepted";
        if (nSpaceClassesCount != 0)
          str += $", {AllNone(nSpaceClassesCount, nSpaceTypesCount)} {Multi(nSpaceClassesCount, "class")}";
        if (nSpaceEnumsCount != 0)
          str += $", {AllNone(nSpaceEnumsCount, nSpaceTypesCount)} {Multi(nSpaceEnumsCount, "enum")}";
        if (nSpaceOtherCount != 0)
          str += $", {AllNone(nSpaceOtherCount, nSpaceTypesCount)} other types";
        Writer.WriteLine(str);
      }
    }
  }

  public static void ShowNamespaceDetails(OTS filter, ShowOptions options)
  {
    foreach (var nspace in TypeManager.GetNamespaces(filter).ToList())
    {
      Writer.Indent++;
      ShowNamespaceDetails(nspace, options);
      Writer.Indent--;
    }
  }

  public static void ShowNamespaceDetails(string nspace, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    var nSpaceTypes = TypeManager.GetNamespaceTypes(nspace).ToList();
    if (options.AcceptedTypesOnly)
      nSpaceTypes = nSpaceTypes.Where(item => item.IsAccepted == true).ToList();
    if (nSpaceTypes.Count() > 0)
    {
      Writer.WriteLine();
      Writer.WriteLine($"namespace {nspace}");
      Writer.Indent++;
      foreach (var typeInfo in nSpaceTypes)
      {
        if (typeInfo.IsGenericTypeParameter)
          continue;
        ShowTypeInfo(typeInfo, options, semanticsFilter);
      }
      Writer.Indent--;
    }
  }

  private static string[] constaints = new string[]
  {
    "covariant",
    "contravariant",
    "class",
    "struct",
    "new()"
  };

  public static void ShowTypes(string nspace, string name)
  {
    var types = TypeManager.GetNamespaceDictionary(nspace).Where(item => item.Name.StartsWith(name));
    foreach (var type in types)
    {
      ShowTypeInfo(type);
    }
  }

  public static void ShowTypeInfo(TypeInfo typeInfo, ShowOptions options = null!, Semantics[]? semanticsFilter = null)
  {
    if (options == null) options = new();
    if (!typeInfo.IsReflected)
      typeInfo.WaitForReflection();
    var str = $"{typeInfo.TypeKind.ToString().ToLower()} {typeInfo.GetFullName(options.OriginalNames)}";
    var changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo);
    if (changedToType != null)
      str += $" => {changedToType.GetFullName(options.OriginalNames)}";
    //else if (typeInfo.IsAccepted != null)
    //  str += $" {{{Accepted(typeInfo.IsAccepted)}}}";
    Writer.WriteLine(str);
    if (options.HideUnacceptedTypeDetails && typeInfo.IsAccepted == false)
      return;
    Writer.Indent++;
    if (options.BaseTypes && typeInfo.BaseTypeInfo != null)
    {
      str = $"based on: {typeInfo.BaseTypeInfo.GetFullName(options.OriginalNames)}";
      changedToType = ModelManager.GetConversionTargetOrSelf(typeInfo.BaseTypeInfo);
      if (changedToType != null)
        str += $" => {changedToType.GetFullName(options.OriginalNames)}";
      //else if (typeInfo.BaseTypeInfo.IsAccepted != null)
      //  str += $" {{{Accepted(typeInfo.BaseTypeInfo.IsAccepted)}}}";
      Writer.WriteLine(str);
    }
    if (options.ImplementedInterfaces)
      ShowImplementedInterfaces(typeInfo, options);
    if (options.GenericParamsConstraints)
      ShowGenericParamsConstraints(typeInfo, options);
    if (options.OutgoingRelationships)
      ShowOutgoingRelationships(typeInfo, options, semanticsFilter);
    if (options.IncomingRelationships)
      ShowIncomingRelationships(typeInfo, options, semanticsFilter);
    if (options.IncludedTypes)
      ShowIncludedTypes(typeInfo, options);
    if (options.EnumValues)
      ShowEnumValues(typeInfo, options);
    if (options.Properties)
      ShowProperties(typeInfo, options);
    Writer.Indent--;
  }

  public static void ShowGenericParamsConstraints(TypeInfo typeInfo, ShowOptions options)
  {
    var genericTypeParams = typeInfo.GetGenericParamTypes();
    if (genericTypeParams != null)
    {
      foreach (var genericTypeParam in genericTypeParams.ToArray())
      {
        var ls = new List<String>();
        var genericTypeParamsConstraints = genericTypeParam.GetGenericTypeParamConstraints();
        if (genericTypeParamsConstraints != null)
          foreach (var item in genericTypeParamsConstraints.ToArray())
            ls.Add(item.GetFullName(options.OriginalNames));
        var genericParamConstraints = genericTypeParam.GetGenericParamConstraints();
        if (genericParamConstraints != null)
          foreach (var item in genericParamConstraints.ToArray())
            ls.Add(constaints[(int)item]);
        if (ls.Count > 0)
        {
          var str = $"where {genericTypeParam.Name}: " + String.Join(", ", ls);
          Writer.WriteLine(str);
        }
      }
    }
  }

  public static void ShowImplementedInterfaces(TypeInfo typeInfo, ShowOptions options)
  {
    var implementedInterfaces = typeInfo.GetInterfaces();
    if (implementedInterfaces.Any())
    {
      foreach (var intfType in implementedInterfaces.Take(10).ToArray())
      {
        var str = $"implements {intfType.GetFullName(options.OriginalNames)}";
        Writer.WriteLine(str);
      }
      if (implementedInterfaces.Count()>10)
        Writer.WriteLine("...");
    }
  }

  public static void ShowIncludedTypes(TypeInfo typeInfo, ShowOptions options)
  {
    var includedTypes = typeInfo.GetIncludedTypes();
    if (includedTypes.Any())
    {
      foreach (var intfType in includedTypes.Take(10).ToArray())
      {
        var str = $"includes {intfType.GetFullName(options.OriginalNames)}";
        Writer.WriteLine(str);
      }
      if (includedTypes.Count()>10)
        Writer.WriteLine("...");
    }
  }
  public static void ShowOutgoingRelationships(TypeInfo typeInfo, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    var outgoingRels = TypeManager.GetOutgoingRelationships(typeInfo).ToList();
    if (options.ExcludeSemantics && semanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => !semanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.SelectedSemantics && semanticsFilter != null)
      outgoingRels = outgoingRels.Where(item => semanticsFilter.Contains(item.Semantics)).ToList();
    if (outgoingRels.Any())
    {
      Writer.WriteLine($"has {outgoingRels.Count} outgoing {Multi(outgoingRels.Count, "relationship")}");
      foreach (var rel in outgoingRels.Take(10))
      {
        Writer.Indent++;
        Writer.WriteLine($"{rel.Semantics} -> {rel.Target.ToString()}");
        Writer.Indent--;
      }
      if (outgoingRels.Count()>10)
        Writer.WriteLine("...");

    }
  }

  public static void ShowIncomingRelationships(TypeInfo typeInfo, ShowOptions options, Semantics[]? semanticsFilter = null)
  {
    var incomingRels = TypeManager.GetIncomingRelationships(typeInfo).ToList();
    if (options.ExcludeSemantics && semanticsFilter != null)
      incomingRels = incomingRels.Where(item => !semanticsFilter.Contains(item.Semantics)).ToList();
    else
    if (options.SelectedSemantics && semanticsFilter != null)
      incomingRels = incomingRels.Where(item => semanticsFilter.Contains(item.Semantics)).ToList();
    if (incomingRels.Any())
    {
      Writer.WriteLine($"has {incomingRels.Count} incoming {Multi(incomingRels.Count, "relationship")}");
      foreach (var rel in incomingRels.Take(10))
      {
        Writer.Indent++;
        Writer.WriteLine($"{rel.Semantics} <- {rel.Source.ToString()}");
        Writer.Indent--;
      }
      if (incomingRels.Count()>10)
        Writer.WriteLine("...");
    }
  }

  public static void ShowEnumValues(TypeInfo typeInfo, ShowOptions options)
  {
    var enumValues = typeInfo.EnumValues;
    if (enumValues != null && enumValues.Any())
    {
      Writer.WriteLine("{");
      foreach (var enumValue in enumValues.Take(10).ToArray())
      {
        Writer.Indent++;
        var str = $"{enumValue.Name}";
        Writer.WriteLine(str);
        Writer.Indent--;
      }
      if (enumValues.Count()>10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public static void ShowProperties(TypeInfo typeInfo, ShowOptions options)
  {
    if (options.HideUnacceptedProperties && typeInfo.IsAccepted == false)
      return;
    var properties = typeInfo.Properties;
    if (properties != null && properties.Any())
    {
      Writer.WriteLine("{");
      foreach (var property in properties.Take(1).ToArray())
      {
        if (options.HideUnacceptedProperties && property.IsAccepted == false)
          continue;
        Writer.Indent++;
        var str = $"{property.Name}: {property.PropertyType.GetFullName(options.OriginalNames)}";
        var changedToType = ModelManager.GetConversionTargetOrSelf(property.PropertyType);
        if (changedToType != null)
          str += $" => {changedToType.GetFullName(options.OriginalNames)}";
        //else if (property.PropertyType.IsAccepted != null)
        //  str += $" {{{Accepted(property.PropertyType.IsAccepted)}}}";
        Writer.WriteLine(str);
        Writer.Indent--;
      }
      if (properties.Count()>10)
        Writer.WriteLine("...");
      Writer.WriteLine("}");
    }
  }

  public static void ShowTypeConversions()
  {
    foreach (var type in TypeManager.AllTypes)
    {
      ShowTypeConversion(type);
    }
  }

  public static void ShowTypeConversion(TypeInfo type)
  {
    if (type.IsConverted)
    {
      var convTarget = ModelManager.GetConversionTargetOrSelf(type);
      if (convTarget != null)
      {
        Writer.WriteLine($"{type} => {convTarget}");
        Writer.Indent++;
        ShowTypeConversion(convTarget);
        Writer.Indent--;
      }
    }
  }
  
  public static void ShowTypeRenames()
  {
    foreach (var typeInfo in TypeManager.AllTypes)
    {
      if (typeInfo.Name != typeInfo.OriginalName)
      {
        Writer.WriteLine($"{typeInfo.OriginalName} --> {typeInfo.Name}");
      }
    }
  }

  private static string AllNone(int n, int cmp) => (n == 0) ? "none" : (n == cmp) ? "all" : n.ToString();

  private static string Multi(int n, string single, string? multi = null) => (n == 1) ? single : (multi ?? (single.EndsWith("s") ? (single + "es") : (single + "s")));

  private static string Accepted(bool? isAccepted) => isAccepted == true ? "accepted" : (isAccepted == false) ? "unaccepted" : string.Empty;
}

