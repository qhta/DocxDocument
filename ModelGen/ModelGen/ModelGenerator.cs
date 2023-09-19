namespace ModelGen;

public class ModelGenerator : BaseCodeGenerator
{
  public ModelGenerator(string projectName, string outputPath)
  {
    ProjectName = projectName;
    OutputPath = outputPath;
  }


  public override int GenerateCode(IEnumerable<Namespace> nspaces)
  {
    PrepareProject();
    var nsTypes = new Dictionary<Namespace, TypeInfo[]>();
    var totalTypesCount = 0;
    foreach (var nspace in nspaces)
    {
      Debug.Assert(nspace.TargetName != null);
      CreateNamespaceFolder(nspace.TargetName);
      var types = nspace.AcceptedTypes(PPS.CodeGen).Where(item => !item.IsConstructedGenericType).ToArray();
      nsTypes.Add(nspace, types);
      totalTypesCount+=types.Count();
    }
    var nspacesCount = 0;
    var typesCount = 0;
    foreach (var nsType in nsTypes)
    {
      nspacesCount++;
      foreach (var type in nsType.Value)
      {
        typesCount++;
        _onGeneratingType?.Invoke(new ProgressTypeInfo { Namespaces = nspacesCount, ProcessedTypes = typesCount, TotalTypes = totalTypesCount });
        GenerateTypeFile(type);
      }
    }
    return typesCount;
  }

  public void PrepareProject()
  {
    if (!Directory.Exists(OutputPath))
      Directory.CreateDirectory(OutputPath);
    ClearProjectFolder(OutputPath);
    GenerateProjectFile(ProjectName, System.IO.Path.Combine(OutputPath, ProjectName + ".csproj"));
  }

  private void ClearProjectFolder(string path)
  {
    var subfolders = Directory.GetDirectories(path);
    foreach (var subfolder in subfolders)
    {
      try
      {
        ClearProjectFolder(subfolder);
        if (!subfolder.EndsWith("Extensions"))
        {
          foreach (var file in Directory.GetFiles(subfolder))
          {
            if (file.EndsWith(".cs") && file.Count(ch => ch == '.') == 1)
            {
              try
              {
                File.Delete(file);
              }
              catch
              {
                Debug.WriteLine($"Could not delete file \"{file}\"");
              }
            }
          }
          var files = Directory.GetFiles(subfolder);
          if (files.Count() == 0)
            Directory.Delete(subfolder, false);
        }
      }
      catch
      {
        Debug.WriteLine($"Could not delete subfolder \"{subfolder}\"");
      }
    }
  }

  private bool GenerateProjectFile(string projectName, string filename)
  {
    var projectFilename = projectName + ".csproj.xml";
    if (!File.Exists(projectFilename))
    {
      Debug.WriteLine($"Project template file \"{projectFilename}\" not found");
      return false;
    }
    AssurePathExists(filename);
    using (var writer = File.CreateText(filename))
    using (var reader = File.OpenText(projectFilename))
    {
      var s = reader.ReadToEnd();
      writer.Write(s);
    }
    return true;
  }

  private bool CreateNamespaceFolder(string ns)
  {
    if (ns.StartsWith(ProjectName + "."))
      ns = ns.Substring(ProjectName.Length + 1);
    else
    if (ns == ProjectName)
      ns = "";
    return CreateNamespaceFolder(ProjectName, System.IO.Path.Combine(OutputPath, ns));
  }

  private bool CreateNamespaceFolder(string projectName, string nsPath)
  {
    if (!Directory.Exists(nsPath))
      Directory.CreateDirectory(nsPath);
    return true;
  }

  public bool GenerateTypeFile(TypeInfo typeInfo)
  {
    if (!typeInfo.IsConverted && !typeInfo.IsConvertedTo)
    {
      if (typeInfo.TypeKind == TypeKind.@enum)
        GenerateEnumType(typeInfo);
      else if (!typeInfo.IsGenericTypeParameter)
        GenerateClassType(typeInfo);
      return true;
    }
    return false;
  }

  #region Class type generation

  private bool GenerateClassType(TypeInfo type)
  {
    var typeName = type.Name;
    var aNamespace = type.GetTargetNamespace();
    aNamespace = TrimDocumentModel(aNamespace);
    var outputPath = Path.Combine(OutputPath, aNamespace);
    return GenerateClassOrInterface(type, typeName, Path.Combine(outputPath, "Classes", typeName + ".cs"), TypeKind.@class);
  }

  private bool GenerateClassOrInterface(TypeInfo type, string typeName, string filename, TypeKind kind)
  {
    if (!AssurePathExists(filename))
      return false;
    using (var textWriter = File.CreateText(filename))
    using (Writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateClassOrInterface(type, typeName, kind);
    }
  }

  private bool GenerateClassOrInterface(TypeInfo typeInfo, string typeName, TypeKind kind)
  {
    var aNamespace = typeInfo.GetTargetNamespace();
    if (aNamespace != null)
    {
      Writer.WriteLine($"namespace {aNamespace};");
      Writer.WriteLine();
    }

    GenerateDocumentationComments(typeInfo);
    GenerateCustomAttributes(typeInfo.CustomAttributes);

    if (kind == TypeKind.@interface)
    {
      var str = $"public partial interface {typeName}";
      Writer.WriteLine(str);
    }
    else if (kind == TypeKind.@class)
    {
      var str = $"public partial class {typeName}";
      Writer.WriteLine(str);
    }
    else
      throw new NotImplementedException($"GenerateClassOrInterface not implemented for kind {kind}");
    Writer.WriteLine("{");
    Writer.Indent++;

    var ok = GenerateAcceptedProperties(typeInfo, aNamespace, kind);
    Writer.Indent--;
    Writer.WriteLine("}");
    if (kind == TypeKind.@interface)
      GeneratedInterfacesCount += 1;
    else if (kind == TypeKind.@class)
      GeneratedClassesCount += 1;
    return ok;
  }

  private bool GenerateAcceptedProperties(TypeInfo typeInfo, string? inNamespace, TypeKind kind)
  {
    foreach (var prop in typeInfo.AcceptedProperties(PPS.CodeGen))
      if (!GenerateProperty(prop, inNamespace, kind))
        return false;
    return true;
  }

  //private bool GenerateItemsProperties(TypeInfo typeInfo, SchemaParticle constraint, string fromClassName, string? inNamespace,
  //  List<string> subclassesTypeNames, TypeKind kind)
  //{
  //  if (constraint is ItemTypeParticle itemTypeConstraint)
  //  {
  //    var prop = itemTypeConstraint.AccessProperty;
  //    if (prop != null)
  //      if (!GenerateProperty(prop, inNamespace, kind))
  //        return false;
  //  }
  //  else
  //  if (constraint is ItemsParticle itemsCompoundConstraint)
  //  {
  //    //var constraintClassName = fromClassName + constraint.ConstraintType.ToString();
  //    //subclassesTypeNames.Add(constraintClassName);
  //    //if (constraint.ConstraintType == ConstraintType.Group && !constraint.IsRequired && !constraint.IsMultiple)
  //    //{
  //    //  foreach (var itemConstraint in itemsCompoundConstraint.Items)
  //    //  {
  //    //    if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames, TypeKind.EmbeddedClass))
  //          return false;
  //      //}
  //    //}
  //  }
  //  return true;
  //}

  private bool GenerateProperty(PropInfo prop, string? inNamespace, TypeKind kind)
  {
    var targetPropType = prop.PropertyType.GetConversionTargetOrSelf();
    FullTypeName targetPropTypeName = prop.PropertyType.GetConvertedName(TypeKind.type);
    TrimNamespace(targetPropTypeName);
    var propTypeName = targetPropTypeName.ToString();
    string qm = "?";
    GenerateDocumentationComments(prop);
    GenerateCustomAttributes(prop.CustomAttributes);
    //if (prop.IsReadonly)
    //  Writer.WriteLine($"public {propTypeName}{qm} {prop.Name} {{ get; }}");
    //else
    Writer.WriteLine($"public {propTypeName}{qm} {prop.Name} {{ get; set; }}");
    Writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return true;
  }
  #endregion

  #region Enum types generation
  private bool GenerateEnumType(TypeInfo type)
  {
    var outputPath = OutputPath;
    var aNamespace = type.GetTargetNamespace();
    aNamespace = TrimDocumentModel(aNamespace);
    outputPath = Path.Combine(outputPath, aNamespace);
    var typeName = type.Name;
    var fileName = ValidateFilename(typeName);
    if (!GenerateEnumType(type, typeName, Path.Combine(outputPath, "Enums", fileName + ".cs")))
      return false;
    GeneratedEnumTypesCount += 1;
    return true;
  }

  private bool GenerateEnumType(TypeInfo type, string typeName, string filename)
  {
    AssurePathExists(filename);
    using (var textWriter = File.CreateText(filename))
    using (Writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateEnumType(type, typeName);
    }
  }

  private bool GenerateEnumType(TypeInfo type, string typeName)
  {
    var aNamespace = type.GetNamespace(true, true);
    if (aNamespace != null)
    {
      Writer.WriteLine($"namespace {aNamespace};");
      Writer.WriteLine();
    }
    GenerateDocumentationComments(type);
    GenerateCustomAttributes(type.CustomAttributes);
    Writer.WriteLine($"public enum {typeName}");
    Writer.WriteLine("{");
    Writer.Indent++;
    if (type.EnumValues != null)
      foreach (var field in type.EnumValues)
        if (!GenerateEnum(field))
          return false;
    Writer.Indent--;
    Writer.WriteLine("}");
    return true;
  }

  private bool GenerateEnum(EnumInfo field)
  {
    bool addEmptyLine = GenerateDocumentationComments(field);
    if (field.CustomAttributes != null)
    {
      GenerateCustomAttributes(field.CustomAttributes);
      addEmptyLine = true;
    }
    Writer.WriteLine($"{field.Name},");
    if (addEmptyLine)
      Writer.WriteLine();
    GeneratedEnumValuesCount += 1;
    return true;
  }
  #endregion

  protected override bool AssurePathExists(string filename)
  {
    //if (File.Exists(filename))
    //  return false;
    var filePath = Path.GetDirectoryName(filename) ?? string.Empty;
    if (filePath.Contains(@"\Properties"))
      return false;
    if (filePath != null)
      if (!Directory.Exists(filePath))
      {
        Directory.CreateDirectory(filePath);
      }
    return true;
  }
}

