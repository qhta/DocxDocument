namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public static class CatAxExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDC.CatAxExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDC.CatAxExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDC.CatAxExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMDC.NumberingFormat3? GetNumberingFormat(DXDC.CatAxExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DC.NumberingFormat>();
    if (element != null)
      return DMXDC.NumberingFormat3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumberingFormat(DXDC.CatAxExtension openXmlElement, DMDC.NumberingFormat3? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.NumberingFormat3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DC.NumberingFormat>(), value, diffs, objName, propName);
  }
  
  private static void SetNumberingFormat(DXDC.CatAxExtension openXmlElement, DMDC.NumberingFormat3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DC.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.NumberingFormat3Converter.CreateOpenXmlElement<DXO13DC.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.CatAxExtension? CreateModelElement(DXDC.CatAxExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.CatAxExtension();
      value.Uri = GetUri(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.CatAxExtension? openXmlElement, DMDC.CatAxExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpNumberingFormat(openXmlElement, value.NumberingFormat, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.CatAxExtension value)
    where OpenXmlElementType: DXDC.CatAxExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.CatAxExtension openXmlElement, DMDC.CatAxExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetNumberingFormat(openXmlElement, value?.NumberingFormat);
  }
}
