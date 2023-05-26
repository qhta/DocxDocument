namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public static class ShadingConverter
{
  #region Shading Pattern conversion.
  private static DMW.ShadingPatternKind? GetVal(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ShadingPatternValues, DMW.ShadingPatternKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.Shading openXmlElement, DMW.ShadingPatternKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ShadingPatternValues, DMW.ShadingPatternKind>(openXmlElement?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVal(DXW.Shading openXmlElement, DMW.ShadingPatternKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.ShadingPatternValues, DMW.ShadingPatternKind>(value);
  }
  #endregion
 
 
  #region Shading model conversion
  public static DMW.Shading? CreateModelElement(DXW.Shading? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Shading();
      value.Pattern = GetVal(openXmlElement);
      value.ForegroundColor = ShadingColorConverter.CreateModelElement(openXmlElement);
      value.BackgroundColor = ShadingFillColorConverter.CreateModelElement(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Shading? openXmlElement, DMW.Shading? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Pattern, diffs, objName, propName))
        ok = false;
      if (!ShadingColorConverter.CompareModelElement(openXmlElement, value.ForegroundColor, diffs, objName, propName))
        ok = false;
      if (!ShadingFillColorConverter.CompareModelElement(openXmlElement, value.BackgroundColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Shading value)
    where OpenXmlElementType: DXW.Shading, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Shading openXmlElement, DMW.Shading value)
  {
    SetVal(openXmlElement, value?.Pattern);
    ShadingColorConverter.UpdateOpenXmlElement(openXmlElement, value?.ForegroundColor);
    ShadingFillColorConverter.UpdateOpenXmlElement(openXmlElement, value?.BackgroundColor);
  }
  #endregion
}
