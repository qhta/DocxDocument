namespace ModelGen;

public partial class ModelExtGenerator : ModelGenerator
{
  public ModelExtGenerator(ProcessOptions options) : base(options)
  {
    SolutionName = "GeneratedModel";
    GlobalUsings.Add("DocumentFormat.OpenXml");
  }

  protected override void GenerateHeader(TypeInfo typeInfo, string? typeName, TypeKind kind)
  {
    if (kind == TypeKind.@interface)
    {
      var str = $"public partial interface {typeName}";
      Writer.WriteLine(str);
    }
    else if (kind == TypeKind.@class)
    {
      var sourceTypeName = typeInfo.GetFullName(false, true, true);
      string? px = null;
      var ns = sourceTypeName.Namespace;
      if (ns != null)
      {
        if (!ns.StartsWith("System"))
          px = ns + ".";
        ns = typeInfo.GetFullName(false, true, false).Namespace;
        if (ns!=null)
          GlobalUsings.Add(ns);
      }
      var baseClassName = "ModelElement";
      if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DXPack.OpenXmlPart)))
         baseClassName = "ModelPartElement";

      var str = $"public partial class {typeName}: {baseClassName}<{px}{typeName}>";
      Writer.WriteLine(str);
    }
    else
      throw new NotImplementedException($"GenerateClassOrInterface not implemented for kind {kind}");
  }

  protected override bool GenerateConstructors(TypeInfo typeInfo, string? typeName, TypeKind kind)
  {
    var sourceTypeName = typeInfo.GetFullName(false, true, true);
    string? px = null;
    var ns = sourceTypeName.Namespace;
    if (ns != null)
    {
      if (!ns.StartsWith("System"))
        px = ns + ".";
    }
    Writer.WriteLine($"public {typeName}(): base(){{ }}");
    Writer.WriteLine();
    var baseClassName = "DX.OpenXmlElement";
    if (typeInfo.Type.IsEqualOrSubclassOf(typeof(DXPack.OpenXmlPart)))
         baseClassName = "DXPack.OpenXmlPart";
    Writer.WriteLine($"public {typeName}({baseClassName} openXmlElement): base(openXmlElement) {{ }}");
    Writer.WriteLine();
    Writer.WriteLine($"public {typeName}({px}{sourceTypeName.Name} openXmlElement): base(openXmlElement) {{ }}");
    Writer.WriteLine();
    return true;
  }

  protected override bool GenerateProperty(PropInfo prop, string? inNamespace, TypeKind kind)
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
    Writer.WriteLine($"public {px}{propTypeName}{qm} {prop.Name}");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"get");
    GeneratePropertyGetter(prop);
    Writer.WriteLine($"set");
    GeneratePropertySetter(prop);
    Writer.Indent--;
    Writer.WriteLine($"}}");
    Writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return true;

  }

}

