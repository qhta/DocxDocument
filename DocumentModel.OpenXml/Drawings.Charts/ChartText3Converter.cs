namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public static class ChartText3Converter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DMDrawsCharts.StringReference? GetStringReference(DXO2013DrawChart.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringReference(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.StringReference? value)
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
  /// Rich Text.
  /// </summary>
  private static DMDrawsCharts.RichText? GetRichText(DXO2013DrawChart.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.RichText>();
    if (itemElement != null)
      return DMXDrawsCharts.RichTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRichText(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.RichText? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.RichText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.RichTextConverter.CreateOpenXmlElement<DXDrawCharts.RichText>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// String Literal.
  /// </summary>
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXO2013DrawChart.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringLiteral(DXO2013DrawChart.ChartText openXmlElement, DMDrawsCharts.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.StringLiteralConverter.CreateOpenXmlElement<DXDrawCharts.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.ChartText3? CreateModelElement(DXO2013DrawChart.ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ChartText3();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartText3? value)
    where OpenXmlElementType: DXO2013DrawChart.ChartText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStringReference(openXmlElement, value?.StringReference);
      SetRichText(openXmlElement, value?.RichText);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}
