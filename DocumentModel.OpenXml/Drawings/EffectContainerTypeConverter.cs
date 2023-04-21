namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public static class EffectContainerTypeConverter
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  private static DMD.EffectContainerKind? GetType(DXD.EffectContainerType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMD.EffectContainerKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXD.EffectContainerType openXmlElement, DMD.EffectContainerKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMD.EffectContainerKind>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXD.EffectContainerType openXmlElement, DMD.EffectContainerKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMD.EffectContainerKind>(value);
  }
  
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXD.EffectContainerType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXD.EffectContainerType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXD.EffectContainerType openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.EffectContainerType? CreateModelElement(DXD.EffectContainerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectContainerType();
      value.Type = GetType(openXmlElement);
      value.Name = GetName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.EffectContainerType? openXmlElement, DMD.EffectContainerType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EffectContainerType value)
    where OpenXmlElementType: DXD.EffectContainerType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.EffectContainerType openXmlElement, DMD.EffectContainerType value)
  {
    SetType(openXmlElement, value?.Type);
    SetName(openXmlElement, value?.Name);
  }
}
