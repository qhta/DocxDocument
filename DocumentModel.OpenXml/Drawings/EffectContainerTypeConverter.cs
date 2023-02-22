namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public static class EffectContainerTypeConverter
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  private static DMDraws.EffectContainerKind? GetType(DXDraw.EffectContainerType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMDraws.EffectContainerKind>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXDraw.EffectContainerType openXmlElement, DMDraws.EffectContainerKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMDraws.EffectContainerKind>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXDraw.EffectContainerType openXmlElement, DMDraws.EffectContainerKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.EffectContainerValues, DMDraws.EffectContainerKind>(value);
  }
  
  /// <summary>
  /// Name
  /// </summary>
  private static String? GetName(DXDraw.EffectContainerType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXDraw.EffectContainerType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXDraw.EffectContainerType openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.EffectContainerType? CreateModelElement(DXDraw.EffectContainerType? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.EffectContainerType? openXmlElement, DMDraws.EffectContainerType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.EffectContainerType value)
    where OpenXmlElementType: DXDraw.EffectContainerType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.EffectContainerType openXmlElement, DMDraws.EffectContainerType value)
  {
    SetType(openXmlElement, value?.Type);
    SetName(openXmlElement, value?.Name);
  }
}
