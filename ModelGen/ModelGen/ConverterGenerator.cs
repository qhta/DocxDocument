using System.Runtime.CompilerServices;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel;
using Qhta.TypeUtils;
using Qhta.TextUtils;
using Text = DocumentFormat.OpenXml.Drawing.Text;
using System.Reflection;
using System.Xml.Linq;
using DocumentModel.OpenXml;
using InvalidOperationException = System.InvalidOperationException;

namespace ModelGen;

public class ConverterGenerator : BaseCodeGenerator
{
  public ConverterGenerator(string projectName, string outputPath)
  {
    ProjectName = projectName + ".OpenXml";
    OutputPath = outputPath + ".OpenXml";
  }

  public int SkippedTypesCount { get; private set; }

  public bool GenerateConverterFile(TypeInfo typeInfo)
  {
    if (typeInfo.Name.EndsWith("Settings"))
      Debug.Assert(true);
    if (!typeInfo.IsConverted && !typeInfo.IsConvertedTo)
    {
      if (!typeInfo.IsGenericTypeParameter)
      {
        if (typeInfo.Type.IsEnum)
          SkippedTypesCount++;
        else if (IsOpenXmlLeafEnumValueType(typeInfo.Type))
          SkippedTypesCount++;
        else
          GenerateConverterClass(typeInfo);
      }
      return true;
    }
    return false;
  }

  #region helper starting methods

  protected static bool IsOpenXmlLeafEnumValueType(Type type)
  {
    //if (type.Name == "StyleSet")
    //  Debug.Assert(true);
    if (type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
    {
      var valProperty = type.GetProperty("Val");
      if (valProperty != null && type.GetProperties().Count() == 1)
      {
        var propType = valProperty.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum) return true;
        }
      }
    }
    return false;
  }

  protected static Type? GetOpenXmlLeafEnumValueType(Type type)
  {
    //if (type.Name == "Settings")
    //  Debug.Assert(true);
    if (type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
    {
      var valProperty = type.GetProperty("Val");
      if (valProperty != null)
      {
        var propType = valProperty.PropertyType;
        if (propType.Name.StartsWith("EnumValue"))
        {
          var argType = propType.GenericTypeArguments.FirstOrDefault();
          if (argType != null && argType.IsEnum) return argType;
        }
      }
    }
    return null;
  }

  protected static Type? GetOpenXmlEnumValueType(Type type)
  {
    var propType = type;
    if (propType.Name.StartsWith("EnumValue"))
    {
      var argType = propType.GenericTypeArguments.FirstOrDefault();
      if (argType != null && argType.IsEnum) return argType;
    }
    return null;
  }

  protected override bool AssurePathExists(string filename)
  {
    var path = Path.GetDirectoryName(filename) ?? "";
    while (!path.EndsWith("OpenXml"))
      path = Path.GetDirectoryName(path) ?? "";
    var baseConverterPath = Path.Combine(path, "BaseConverters", Path.GetFileName(filename));
    if (File.Exists(baseConverterPath))
      return false;
    var filePath = Path.GetDirectoryName(filename) ?? string.Empty;
    //if (filePath.EndsWith(@"\Properties"))
    //  return false;
    var newFilename = Path.ChangeExtension(filename, ".new.cs");
    if (File.Exists(newFilename))
      return false;
    var extFilename = Path.ChangeExtension(filename, ".ext.cs");
    if (File.Exists(extFilename))
      return false;
    if (filePath != null)
      if (!Directory.Exists(filePath))
        Directory.CreateDirectory(filePath);
    return true;
  }
  #endregion

  #region Converter class generation

  private bool GenerateConverterClass(TypeInfo type)
  {
    var typeName = type.Name;
    if (typeName == "Rsids")
      TestTools.Stop();
    var aNamespace = type.Namespace;
    aNamespace = aNamespace.Replace("DocumentModel.", "");
    var implOutputPath = Path.Combine(OutputPath, aNamespace);
    return GenerateConverterClass(type, typeName, Path.Combine(implOutputPath, typeName + "Converter" + ".cs"));
  }

  private bool GenerateConverterClass(TypeInfo type, string typeName, string filename)
  {
    if (!AssurePathExists(filename))
      return false;
    using (var textWriter = File.CreateText(filename))
    using (Writer = new IndentedTextWriter(textWriter, "  "))
    {
      return GenerateConverterClass(type, typeName);
    }
  }

  private bool GenerateConverterClass(TypeInfo typeInfo, string typeName)
  {
    if (typeName == "Rsids")
      TestTools.Stop();
    var aNamespace = typeInfo.Namespace;
    if (aNamespace != null)
    {
      aNamespace = aNamespace.ReplaceStart("DocumentModel", "DocumentModel.OpenXml");
      Writer.WriteLine($"namespace {aNamespace};");
      Writer.WriteLine();
    }

    GenerateDocumentationComments(typeInfo);
    GenerateCustomAttributes(typeInfo.CustomAttributes);

    typeName += "Converter";
    var str = $"public static class {typeName}";
    Writer.WriteLine(str);

    Writer.WriteLine($"{{");
    Writer.Indent++;

    var ok = GenerateAcceptedPropertiesConversion(typeInfo, aNamespace);

    if (ok)
      ok = GenerateConversionMethods(typeInfo);

    Writer.Indent--;
    Writer.WriteLine($"}}");
    GeneratedClassesCount += 1;
    return ok;
  }

  private bool GenerateConversionMethods(TypeInfo typeInfo)
  {
    var ok = GenerateCreateModelElementMethod(typeInfo);
    if (!GenerateCompareModelElementMethod(typeInfo))
      ok = false;
    if (!GenerateCreateOpenXmlElementMethod(typeInfo))
      ok = false;
    if (!GenerateUpdateOpenXmlElementMethod(typeInfo))
      ok = false;
    return ok;
  }

  private bool GenerateCreateModelElementMethod(TypeInfo typeInfo)
  {
    if (typeInfo.Name == "Rsids")
      TestTools.Stop();
    var origTypeName = typeInfo.GetFullName(true);
    var targetType = typeInfo.GetTargetType();
    var targetTypeName = targetType.GetFullName();
    Writer.WriteLine($"public static {targetType}? CreateModelElement({origTypeName}? openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"if (openXmlElement != null)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"var value = new {targetType}();");
    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
      {
        var targetPropName = prop.GetTargetName();
        Writer.WriteLine($"value.{targetPropName} = Get{targetPropName}(openXmlElement);");
      }
    Writer.WriteLine($"return value;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return null;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCompareModelElementMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetConversionTargetOrSelf().GetFullName();
    Writer.WriteLine($"");
    Writer.WriteLine(
      $"public static bool CompareModelElement({origTypeName}? openXmlElement, " +
      $"{targetTypeName}? value, DiffList? diffs, string? objName)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"if (openXmlElement != null && value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var ok = true;");
    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
      {
        var targetPropName = prop.GetTargetName();
        Writer.WriteLine($"  if (!Cmp{targetPropName}(openXmlElement, value.{targetPropName}, diffs, objName))");
        Writer.WriteLine($"    ok = false;");
      }
    Writer.WriteLine($"  return ok;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (openXmlElement == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);");
    Writer.WriteLine($"return false;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateCreateOpenXmlElementMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetConversionTargetOrSelf().GetFullName();
    Writer.WriteLine($"");
    Writer.WriteLine(
      $"public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>({targetTypeName} value)");
    Writer.WriteLine($"  where OpenXmlElementType: {origTypeName}, new()");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    Writer.WriteLine($"var openXmlElement = new OpenXmlElementType();");
    Writer.WriteLine($"UpdateOpenXmlElement(openXmlElement, value);");
    Writer.WriteLine($"return openXmlElement;");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateUpdateOpenXmlElementMethod(TypeInfo typeInfo)
  {
    var origTypeName = typeInfo.GetFullName(true);
    var targetTypeName = typeInfo.GetConversionTargetOrSelf().GetFullName();
    Writer.WriteLine($"");
    Writer.WriteLine(
      $"public static void UpdateOpenXmlElement({origTypeName} openXmlElement, {targetTypeName} value)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (typeInfo.Properties != null)
      foreach (var prop in typeInfo.Properties.Where(item => item.IsAccepted != false))
      {
        var targetPropName = prop.GetTargetName();
        if (prop.IsReadonly)
          Writer.WriteLine($"//Set{targetPropName}(openXmlElement, value?.{targetPropName});");
        else
          Writer.WriteLine($"Set{targetPropName}(openXmlElement, value?.{targetPropName});");
      }
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return true;
  }

  private bool GenerateAcceptedPropertiesConversion(TypeInfo typeInfo, string? inNamespace)
  {
    if (typeInfo.Name == "Rsids")
      TestTools.Stop();
    var ok = true;
    if (typeInfo.AcceptedProperties != null)
      foreach (var prop in typeInfo.AcceptedProperties)
        //if (kind == TypeKind.Interface || !prop.IsConstrained)
        if (!GeneratePropertyAccessors(prop, inNamespace))
          ok = false;
    return ok;
  }

  private bool GenerateItemsProperties(TypeInfo typeInfo, ItemsConstraint constraint, string fromClassName, string? inNamespace,
    List<string> subclassesTypeNames)
  {
    var ok = true;
    if (constraint is ItemTypeConstraint itemTypeConstraint)
    {
      var prop = itemTypeConstraint.AccessProperty;
      if (prop != null)
        if (!GeneratePropertyAccessors(prop, inNamespace))
          ok = false;
    }
    else if (constraint is ItemsCompoundConstraint itemsCompoundConstraint)
    {
      var constraintClassName = fromClassName + constraint.ConstraintType;
      subclassesTypeNames.Add(constraintClassName);
      if (constraint.ConstraintType == ConstraintType.Group && !constraint.IsRequired && !constraint.IsMultiple)
        foreach (var itemConstraint in itemsCompoundConstraint.Items)
          if (!GenerateItemsProperties(typeInfo, itemConstraint, constraintClassName, inNamespace, subclassesTypeNames))
            ok = false;
    }
    return ok;
  }

  private bool GeneratePropertyAccessors(PropInfo prop, string? inNamespace)
  {
    if (prop.PropertyType?.Type == null)
      return false;
    var ok = true;
    //var targetPropType = prop.GetTargetType();
    GenerateDocumentationComments(prop);
    GenerateCustomAttributes(prop.CustomAttributes);
    if (!GeneratePropertyAccessors(prop))
      ok = false;

    Writer.WriteLine();
    GeneratedPropertiesCount += 1;
    return ok;
  }

  private bool GeneratePropertyAccessors(PropInfo prop)
  {
    var ok = GeneratePropertyGetter(prop);
    if (!GeneratePropertyComparer(prop))
      ok = false;
    if (prop.IsReadonly)
      return ok;
    if (!GeneratePropertySetter(prop))
      ok = false;
    return ok;
  }

  private bool GeneratePropertyGetter(PropInfo prop)
  {
    if (prop.Name == "Items" && prop.DeclaringType?.Name == "Fonts")
      TestTools.Stop();
    var ok = false;
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var targetPropName = prop.GetTargetName();
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var qm = "?";
    if (targetPropType.Type.Name.StartsWith("Collection`")
      && prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true
      && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
      qm = "";
    else
      if (origPropType.Type.IsEqualOrSubclassOf(typeof(DXW.OnOffOnlyType)))
      qm = "";
    Writer.WriteLine($"private static {targetPropTypeName}{qm} Get{targetPropName}({origTypeName} openXmlElement)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertyGetCode(prop);
    else if (targetPropType.Type == typeof(String))
      ok = GenerateStringPropertyGetCode(prop);
    else if (targetPropType.Type == typeof(Boolean))
      ok = GenerateBooleanPropertyGetCode(prop);
    else if (targetPropType.Type == typeof(Uri))
      ok = GenerateSameTypePropertyGetCode(prop);
    else if (targetPropType.IsSimple())
      ok = GenerateSimplePropertyGetCode(prop);
    else if (targetPropType.Type.Implements(typeof(ICollection)))
      ok = GenerateCollectionGetCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertyGetCode(prop);
    else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertyGetCode(prop);
    else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
      ok = GeneratePartRootElementPropertyGetCode(prop);
    else
      ok = GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }

  private bool GeneratePropertyComparer(PropInfo prop)
  {
    if (prop.Name == "UIPriority")
      TestTools.Stop();
    var ok = false;
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    //var origPropType = prop.PropertyType;
    var targetPropName = prop.GetTargetName();
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    //var qm = "?";
    //if (targetPropType.Type.Name.StartsWith("Collection`"))
    //  qm = "";
    Writer.WriteLine($"");
    Writer.WriteLine($"private static bool Cmp{targetPropName}({origTypeName} openXmlElement, " +
                     $"{targetPropTypeName}? value, DiffList? diffs, string? objName)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertyCmpCode(prop);
    else if (targetPropType.Type == typeof(String))
      ok = GenerateStringPropertyCmpCode(prop);
    else if (targetPropType.Type == typeof(Boolean))
      ok = GenerateBooleanPropertyCmpCode(prop);
    else if (targetPropType.Type == typeof(Uri))
      ok = GenerateSameTypePropertyCmpCode(prop);
    else if (targetPropType.IsSimple())
      ok = GenerateSimplePropertyCmpCode(prop);
    else if (targetPropType.Type.Implements(typeof(ICollection)))
      ok = GenerateCollectionCmpCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertyCmpCode(prop);
    else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertyCmpCode(prop);
    else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
      ok = GeneratePartRootElementPropertyCmpCode(prop);
    else
      ok = GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }

  private bool GeneratePropertySetter(PropInfo prop)
  {
    var ok = false;
    var origPropName = prop.Name;
    var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var targetPropName = prop.GetTargetName();
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"");
    Writer.WriteLine($"private static void Set{targetPropName}({origTypeName} openXmlElement, {targetPropTypeName}? value)");
    Writer.WriteLine($"{{");
    Writer.Indent++;
    if (prop.Name.Contains("ItemId"))
      Debug.Assert(true);
    ;
    if (targetPropType.Type.IsEnum)
      ok = GenerateEnumPropertySetCode(prop);
    else if (targetPropType.Type == typeof(string))
      ok = GenerateStringPropertySetCode(prop);
    else if (targetPropType.Type == typeof(Boolean))
      ok = GenerateBooleanPropertySetCode(prop);
    else if (targetPropType.IsSimple())
      ok = GenerateSimplePropertySetCode(prop);
    else if (targetPropType.Type.Implements(typeof(ICollection)))
      ok = GenerateCollectionSetCode(prop);
    else if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlSimpleType)))
      ok = GenerateSimplePropertySetCode(prop);
    else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlCompositeElement)) == true)
      ok = GenerateContentElementPropertySetCode(prop);
    else if (prop.DeclaringType?.Type.IsEqualOrSubclassOf(typeof(OpenXmlPart)) == true && prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlPartRootElement)))
      ok = GeneratePartRootElementPropertySetCode(prop);
    else
      ok = GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
    Writer.Indent--;
    Writer.WriteLine($"}}");
    return ok;
  }

  #endregion

  #region Simple property access code generation

  #region GenerateSimpleProperty code
  private bool GenerateSimplePropertyGetCode(PropInfo prop)
  {
    //if (prop.Name == "Panose1Number")
    //  Debug.Assert(true);
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(Int16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(IntegerValue))
        || origPropType.IsEqualOrSubclassOf(typeof(ByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DateTimeValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SingleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DoubleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DecimalValue))
       )
      return GenerateSimpleValuePropertyGetCode(prop);
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryBytePropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt16PropertyGetCode(prop);
    if (targetPropType.Type == typeof(RGB) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryRGBPropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt32PropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(LongHexNumberType)))
      return GenerateValUInt32PropertyGetCode(prop);
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt64PropertyGetCode(prop);
    if (targetPropType.Type == typeof(HexInt))
      return GenerateHexIntPropertyGetCode(prop);
    if (targetPropType.Type == typeof(RGB))
      return GenerateHexRGBPropertyGetCode(prop);
    if (targetPropType.Type == typeof(HexChar))
      return GenerateHexCharPropertyGetCode(prop);
    if (targetPropType.Type == typeof(Guid))
      return GenerateGuidPropertyGetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(HexBinaryValue)))
      return GenerateHexBinaryPropertyGetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(Base64BinaryValue)))
      return GenerateBase64BinaryPropertyGetCode(prop);
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertyGetCode(prop);
    return GenerateSimpleValPropertyGetCode(prop);
  }

  private bool GenerateSimplePropertyCmpCode(PropInfo prop)
  {
    //if (prop.Name == "Panose1Number")
    //  Debug.Assert(true);
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(Int16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(IntegerValue))
        || origPropType.IsEqualOrSubclassOf(typeof(ByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DateTimeValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SingleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DoubleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DecimalValue))
       )
      return GenerateSimpleValuePropertyCmpCode(prop);
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryBytePropertyCmpCode(prop);
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt16PropertyCmpCode(prop);
    if (targetPropType.Type == typeof(RGB) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryRGBPropertyCmpCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt32PropertyCmpCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(LongHexNumberType)))
      return GenerateValUInt32PropertyCmpCode(prop);
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt64PropertyCmpCode(prop);
    if (targetPropType.Type == typeof(HexInt))
      return GenerateHexIntPropertyCmpCode(prop);
    if (targetPropType.Type == typeof(RGB))
      return GenerateHexRGBPropertyCmpCode(prop);
    if (targetPropType.Type == typeof(HexChar))
      return GenerateHexCharPropertyCmpCode(prop);
    if (targetPropType.Type == typeof(Guid))
      return GenerateGuidPropertyCmpCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(HexBinaryValue)))
      return GenerateHexBinaryPropertyCmpCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(Base64BinaryValue)))
      return GenerateBase64BinaryPropertyCmpCode(prop);
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertyCmpCode(prop);
    return GenerateSimpleValPropertyCmpCode(prop);
  }

  private bool GenerateSimplePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType.Type;
    var targetPropType = prop.GetTargetType();
    if (origPropType.IsEqualOrSubclassOf(typeof(Int16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(Int64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(IntegerValue))
        || origPropType.IsEqualOrSubclassOf(typeof(ByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SByteValue))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt16Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt32Value))
        || origPropType.IsEqualOrSubclassOf(typeof(UInt64Value))
        || origPropType.IsEqualOrSubclassOf(typeof(DateTimeValue))
        || origPropType.IsEqualOrSubclassOf(typeof(SingleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DoubleValue))
        || origPropType.IsEqualOrSubclassOf(typeof(DecimalValue))
       )
      return GenerateSimpleValuePropertySetCode(prop);
    if (targetPropType.Type == typeof(Byte) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryBytePropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt16) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt16PropertySetCode(prop);
    if (targetPropType.Type == typeof(RGB) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryRGBPropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt32PropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt32) && origPropType.IsEqualOrSubclassOf(typeof(LongHexNumberType)))
      return GenerateValUInt32PropertySetCode(prop);
    if (targetPropType.Type == typeof(UInt64) && origPropType == typeof(HexBinaryValue))
      return GenerateHexBinaryUInt64PropertySetCode(prop);
    if (targetPropType.Type == typeof(HexInt))
      return GenerateHexIntPropertySetCode(prop);
    if (targetPropType.Type == typeof(RGB))
      return GenerateHexRGBPropertySetCode(prop);
    if (targetPropType.Type == typeof(HexChar))
      return GenerateHexCharPropertySetCode(prop);
    if (targetPropType.Type == typeof(Guid))
      return GenerateGuidPropertySetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(HexBinaryValue)))
      return GenerateHexBinaryPropertySetCode(prop);
    if (origPropType.IsEqualOrSubclassOf(typeof(Base64BinaryValue)))
      return GenerateBase64BinaryPropertySetCode(prop);
    if (origPropType.Name.StartsWith("ListValue`"))
      return GenerateListValuePropertySetCode(prop);
    return GenerateSimpleValPropertySetCode(prop);
  }
  #endregion

  #region GenerateSimpleProperty code
  private bool GenerateSimpleValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateSimpleValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateSimpleValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region GenerateSimpleValProperty code

  private bool GenerateSimpleValPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Val);");
    return true;
  }

  private bool GenerateSimpleValPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.PropertyType.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Val, value, diffs, objName, \"{origPropName}\");");
    return true;
  }

  private bool GenerateSimpleValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var propTargetType = prop.PropertyType.GetTargetType();
    Writer.WriteLine($"SimpleValueConverter.SetValue<{origPropTypeName},{propTargetType}>(openXmlElement, value);");

    //Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    //Writer.WriteLine($"if (itemElement != null)");
    //Writer.WriteLine($"{{");
    //Writer.WriteLine($"  if (value != null)");
    //Writer.WriteLine($"    itemElement.Val = value;");
    //Writer.WriteLine($"  else");
    //Writer.WriteLine($"    itemElement.Remove();");
    //Writer.WriteLine($"}}");
    //Writer.WriteLine($"else");
    //Writer.WriteLine($"if (value != null)");
    //Writer.WriteLine($"{{");
    //Writer.WriteLine($"  itemElement = new {origPropTypeName}{{ Val = value }};");
    //Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    //Writer.WriteLine($"}}");
    return true;
  }
  #endregion


  #region GenerateGuidProperty code
  private bool GenerateGuidPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement?.Val?.Value != null)");
    Writer.WriteLine($"  return Guid.Parse(itemElement.Val.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateGuidPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement?.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement?.Val?.Value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var val = Guid.Parse(itemElement.Val.Value);");
    Writer.WriteLine($"  if (val == value) return true;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (itemElement == null && itemElement?.Val?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", itemElement?.Val?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateGuidPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origPropTypeName}{{ Val = ((Guid)value).ToString(\"B\") }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #endregion

  #region HexBinary converted property access code generation

  #region GenerateHexBinaryByteProperty code
  private bool GenerateHexBinaryBytePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Byte.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryBytePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (Byte.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value?.ToString(\"x2\"));");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexBinaryBytePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ((UInt16)value).ToString(\"X2\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryUInt16Property
  private bool GenerateHexBinaryUInt16PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt16.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryUInt16PropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (UInt16.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value?.ToString(\"x4\"));");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexBinaryUInt16PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ((UInt16)value).ToString(\"X4\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryRGBProperty
  private bool GenerateHexBinaryRGBPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return (DocumentModel.RGB)UInt32.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryRGBPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (UInt32.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value?.ToString());");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexBinaryRGBPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ((UInt32)value).ToString(\"X6\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryUInt32Property code
  private bool GenerateHexBinaryUInt32PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt32.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryUInt32PropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (UInt32.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value?.ToString(\"x8\"));");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexBinaryUInt32PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ((UInt32)value).ToString(\"X8\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryUInt64Property code
  private bool GenerateHexBinaryUInt64PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return UInt64.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryUInt64PropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (UInt64.Parse(openXmlElement.{origPropName}.Value, NumberStyles.HexNumber) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value?.ToString(\"x16\"));");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexBinaryUInt64PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = ((UInt364)value).ToString(\"X16\");");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateValUInt32Property code
  private bool GenerateValUInt32PropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Val?.Value != null)");
    Writer.WriteLine($"  return UInt32.Parse(openXmlElement.{origPropName}.Val.Value, NumberStyles.HexNumber);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateValUInt32PropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Val?.Value != null)");
    Writer.WriteLine($"  if (UInt32.Parse(openXmlElement.{origPropName}.Val.Value, NumberStyles.HexNumber) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Val?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Val?.Value, value?.ToString(\"x8\"));");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateValUInt32PropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new {origPropTypeName} {{ Val = ((UInt32)value).ToString(\"X8\") }};");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #endregion

  #region GenerateHexIntProperty code
  private bool GenerateHexIntPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(DX.HexBinaryValue))
    {
      var origPropName = prop.Name;
      Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
      Writer.WriteLine($"  return HexIntConverter.GetValue(openXmlElement.{origPropName}.Value);");
      Writer.WriteLine($"return null;");
    }
    else
    {
      var origPropTypeName = prop.PropertyType.GetFullName(true);
      Writer.WriteLine($"return HexIntConverter.GetValue(openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Val);");
    }
    return true;
  }

  private bool GenerateHexIntPropertyCmpCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(DX.HexBinaryValue))
    {
      var origPropName = prop.Name;
      //Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
      //Writer.WriteLine($"  if (HexIntConverter.GetValue(openXmlElement.{origPropName}.Value) == value)");
      //Writer.WriteLine($"    return true;");
      //Writer.WriteLine($"if (openXmlElement == null && openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
      //Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
      //Writer.WriteLine($"return false;");
      Writer.WriteLine($"return HexIntConverter.CmpValue(openXmlElement?.{origPropName}?.Value, value, diffs, objName, \"{origPropName}\");");
    }
    else
    {
      var origPropName = prop.Name;
      var origPropTypeName = prop.PropertyType.GetFullName(true);
      Writer.WriteLine($"return HexIntConverter.CmpValue(openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Val, value, diffs, objName, \"{origPropName}\");");
    }
    return true;
  }

  private bool GenerateHexIntPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(DX.HexBinaryValue))
    {
      var origPropName = prop.Name;
      Writer.WriteLine($"if (value != null)");
      Writer.WriteLine($"  openXmlElement.{origPropName} = value.ToString();");
      Writer.WriteLine($"else");
      Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    }
    else
    {
      var origPropTypeName = prop.PropertyType.GetFullName(true);
      Writer.WriteLine($"HexIntConverter.SetValue<{origPropTypeName}>(openXmlElement, value);");
    }
    return true;
  }
  #endregion

  #region GenerateHexCharProperty code
  private bool GenerateHexCharPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return HexCharConverter.GetValue(openXmlElement.{origPropName}.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexCharPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (HexCharConverter.GetValue(openXmlElement.{origPropName}.Value) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement == null && openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexCharPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value.ToString();");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexRGBProperty code
  private bool GenerateHexRGBPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return HexRGBConverter.GetValue(openXmlElement.{origPropName}.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexRGBPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  if (HexRGBConverter.GetValue(openXmlElement.{origPropName}.Value) == value)");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement == null && openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateHexRGBPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value.ToString();");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateHexBinaryProperty code
  private bool GenerateHexBinaryPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Convert.FromHexString(openXmlElement.{origPropName}.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateHexBinaryPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null && value != null)");
    Writer.WriteLine($"  if (Convert.FromHexString(openXmlElement.{origPropName}.Value).SequenceEqual((byte[])value))");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement == null && openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }
  private bool GenerateHexBinaryPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = Convert.ToHexString(value);");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateBase64BinaryProperty code
  private bool GenerateBase64BinaryPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null)");
    Writer.WriteLine($"  return Convert.FromBase64String(openXmlElement.{origPropName}.Value);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateBase64BinaryPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value != null && value != null)");
    Writer.WriteLine($"  if (Convert.FromBase64String(openXmlElement.{origPropName}.Value).SequenceEqual((byte[])value))");
    Writer.WriteLine($"    return true;");
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateBase64BinaryPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = Convert.ToBase64String(value);");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region ListValue property access code generation
  private bool GenerateListValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericTypeArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(true);
      var isEnum = origPropItemType.IsEnumValue(out var enumType);
      if (isEnum && enumType != null)
        Writer.WriteLine($"return ListValueConverter.GetValue<{enumType.GetFullName(true)}, " +
                         $"{enumType.GetFullName()}>(openXmlElement?.{origPropName});");
      else
        Writer.WriteLine($"return ListValueConverter.GetValue(openXmlElement?.{origPropName});");
      return true;
    }
    throw new InvalidOperationException("ListValue has no generic argument in GenerateListValuePropertyGetCode method");
  }

  private bool GenerateListValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericTypeArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(true);
      var isEnum = origPropItemType.IsEnumValue(out var enumType);
      if (isEnum && enumType != null)
        Writer.WriteLine($"return ListValueConverter.CmpValue<{enumType.GetFullName(true)}, " +
                         $"{enumType.GetFullName()}>(openXmlElement?.{origPropName}, value, diffs, objName);");
      else
        Writer.WriteLine($"return ListValueConverter.CmpValue(openXmlElement?.{origPropName}, value, diffs, objName);");
      return true;
    }

    throw new InvalidOperationException("ListValue has no generic argument in GenerateListValuePropertyGetCode method");
  }

  private bool GenerateListValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropItemType = prop.PropertyType.GetGenericTypeArguments().FirstOrDefault();
    if (origPropItemType != null)
    {
      var origPropItemTypeName = origPropItemType.GetFullName(true);
      var isEnum = origPropItemType.IsEnumValue(out var enumType);
      Writer.WriteLine($"if (value != null)");
      if (isEnum && enumType != null)
        Writer.WriteLine($"  openXmlElement.{origPropName} = ListValueConverter.CreateListValue<{enumType.GetFullName(true)}, " +
                         $"{enumType.GetFullName()}>(value);");
      else
        Writer.WriteLine($"  openXmlElement.{origPropName} = ListValueConverter.CreateListValue<{origPropItemTypeName}>(value);");
      Writer.WriteLine($"else");
      Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
      return true;
    }
    throw new InvalidOperationException("ListValue has no generic argument in GenerateListValuePropertySetCode method");
  }

  #endregion

  #region Enum property access code generation

  #region GenerateEnumProperty code
  private bool GenerateEnumPropertyGetCode(PropInfo prop)
  {
    //if (prop.Name == "ProcessMode")
    //  Debug.Assert(true);
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertyGetCode(prop);
    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertyGetCode(prop);
    if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertyGetCode(prop);
    if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertyGetCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateEnumPropertyCmpCode(PropInfo prop)
  {
    //if (prop.Name == "ProcessMode")
    //  Debug.Assert(true);
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertyCmpCode(prop);
    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertyCmpCode(prop);
    if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertyCmpCode(prop);
    if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertyCmpCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateEnumPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type.IsEnum)
      return GenerateSimpleEnumTypePropertySetCode(prop);
    if (prop.PropertyType.Name.StartsWith("EnumValues`"))
      return GenerateEnumTypePropertySetCode(prop);
    if (prop.PropertyType.Name.StartsWith("EnumValue`"))
      return GenerateEnumTypePropertySetCode(prop);
    if (prop.PropertyType.Name.StartsWith("OpenXmlSimpleValue`"))
      return GenerateEnumTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateContentEnumValPropertySetCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }
  #endregion

  #region GenerateSimpleEnumTypeProperty code
  private bool GenerateSimpleEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    Writer.WriteLine($"if (openXmlElement?.{origPropName} != null)");
    Writer.WriteLine($"  return EnumValueConverter.GetValue<{origPropTypeName}, {targetPropTypeName}>(openXmlElement?.{origPropName});");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateSimpleEnumTypePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    Writer.WriteLine($"if (openXmlElement?.{origPropName} != null)");
    Writer.WriteLine($"  return EnumValueConverter.CmpValue<{origPropTypeName}, " +
                     $"{targetPropTypeName}>(openXmlElement?.{origPropName}, value, diffs, objName?.Concat2(\".\",openXmlElement?.GetType().Name));");
    Writer.WriteLine($"if (openXmlElement?.{origPropName} == null && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{prop.Name}\", openXmlElement?.{origPropName}, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateSimpleEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = EnumValueConverter.GetValue<{targetPropTypeName}, {origPropTypeName}>(value);");
    return true;
  }
  #endregion

  #region GenerateEnumTypeProperty code
  private bool GenerateEnumTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName();
      Writer.WriteLine(
        $"return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(openXmlElement?.{origPropName}?.Value);");
      return true;
    }
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateEnumTypePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName();
      Writer.WriteLine(
        $"return EnumValueConverter.CmpValue<{origPropValueTypeName}, " +
        $"{targetPropTypeName}>(openXmlElement?.{origPropName}?.Value, value, diffs, objName?.Concat2(\".\",openXmlElement?.GetType().Name));");
      return true;
    }
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateEnumTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName();
      Writer.WriteLine($"openXmlElement.{origPropName} = EnumValueConverter.CreateEnumValue<{origPropValueTypeName}, {targetPropTypeName}>(value);");
      return true;
    }
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }
  #endregion

  #endregion

  #region String property access code generation

  #region GenerateStringProperty code
  private bool GenerateStringPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(string))
      return GenerateSimpleStringPropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringValue)))
      return GenerateStringValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringType)))
      return GenerateStringTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(Text)))
      return GenerateTextPropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
      return GenerateStringLeafTextTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateStringOpenXmlLeafElementPropertyGetCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateStringPropertyCmpCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(string))
      return GenerateSimpleStringPropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringValue)))
      return GenerateStringValuePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringType)))
      return GenerateStringTypePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(Text)))
      return GenerateTextPropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
      return GenerateStringLeafTextTypePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateStringOpenXmlLeafElementPropertyCmpCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateStringPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(string))
      return GenerateSimpleStringPropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringValue)))
      return GenerateStringValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(StringType)))
      return GenerateStringTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(Text)))
      return GenerateTextPropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafTextElement)))
      return GenerateStringLeafTextTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OpenXmlLeafElement)))
      return GenerateStringOpenXmlLeafElementPropertySetCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }
  #endregion

  #region GenerateSimpleStringProperty code
  private bool GenerateSimpleStringPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName};");
    return true;
  }

  private bool GenerateSimpleStringPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName} == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateSimpleStringPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #region GenerateStringValueProperty code
  private bool GenerateStringValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return StringValueConverter.GetValue(openXmlElement?.{origPropName});");
    return true;
  }

  private bool GenerateStringValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return StringValueConverter.CmpValue(openXmlElement?.{origPropName}, value, diffs, objName, \"{origPropName}\");");
    return true;
  }

  private bool GenerateStringValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = StringValueConverter.CreateStringValue(value);");
    return true;
  }
  #endregion

  #region GenerateStringTypeProperty code
  private bool GenerateStringTypePropertyGetCode(PropInfo prop)
  {
    var origElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"return openXmlElement.GetFirstChild<{origElementTypeName}>()?.Val?.Value;");
    return true;
  }

  private bool GenerateStringTypePropertyCmpCode(PropInfo prop)
  {
    var origElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origElementTypeName}>();");
    Writer.WriteLine($"if (itemElement?.Val?.Value == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origElementTypeName.Name}\", itemElement?.Val?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateStringTypePropertySetCode(PropInfo prop)
  {
    var origElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origElementTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origElementTypeName} {{ Val = value }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateTextProperty code
  private bool GenerateTextPropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Text;");
    return true;
  }

  private bool GenerateTextPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Text == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Text, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateTextPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new {origPropTypeName}(value);");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateStringLeafTextTypeProperty code
  private bool GenerateStringLeafTextTypePropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  return openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Text;");
    return true;
  }

  private bool GenerateStringLeafTextTypePropertyCmpCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  return openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Text == value;");
    return true;
  }

  private bool GenerateStringLeafTextTypePropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = new {origPropTypeName} {{ Text = value }};");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateStringOpenXmlLeafElementProperty code
  private bool GenerateStringOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"return StringValueConverter.GetValue(openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Val);");
    return true;
  }

  private bool GenerateStringOpenXmlLeafElementPropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.PropertyType.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"return StringValueConverter.CmpValue(openXmlElement?.GetFirstChild<{origPropTypeName}>()?.Val, value, diffs, objName, \"{origPropName}\");");
    return true;
  }

  private bool GenerateStringOpenXmlLeafElementPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"StringValueConverter.SetValue<{origPropTypeName}>(openXmlElement, value);");
    return true;
  }
  #endregion

  #endregion

  #region Boolean property access code generation

  #region GenerateBooleanProperty code
  private bool GenerateBooleanPropertyGetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(Boolean))
      return GenerateSameTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(BooleanValue)))
      return GenerateBooleanValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffValue)))
      return GenerateBooleanOnOffValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyValues)))
      return GenerateBooleanOnOffOnlyValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseValue)))
      return GenerateBooleanTrueFalseValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseBlankValue)))
      return GenerateBooleanTrueFalseBlankValuePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffType)))
      return GenerateBooleanOnOffTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyType)))
      return GenerateBooleanOnOffOnlyTypePropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(EmptyType)))
      return GenerateBooleanEmptyTypeElementPropertyGetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanPropertyCmpCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(Boolean))
      return GenerateSameTypePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(BooleanValue)))
      return GenerateBooleanValuePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffValue)))
      return GenerateBooleanOnOffValuePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyValues)))
      return GenerateBooleanOnOffOnlyValuePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseValue)))
      return GenerateBooleanTrueFalseValuePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseBlankValue)))
      return GenerateBooleanTrueFalseBlankValuePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffType)))
      return GenerateBooleanOnOffTypePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyType)))
      return GenerateBooleanOnOffOnlyTypePropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(EmptyType)))
      return GenerateBooleanEmptyTypeElementPropertyCmpCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertyCmpCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }

  private bool GenerateBooleanPropertySetCode(PropInfo prop)
  {
    if (prop.PropertyType.Type == typeof(Boolean))
      return GenerateSameTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(BooleanValue)))
      return GenerateBooleanValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffValue)))
      return GenerateBooleanOnOffValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyValues)))
      return GenerateBooleanOnOffOnlyValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseValue)))
      return GenerateBooleanTrueFalseValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TrueFalseBlankValue)))
      return GenerateBooleanTrueFalseBlankValuePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffType)))
      return GenerateBooleanOnOffTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(OnOffOnlyType)))
      return GenerateBooleanOnOffOnlyTypePropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(EmptyType)))
      return GenerateBooleanEmptyTypeElementPropertySetCode(prop);
    if (prop.PropertyType.Type.IsEqualOrSubclassOf(typeof(TypedOpenXmlLeafElement)))
      return GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(prop);
    return GenerateNotImplementedException($"propertyType is {prop.PropertyType.Type}");
  }
  #endregion

  #region GenerateBooleanValueProperty code
  private bool GenerateBooleanValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateBooleanValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateBooleanValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = new BooleanValue {{ Value = (Boolean)value }};");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffValue code
  private bool GenerateBooleanOnOffValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return BooleanValueConverter.GetValue(openXmlElement?.{origPropName});");
    return true;
  }

  private bool GenerateBooleanOnOffValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return BooleanValueConverter.CmpValue(openXmlElement?.{origPropName}, value, diffs, objName, \"{origPropName}\");");
    return true;
  }

  private bool GenerateBooleanOnOffValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = BooleanValueConverter.CreateOnOffValue(value);");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffOnlyValue code
  private bool GenerateBooleanOnOffOnlyValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return BooleanValueConverter.GetValue(openXmlElement?.{origPropName});");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return BooleanValueConverter.CmpValue(openXmlElement?.{origPropName}, value, diffs, objName);");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = BooleanValueConverter.CreateOnOffOnlyValue(value);");
    return true;
  }
  #endregion

  #region GenerateBooleanTrueFalseValueProperty code
  private bool GenerateBooleanTrueFalseValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateBooleanTrueFalseValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateBooleanTrueFalseValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateBooleanTrueFalseBlankValueProperty code
  private bool GenerateBooleanTrueFalseBlankValuePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName}?.Value;");
    return true;
  }

  private bool GenerateBooleanTrueFalseBlankValuePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName}?.Value == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}?.Value, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateBooleanTrueFalseBlankValuePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"  openXmlElement.{origPropName} = value;");
    Writer.WriteLine($"else");
    Writer.WriteLine($"  openXmlElement.{origPropName} = null;");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffTypeProperty code
  private bool GenerateBooleanOnOffTypePropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<{origPropTypeName}>());");
    return true;
  }

  private bool GenerateBooleanOnOffTypePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.PropertyType.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<{origPropTypeName}>(), value, " +
      $"diffs, objName);");
    return true;
  }

  private bool GenerateBooleanOnOffTypePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"BooleanValueConverter.SetOnOffType<{origPropTypeName}>(openXmlElement, value);");
    return true;
  }
  #endregion

  #region GenerateBooleanOnOffOnlyTypeProperty code
  private bool GenerateBooleanOnOffOnlyTypePropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<{origPropTypeName}>());");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyTypePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.PropertyType.Name;
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<{origPropTypeName}>(), value, " +
      $"diffs, objName);");
    return true;
  }

  private bool GenerateBooleanOnOffOnlyTypePropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"BooleanValueConverter.SetOnOffOnlyType<{origPropTypeName}>(openXmlElement, value);");
    return true;
  }
  #endregion

  #region GenerateBooleanEmptyTypeElementProperty code
  private bool GenerateBooleanEmptyTypeElementPropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"var element = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"return (element != null) ? true : null;");
    return true;
  }

  private bool GenerateBooleanEmptyTypeElementPropertyCmpCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"var element = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"bool? val = (element != null) ? true : null;");
    Writer.WriteLine($"if (val == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropTypeName}\", val, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateBooleanEmptyTypeElementPropertySetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"if (value == false)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (value == true)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateBooleanTypedOpenXmlLeafElementProperty code
  private bool GenerateBooleanTypedOpenXmlLeafElementPropertyGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"return openXmlElement.GetFirstChild<{origPropTypeName}>() != null;");
    return true;
  }

  private bool GenerateBooleanTypedOpenXmlLeafElementPropertyCmpCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    Writer.WriteLine($"var val = openXmlElement.GetFirstChild<{origPropTypeName}>() != null;");
    Writer.WriteLine($"if (val == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropTypeName}\", val, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateBooleanTypedOpenXmlLeafElementPropertySetCode(PropInfo prop)
  {
    //var origPropName = prop.Name;
    //var origTypeName = prop.DeclaringType?.GetFullName(true) ?? "";
    var origPropType = prop.PropertyType;
    var origPropTypeName = origPropType.GetFullName(true);
    //var targetPropType = prop.PropertyType.GetConversionTarget();
    //var targetPropTypeName = targetPropType.GetFullName(false);
    Writer.WriteLine($"if (value == false)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    itemElement.Remove();");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (value == true)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var itemElement = new {origPropTypeName}();");
    Writer.WriteLine($"  openXmlElement.AddChild(itemElement);");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #endregion

  #region Unconverted property access code generation

  #region GenerateSameTypeProperty code
  private bool GenerateSameTypePropertyGetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"return openXmlElement?.{origPropName};");
    return true;
  }

  private bool GenerateSameTypePropertyCmpCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"if (openXmlElement?.{origPropName} == value) return true;");
    Writer.WriteLine($"diffs?.Add(objName, \"{origPropName}\", openXmlElement?.{origPropName}, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateSameTypePropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    Writer.WriteLine($"openXmlElement.{origPropName} = value;");
    return true;
  }
  #endregion

  #endregion

  #region Content element property access code generation

  #region GenerateContentElementProperty code
  private bool GenerateContentElementPropertyGetCode(PropInfo prop)
  {
    var targetPropTypeName = prop.GetTargetType().GetFullName();
    var origPropElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"var element = openXmlElement?.GetFirstChild<{origPropElementTypeName}>();");
    Writer.WriteLine($"if (element != null)");
    Writer.WriteLine($"  return {ConverterGetMethodName(prop)}(element);");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateContentElementPropertyCmpCode(PropInfo prop)
  {
    var targetPropTypeName = prop.GetTargetType().GetFullName();
    var origPropElementTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"return {ConverterCompareMethodName(prop)}(openXmlElement.GetFirstChild<{origPropElementTypeName}>(), " +
                     $"value, diffs, objName?.Concat2(\".\",openXmlElement?.GetType().Name));");
    return true;
  }

  private bool GenerateContentElementPropertySetCode(PropInfo prop)
  {
    var origPropElementTypeName = prop.PropertyType.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    var targetPropTypeName = targetPropType.GetFullName();
    //if (targetPropTypeName.Name == "AdjustPoint2DType")
    //  Debug.Assert(true);
    //var generic = targetPropType.GetIncomingRelationships(Semantics.Inheritance).Count() > 0;
    Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropElementTypeName}>();");
    Writer.WriteLine($"if (itemElement != null)");
    Writer.WriteLine($"  itemElement.Remove();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  itemElement = {ConverterCreateMethodName(prop)}(value);");
    Writer.WriteLine($"  if (itemElement != null)");
    Writer.WriteLine($"    openXmlElement.AddChild(itemElement);"); // nocast
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateContentEnumValProperty code
  private bool GenerateContentEnumValPropertyGetCode(PropInfo prop)
  {
    //if (prop.Name.StartsWith("Grouping"))
    //  Debug.Assert(true);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName();
      Writer.WriteLine($"return EnumValueConverter.GetValue<{origPropValueTypeName}, {targetPropTypeName}>(openXmlElement.GetFirstChild<{origPropTypeName}>()?.Val?.Value);");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertyGetCode");
  }

  private bool GenerateContentEnumValPropertyCmpCode(PropInfo prop)
  {
    //if (prop.Name.StartsWith("Grouping"))
    //  Debug.Assert(true);
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName();
      Writer.WriteLine($"return EnumValueConverter.CmpValue<{origPropValueTypeName}, {targetPropTypeName}>(openXmlElement.GetFirstChild<{origPropTypeName}>()?.Val?.Value, " +
                       $"value, diffs, objName?.Concat2(\".\",openXmlElement?.GetType().Name));");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertyGetCode");
  }

  private bool GenerateContentEnumValPropertySetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType.Type;
    var origPropValueType = GetOpenXmlLeafEnumValueType(origPropType);
    var targetPropType = prop.GetTargetType();
    if (origPropValueType != null && targetPropType != null)
    {
      var origPropValueTypeName = origPropValueType.FullName;
      var targetPropTypeName = targetPropType.GetFullName();
      Writer.WriteLine($"var itemElement = openXmlElement.GetFirstChild<{origPropTypeName}>();");
      Writer.WriteLine($"if (itemElement != null)");
      Writer.WriteLine($"{{");
      Writer.WriteLine($"  if (value != null)");
      Writer.WriteLine($"    EnumValueConverter" +
        $".UpdateOpenXmlElement<{origPropValueTypeName}, {targetPropTypeName}>(itemElement, ({targetPropTypeName})value);");
      Writer.WriteLine($"  else");
      Writer.WriteLine($"    itemElement.Remove();");
      Writer.WriteLine($"}}");
      Writer.WriteLine($"else");
      Writer.WriteLine($"if (value != null)");
      Writer.WriteLine($"  openXmlElement.AddChild(EnumValueConverter" +
        $".CreateOpenXmlElement<{origPropTypeName}, {origPropValueTypeName}, {targetPropTypeName}>(({targetPropTypeName})value));");
      return true;
    }
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateContentEnumValPropertySetCode");
  }
  #endregion

  #endregion

  #region Collection property access code generation

  #region GenerateCollection code
  private bool GenerateCollectionGetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    if (origPropType.Name == "PartExtensionProvider")
      Debug.Assert(true);
    var args = origPropType.GetGenericTypeArguments();
    if (args.Length == 1)
    {
      var origItemType = args[0];
      var origItemTypeName = origItemType.GetFullName(true);
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsGetCode(prop);
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsGetCode(prop);
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipGetCode(prop);
      return GenerateCollectionOfElementsGetCode(prop);
    }
    else if (args.Length == 2)
      return false;
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateCollectionGetCode");
  }

  private bool GenerateCollectionCmpCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var args = origPropType.GetGenericTypeArguments();
    if (args.Length == 1)
    {
      var origItemType = args[0];
      var origItemTypeName = origItemType.GetFullName(true);
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsCmpCode(prop);
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsCmpCode(prop);
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipCmpCode(prop);
      return GenerateCollectionOfElementsCmpCode(prop);
    }
    else if (args.Length == 2)
      return false;
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateCollectionCmpCode");
  }

  private bool GenerateCollectionSetCode(PropInfo prop)
  {
    var origPropType = prop.PropertyType;
    var args = origPropType.GetGenericTypeArguments();
    if (args.Length == 1)
    {
      var origItemType = args[0];
      var origItemTypeName = origItemType.GetFullName(true);
      if (origItemTypeName.Name.EndsWith("Part"))
        return GenerateCollectionOfPartsSetCode(prop);
      if (origItemTypeName.Name.EndsWith("IdPartPair"))
        return GenerateCollectionOfPartsSetCode(prop);
      if (origItemTypeName.Name.EndsWith("Relationship"))
        return GenerateCollectionOfRelationshipSetCode(prop);
      return GenerateCollectionOfElementsSetCode(prop);
    }
    else if (args.Length == 2)
      return false;
    throw new InvalidOperationException($"Not supported propertyType {prop.PropertyType.Type} in GenerateCollectionSetCode");
  }

  #endregion

  #region GenerateCollectionOfElements code
  private bool GenerateCollectionOfElementsGetCode(PropInfo prop)
  {
    if (prop.Name == "Items")
      TestTools.Stop();
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    origItemType = origItemType?.GetOriginType();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetPropType = prop.GetTargetType();
    if (targetPropType.IsConstructedGenericType)
    {
      var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
      var targetItemTypeName = targetItemType?.GetFullName();
      Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    }
    else
    {
      var targetTypeName = targetPropType.GetFullName();
      Writer.WriteLine($"var collection = new {targetTypeName}();");
    }
    Writer.WriteLine($"foreach (var item in openXmlElement.Elements<{origItemTypeName}>())");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem != null)");
    Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (collection.Count>0)");
    Writer.WriteLine($"  return collection;");
    Writer.WriteLine($"return null;");
    return true;
  }

  private bool GenerateCollectionOfElementsCmpCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().First();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    if (targetItemType == null)
      if (targetPropType.IsCollection(out var targetItemType1))
        targetItemType = targetItemType1;
    Debug.Assert(targetItemType != null);
    var origItemTypeName = origItemType.GetFullName(true);
    var targetItemTypeName = targetItemType.GetFullName();
    Writer.WriteLine($"var origElements = openXmlElement.Elements<{origItemTypeName}>();");
    Writer.WriteLine($"var origElementsCount = origElements.Count();");
    Writer.WriteLine($"var modelElementsCount = value?.Count() ?? 0;");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  if (origElementsCount != modelElementsCount)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    diffs?.Add(objName, openXmlElement.GetType().Name+\".Count\", origElementsCount, modelElementsCount);");
    Writer.WriteLine($"    return false;");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  var ok = true;");
    Writer.WriteLine($"  var modelEnumerator = value.GetEnumerator();");
    Writer.WriteLine($"  foreach (var origItem in origElements)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    modelEnumerator.MoveNext();");
    Writer.WriteLine($"    var modelItem = modelEnumerator.Current;");
    Writer.WriteLine($"    if (!{ConverterCompareMethodName(targetItemType, origItemType)}(origItem, modelItem, diffs, objName))");
    Writer.WriteLine($"      ok = false;");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"  return ok;");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"if (origElementsCount == 0 && value == null) return true;");
    Writer.WriteLine($"diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);");
    Writer.WriteLine($"return false;");
    return true;
  }

  private bool GenerateCollectionOfElementsSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    //var targetItemTypeName = targetItemType?.GetFullName();
    //var origPropTypeName = prop.PropertyType.GetFullName(true);
    //var origPropType = prop.PropertyType;
    //var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    //origItemType = origItemType?.GetOriginType();
    //var origItemTypeName = origItemType?.GetFullName(true);
    //var targetPropType = prop.GetTargetType();
    //if (targetPropType.IsConstructedGenericType)
    //{
    //  var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    //  var targetItemTypeName = targetItemType?.GetFullName();
    //  Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    //}
    //else
    //{
    //  var targetTypeName = targetPropType.GetFullName();
    //  Writer.WriteLine($"var collection = new {targetTypeName}();");
    //}
    Writer.WriteLine($"openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateCollectionOfParts code
  private bool GenerateCollectionOfPartsGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetItemTypeName = targetItemType?.GetFullName();
    Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    if (origItemTypeName?.Name == "IdPartPair")
      Writer.WriteLine($"foreach (var item in openXmlElement.Parts)");
    else if (origItemTypeName?.Name == "DataPart")
      Writer.WriteLine($"foreach (var item in openXmlElement.DataParts)");
    else if (origItemTypeName != null)
      Writer.WriteLine($"foreach (var item in openXmlElement.GetPartsOfType<{origItemTypeName}>())");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem != null)");
    Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfPartsCmpCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetItemTypeName = targetItemType?.GetFullName();
    //Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    //if (origItemTypeName?.Name == "IdPartPair")
    //  Writer.WriteLine($"foreach (var item in openXmlElement.Parts)");
    //else if (origItemTypeName?.Name == "DataPart")
    //  Writer.WriteLine($"foreach (var item in openXmlElement.DataParts)");
    //else if (origItemTypeName != null)
    //  Writer.WriteLine($"foreach (var item in openXmlElement.GetPartsOfType<{origItemTypeName}>())");
    //Writer.WriteLine($"{{");
    //Writer.WriteLine($"  var newItem = {ConverterCompareMethodName(prop)}(item);");
    //Writer.WriteLine($"  if (newItem != null)");
    //Writer.WriteLine($"    collection.Add({ConverterTypeCast(prop)}newItem);");
    //Writer.WriteLine($"}}");
    //Writer.WriteLine($"return collection;");
    Writer.WriteLine($"return true;");
    return true;
  }
  private bool GenerateCollectionOfPartsSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetItemTypeName = targetItemType?.GetFullName();
    Writer.WriteLine($"openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      openXmlElement.AddChild({ConverterTypeCast(prop)}newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region GenerateCollectionOfRelationship code
  private bool GenerateCollectionOfRelationshipGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetItemTypeName = targetItemType?.GetFullName();
    Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    Writer.WriteLine($"foreach (var item in openXmlElement.{origItemTypeName?.Name}s)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  var newItem = {ConverterGetMethodName(prop)}(item);");
    Writer.WriteLine($"  if (newItem != null)");
    Writer.WriteLine($"    collection.Add(newItem);");
    Writer.WriteLine($"}}");
    Writer.WriteLine($"return collection;");
    return true;
  }

  private bool GenerateCollectionOfRelationshipCmpCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetItemTypeName = targetItemType?.GetFullName();
    //Writer.WriteLine($"var collection = new Collection<{targetItemTypeName}>();");
    //Writer.WriteLine($"foreach (var item in openXmlElement.{origItemTypeName?.Name}s)");
    //Writer.WriteLine($"{{");
    //Writer.WriteLine($"  var newItem = {ConverterCompareMethodName(prop)}(item);");
    //Writer.WriteLine($"  if (newItem != null)");
    //Writer.WriteLine($"    collection.Add(newItem);");
    //Writer.WriteLine($"}}");
    //Writer.WriteLine($"return collection;");
    Writer.WriteLine($"return true;");
    return true;
  }

  private bool GenerateCollectionOfRelationshipSetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    var origPropType = prop.PropertyType;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    var targetPropType = prop.GetTargetType();
    var targetItemType = targetPropType.GetGenericTypeArguments().FirstOrDefault();
    var origItemTypeName = origItemType?.GetFullName(true);
    var targetItemTypeName = targetItemType?.GetFullName();
    Writer.WriteLine($"openXmlElement.RemoveAllChildren<{origItemTypeName}>();");
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"  foreach (var item in value)");
    Writer.WriteLine($"  {{");
    Writer.WriteLine($"    var newItem = {ConverterCreateMethodName(prop)}(item);");
    Writer.WriteLine($"    if (newItem != null)");
    Writer.WriteLine($"      openXmlElement.AddChild(newItem);");
    Writer.WriteLine($"  }}");
    Writer.WriteLine($"}}");
    return true;
  }
  #endregion

  #region Generate Part properties access code

  private bool GeneratePartRootElementPropertyGetCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  return {ConverterGetMethodName(prop)}(openXmlElement?.RootElement as {origPropTypeName});");
    return true;
  }

  private bool GeneratePartRootElementPropertyCmpCode(PropInfo prop)
  {
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"  return true;");
    return true;
  }

  private bool GeneratePartRootElementPropertySetCode(PropInfo prop)
  {
    var origPropName = prop.Name;
    var origPropTypeName = prop.PropertyType.GetFullName(true);
    Writer.WriteLine($"if (value != null)");
    Writer.WriteLine($"{{");
    Writer.WriteLine($"   var rootElement = {ConverterCreateMethodName(prop)}(value);");
    Writer.WriteLine($"   if (rootElement != null)");
    Writer.WriteLine($"     openXmlElement.{origPropName} = rootElement;");
    Writer.WriteLine($"}}");
    return true;
  }

  #endregion

  #endregion

  #region Converter method names

  private string ConverterGetMethodName(PropInfo prop)
  {
    if (prop.Name == "Items" && prop.DeclaringType?.Name == "Rsids")
      TestTools.Stop();
    var targetPropType = prop.PropertyType.GetTargetType();
    var origPropType = prop.PropertyType;
    return ConverterGetMethodName(targetPropType, origPropType);
  }

  private string ConverterGetMethodName(TypeInfo targetPropType, TypeInfo origPropType)
  {
    var targetPropTypeName = targetPropType.GetFullName();
    var origPropTypeName = origPropType.GetFullName(true);
    if (targetPropType.IsSimple())
      return SimpleTypeConverterGetMethodName(targetPropTypeName, origPropTypeName);
    FullTypeName convPropName;
    if (targetPropType.IsCollection(out var targetItemType))
    {
      var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
      if (origItemType != null && targetItemType.IsSimple())
        return SimpleTypeConverterGetMethodName(targetItemType.GetFullName(), origItemType.GetFullName());

      convPropName = new FullTypeName(targetItemType.Name + "Converter",
        TypeInfo.NamespaceShortcut(targetItemType.Namespace.ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
    }
    else if (targetPropTypeName.Name == "Byte[]" || targetPropTypeName.Name == "HexBinary")
    {
      convPropName = new FullTypeName("HexBinaryConverter", "DMX");
      return $"{convPropName}.GetValue";
    }
    else
    {
      convPropName = new FullTypeName(targetPropTypeName.Name + "Converter",
        TypeInfo.NamespaceShortcut((targetPropType?.Namespace ?? "").ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
    }
    return $"{convPropName}.CreateModelElement";
  }

  private string SimpleTypeConverterGetMethodName(FullTypeName targetPropTypeName, FullTypeName origPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return "StringValueConverter.GetValue";
    if (targetPropTypeName.Name == "UInt32")
      return "UInt32ValueConverter.GetValue";
    if (targetPropTypeName.Name == "HexInt")
      return "HexIntConverter.GetValue";
    if (targetPropTypeName.Name == "NumId")
      return "NumIdConverter.GetValue";
    if (targetPropTypeName.Name == "HexBinary")
      return "HexBinaryConverter.GetValue";
    if (targetPropTypeName.Name == "Base64Binary")
      return "Base64BinaryConverter.GetValue";
    if (targetPropTypeName.Name == "Byte[]")
    {
      if (origPropTypeName.Name == "HexBinaryValue")
        return "HexBinaryConverter.GetValue";
      if (origPropTypeName.Name == "Base64BinaryValue")
        return "Base64BinaryConverter.GetValue";
      return "ByteArrayConverter.GetValue";
    }
    return string.Empty;
  }

  private string ConverterCompareMethodName(PropInfo prop)
  {
    var str = ConverterGetMethodName(prop);
    if (str.EndsWith("GetValue"))
      str = str.ReplaceEnd("GetValue", "CmpValue");
    else
      str = str.ReplaceEnd("CreateModelElement", "CompareModelElement");
    return str;
  }

  private string ConverterCompareMethodName(TypeInfo targetPropType, TypeInfo origPropType)
  {
    var str = ConverterGetMethodName(targetPropType, origPropType);
    if (str.EndsWith("GetValue"))
      str = str.ReplaceEnd("GetValue", "CmpValue");
    else
      str = str.ReplaceEnd("CreateModelElement", "CompareModelElement");
    return str;
  }

  private string ConverterCreateMethodName(PropInfo prop)
  {
    var targetPropType = prop.GetTargetType();
    var origPropType = prop.PropertyType;
    var targetPropTypeName = targetPropType.GetFullName();
    var origPropTypeName = origPropType.GetFullName(true);
    var generic = true;
    if (targetPropType.IsSimple())
      return SimpleTypeConverterCreateMethodName(targetPropTypeName, origPropTypeName);
    FullTypeName convPropName;
    var origItemType = origPropType.GetGenericTypeArguments().FirstOrDefault();
    if (origItemType != null && targetPropType.IsCollection(out var targetItemType))
    {
      if (targetItemType.IsSimple())
        return SimpleTypeConverterCreateMethodName(targetItemType.GetFullName(), origItemType.GetFullName(true));

      convPropName = new FullTypeName(targetItemType.Name + "Converter",
        TypeInfo.NamespaceShortcut((targetItemType?.Namespace ?? "").ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
      origPropTypeName = origItemType.GetFullName(true);
    }
    else if (targetPropTypeName.Name == "Byte[]")
    {
      convPropName = new FullTypeName("HexBinaryConverter", "DMX");
    }
    else
    {
      convPropName = new FullTypeName(targetPropTypeName.Name + "Converter",
        TypeInfo.NamespaceShortcut((targetPropType.Namespace ?? "").ReplaceStart("DocumentModel", "DocumentModel.OpenXml")));
    }
    var convCreateMethodName = $"{convPropName}.CreateOpenXmlElement";
    if (generic)
      convCreateMethodName += $"<{origPropTypeName}>";
    return convCreateMethodName;
  }

  private string SimpleTypeConverterCreateMethodName(FullTypeName targetPropTypeName, FullTypeName origPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return $"StringValueConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "UInt32")
      return $"UInt32ValueConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "HexInt")
      return $"HexIntConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "NumId")
      return $"NumIdConverter.CreateOpenXmlElement<{origPropTypeName}>";
    if (targetPropTypeName.Name == "Byte[]")
    {
      if (origPropTypeName.Name == "HexBinaryValue")
        return $"HexBinaryConverter.CreateOpenXmlElement<{origPropTypeName}>";
      if (origPropTypeName.Name == "Base64Binary")
        return $"Base64BinaryConverter.CreateOpenXmlElement<{origPropTypeName}>";
      return $"ByteArrayConverter.CreateOpenXmlElement<{origPropTypeName}>";
    }
    return string.Empty;
  }

  private string? ConverterTypeCast(PropInfo prop)
  {
    var targetPropType = prop.GetTargetType();
    var origPropType = prop.PropertyType;
    return ConverterTypeCast(targetPropType, origPropType);
  }

  private string? ConverterTypeCast(TypeInfo targetPropType, TypeInfo origPropType)
  {
    var targetPropTypeName = targetPropType.GetFullName();
    if (targetPropType.IsSimple())
      return SimpleTypeConverterTypeCast(targetPropTypeName);
    if (targetPropTypeName.Name == "Collection")
    {
      var origItemType = origPropType.GetGenericTypeArguments().First();
      var targetItemType = targetPropType.GetGenericTypeArguments().First();
      if (targetItemType.IsSimple())
        return SimpleTypeConverterTypeCast(targetItemType.GetFullName());
    }
    return null;
  }

  private string? SimpleTypeConverterTypeCast(FullTypeName targetPropTypeName)
  {
    if (targetPropTypeName.Name == "String")
      return "(string)";
    if (targetPropTypeName.Name == "UInt32")
      return "(UInt32)";
    if (targetPropTypeName.Name == "HexInt")
      return "(HexInt)";
    if (targetPropTypeName.Name == "NumId")
      return "(NumId)";
    return null;
  }

  #endregion

  #region GenerateNotImplementedException
  private bool GenerateNotImplementedException(string msg, [CallerMemberName] string? callerName = null)
  {
    var message = $"\"Not implemented in {callerName}: {msg}\"";
    Writer.WriteLine($"throw new NotImplementedException({message});");
    return true;
  }
  #endregion

}