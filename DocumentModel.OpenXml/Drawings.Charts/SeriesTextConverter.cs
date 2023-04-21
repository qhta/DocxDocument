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
  
  private static bool CmpStringReference(DXDC.SeriesText openXmlElement, DMDC.StringReference? value, DiffList? diffs, string? objName)
  {
    return DMXDC.StringReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.StringReference>(), value, diffs, objName);
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
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  private static String? GetNumericValue(DXDC.SeriesText openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDC.NumericValue>()?.Text;
  }
  
  private static bool CmpNumericValue(DXDC.SeriesText openXmlElement, String? value, DiffList? diffs, string? objName)
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
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SeriesText? CreateModelElement(DXDC.SeriesText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SeriesText();
      value.StringReference = GetStringReference(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.SeriesText? openXmlElement, DMDC.SeriesText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStringReference(openXmlElement, value.StringReference, diffs, objName))
        ok = false;
      if (!CmpNumericValue(openXmlElement, value.NumericValue, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
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
