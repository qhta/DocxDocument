namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Series Text.
/// </summary>
public static class SeriesTextConverter
{
  /// <summary>
  /// StringReference.
  /// </summary>
  private static DMDrawsCharts.StringReference? GetStringReference(DXDrawCharts.SeriesText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringReference(DXDrawCharts.SeriesText openXmlElement, DMDrawsCharts.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringReferenceConverter.CreateOpenXmlElement<DXDrawCharts.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  private static String? GetNumericValue(DXDrawCharts.SeriesText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.NumericValue>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetNumericValue(DXDrawCharts.SeriesText openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.NumericValue>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawCharts.NumericValue { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.SeriesText? CreateModelElement(DXDrawCharts.SeriesText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.SeriesText();
      value.StringReference = GetStringReference(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SeriesText? value)
    where OpenXmlElementType: DXDrawCharts.SeriesText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringReference(openXmlElement, value?.StringReference);
      SetNumericValue(openXmlElement, value?.NumericValue);
      return openXmlElement;
    }
    return default;
  }
}
