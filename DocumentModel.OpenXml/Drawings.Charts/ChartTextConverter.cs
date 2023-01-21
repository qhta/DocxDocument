namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartText Class.
/// </summary>
public static class ChartTextConverter
{
  /// <summary>
  /// String Reference.
  /// </summary>
  private static DMDrawsCharts.StringReference? GetStringReference(DXDrawCharts.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringReference>();
    if (itemElement != null)
      return DMXDrawsCharts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringReference(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.StringReference? value)
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
  private static DMDrawsCharts.RichText? GetRichText(DXDrawCharts.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.RichText>();
    if (itemElement != null)
      return DMXDrawsCharts.RichTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRichText(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.RichText? value)
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
  private static DMDrawsCharts.StringLiteral? GetStringLiteral(DXDrawCharts.ChartText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawCharts.StringLiteral>();
    if (itemElement != null)
      return DMXDrawsCharts.StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringLiteral(DXDrawCharts.ChartText openXmlElement, DMDrawsCharts.StringLiteral? value)
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
  
  public static DMDrawsCharts.ChartText? CreateModelElement(DXDrawCharts.ChartText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.ChartText();
      value.StringReference = GetStringReference(openXmlElement);
      value.RichText = GetRichText(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.ChartText? value)
    where OpenXmlElementType: DXDrawCharts.ChartText, new()
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
