namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Series Text.
/// </summary>
public static class SeriesTextConverter
{
  /// <summary>
  /// StringReference.
  /// </summary>
  private static DMDC.StringReference? GetStringReference(DXDC.SeriesText openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.StringReference>();
    if (element != null)
      return DMXDC.StringReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringReference(DXDC.SeriesText openXmlElement, DMDC.StringReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDC.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringReference>(), value, diffs, objName, propName);
  }
  
  private static void SetStringReference(DXDC.SeriesText openXmlElement, DMDC.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.StringReferenceConverter.CreateOpenXmlElement<DXDC.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  private static String? GetNumericValue(DXDC.SeriesText openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.NumericValue>()?.Text;
  }
  
  private static bool CmpNumericValue(DXDC.SeriesText openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDC.NumericValue>()?.Text == value;
  }
  
  private static void SetNumericValue(DXDC.SeriesText openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.NumericValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDC.NumericValue { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.SeriesText? CreateModelElement(DXDC.SeriesText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.SeriesText();
      value.StringReference = GetStringReference(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SeriesText? openXmlElement, DMDC.SeriesText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName, propName))
        ok = false;
      if (!CmpNumericValue(openXmlElement, value.NumericValue, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SeriesText value)
    where OpenXmlElementType: DXDC.SeriesText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.SeriesText openXmlElement, DMDC.SeriesText value)
  {
    SetStringReference(openXmlElement, value?.StringReference);
    SetNumericValue(openXmlElement, value?.NumericValue);
  }
}
