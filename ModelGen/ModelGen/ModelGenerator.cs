namespace ModelGen;

public class ModelGenerator : BaseCodeGenerator
{
  public ModelGenerator(ProcessOptions options)
  {
    SolutionName = "GeneratedModel";
    if (options.ProjectName == null)
      throw new InvalidOperationException(CommonStrings.Project_name_not_defined);
    if (options.CodeOutputPath == null)
      throw new InvalidOperationException(CommonStrings.Code_output_path_not_defined);
    if (options.SolutionName == null)
      throw new InvalidOperationException(CommonStrings.Solution_name_not_defined);
    SolutionName = options.SolutionName;
    ProjectName = options.ProjectName;
    OutputPath = options.CodeOutputPath;
    ConfigPath = Path.GetDirectoryName(ModelConfig.GetFilename());
  }

  public override bool GenerateTypeFile(TypeInfo typeInfo)
  {
    if (typeInfo.TypeKind == TypeKind.@enum)
      return GenerateEnumType(typeInfo);
    else
      return GenerateClassType(typeInfo);
  }

  #region Class type generation

  private bool GenerateClassType(TypeInfo type)
  {
    var typeName = type.TargetName;
    var aNamespace = type.GetTargetNamespace();
    aNamespace = TrimDocumentModel(aNamespace);
    var outputPath = Path.Combine(OutputPath, aNamespace);
    return GenerateClassOrInterface(type, typeName, Path.Combine(outputPath, typeName + ".cs"), TypeKind.@class);
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

    GenerateHeader(typeInfo, typeName, kind);

    Writer.WriteLine("{");
    Writer.Indent++;
    if (kind == TypeKind.@class)
      GenerateConstructors(typeInfo, typeName, kind);

    var ok = GenerateAcceptedProperties(typeInfo, aNamespace, kind);
    Writer.Indent--;
    Writer.WriteLine("}");
    if (kind == TypeKind.@interface)
      GeneratedInterfacesCount += 1;
    else if (kind == TypeKind.@class)
      GeneratedClassesCount += 1;
    return ok;
  }

  protected virtual void GenerateHeader(TypeInfo typeInfo, string? typeName, TypeKind kind)
  {
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
  }

  protected virtual bool GenerateConstructors(TypeInfo typeInfo, string typeName, TypeKind kind)
  {
    return false;
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

  protected virtual bool GenerateProperty(PropInfo prop, string? inNamespace, TypeKind kind)
  {
    var targetPropType = prop.PropertyType.GetConversionTargetOrSelf();
    var targetPropTypeName = prop.TargetPropertyTypeName ??
      targetPropType.GetFullName(true, true, true);
    var propTypeName = targetPropTypeName.Name;
    string? px = null;
    var ns = targetPropTypeName.Namespace;
    if (ns != null)
    {
      if (!ns.StartsWith("System"))
        px = ns + ".";
    }
    string qm = "?";
    GenerateDocumentationComments(prop);
    GenerateCustomAttributes(prop.CustomAttributes);
    Writer.WriteLine($"[DataMember]");
    Writer.WriteLine($"public {px}{propTypeName}{qm} {prop.Name} {{ get; set; }}");
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
    var typeName = type.TargetName;
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
    var aNamespace = type.GetNamespace(true, false);
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

}

