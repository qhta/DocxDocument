namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumberingFormat"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingFormatConverter
{
  #region NumberFormatType conversion.
  private static DMW.NumberFormatKind? GetVal(DXW.NumberingFormat openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.NumberingFormat openXmlElement, DMW.NumberFormatKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.NumberFormatValues, DMW.NumberFormatKind>(openXmlElement?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVal(DXW.NumberingFormat openXmlElement, DMW.NumberFormatKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.NumberFormatValues, DMW.NumberFormatKind>(value);
  }
  #endregion

  #region Format conversion.
  private static String? GetFormat(DXW.NumberingFormat openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Format);
  }
  
  private static bool CmpFormat(DXW.NumberingFormat openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Format, value, diffs, objName, "Custom");
  }
  
  private static void SetFormat(DXW.NumberingFormat openXmlElement, String? value)
  {
    openXmlElement.Format = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region NumberingFormat model conversion.
  public static DMW.NumberingFormat? CreateModelElement(DXW.NumberingFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumberingFormat();
      model.Type = GetVal(openXmlElement);
      model.Custom = GetFormat(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingFormat? openXmlElement, DMW.NumberingFormat? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, model.Type, diffs, objName, propName))
        ok = false;
      if (!CmpFormat(openXmlElement, model.Custom, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingFormat model)
    where OpenXmlElementType: DXW.NumberingFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.NumberingFormat openXmlElement, DMW.NumberingFormat model)
  {
    SetVal(openXmlElement, model?.Type);
    SetFormat(openXmlElement, model?.Custom);
  }
  #endregion
}
