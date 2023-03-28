namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ObjectEmbed Class converter from/to OpenXml.
///</summary>
public static class ObjectEmbedConverter
{
  /// <summary>
  /// drawAspect
  /// </summary>
  private static DMW.ObjectDrawAspect? GetdrawAspect(DXW.ObjectEmbed openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value);
  }
  
  private static bool CmpdrawAspect(DXW.ObjectEmbed openXmlElement, DMW.ObjectDrawAspect? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(openXmlElement?.drawAspect?.Value, value, diffs, objName);
  }
  
  private static void SetdrawAspect(DXW.ObjectEmbed openXmlElement, DMW.ObjectDrawAspect? value)
  {
    openXmlElement.drawAspect = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ObjectDrawAspect, DMW.ObjectDrawAspect>(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXW.ObjectEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.ObjectEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.ObjectEmbed openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// progId
  /// </summary>
  private static String? GetProgId(DXW.ObjectEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ProgId);
  }
  
  private static bool CmpProgId(DXW.ObjectEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ProgId, value, diffs, objName, "ProgId");
  }
  
  private static void SetProgId(DXW.ObjectEmbed openXmlElement, String? value)
  {
    openXmlElement.ProgId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// shapeId
  /// </summary>
  private static String? GetShapeId(DXW.ObjectEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ShapeId);
  }
  
  private static bool CmpShapeId(DXW.ObjectEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ShapeId, value, diffs, objName, "ShapeId");
  }
  
  private static void SetShapeId(DXW.ObjectEmbed openXmlElement, String? value)
  {
    openXmlElement.ShapeId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// fieldCodes
  /// </summary>
  private static String? GetFieldCodes(DXW.ObjectEmbed openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.FieldCodes);
  }
  
  private static bool CmpFieldCodes(DXW.ObjectEmbed openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.FieldCodes, value, diffs, objName, "FieldCodes");
  }
  
  private static void SetFieldCodes(DXW.ObjectEmbed openXmlElement, String? value)
  {
    openXmlElement.FieldCodes = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.ObjectEmbed? CreateModelElement(DXW.ObjectEmbed? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ObjectEmbed();
      value.drawAspect = GetdrawAspect(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ProgId = GetProgId(openXmlElement);
      value.ShapeId = GetShapeId(openXmlElement);
      value.FieldCodes = GetFieldCodes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ObjectEmbed? openXmlElement, DMW.ObjectEmbed? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpdrawAspect(openXmlElement, value.drawAspect, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpProgId(openXmlElement, value.ProgId, diffs, objName))
        ok = false;
      if (!CmpShapeId(openXmlElement, value.ShapeId, diffs, objName))
        ok = false;
      if (!CmpFieldCodes(openXmlElement, value.FieldCodes, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ObjectEmbed value)
    where OpenXmlElementType: DXW.ObjectEmbed, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ObjectEmbed openXmlElement, DMW.ObjectEmbed value)
  {
    SetdrawAspect(openXmlElement, value?.drawAspect);
    SetId(openXmlElement, value?.Id);
    SetProgId(openXmlElement, value?.ProgId);
    SetShapeId(openXmlElement, value?.ShapeId);
    SetFieldCodes(openXmlElement, value?.FieldCodes);
  }
}
