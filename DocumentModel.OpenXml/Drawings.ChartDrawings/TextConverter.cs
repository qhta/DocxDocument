namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// TextData.
  /// </summary>
  private static DMDrawsChartDraws.TextData? GetTextData(DXO2016DrawChartDraw.Text openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TextData>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TextDataConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextData(DXO2016DrawChartDraw.Text openXmlElement, DMDrawsChartDraws.TextData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TextData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TextDataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.TextData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  private static DMDrawsChartDraws.RichTextBody? GetRichTextBody(DXO2016DrawChartDraw.Text openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.RichTextBody>();
    if (itemElement != null)
      return DMXDrawsChartDraws.RichTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRichTextBody(DXO2016DrawChartDraw.Text openXmlElement, DMDrawsChartDraws.RichTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RichTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.RichTextBodyConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.RichTextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.Text? CreateModelElement(DXO2016DrawChartDraw.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.Text();
      value.TextData = GetTextData(openXmlElement);
      value.RichTextBody = GetRichTextBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Text? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Text, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTextData(openXmlElement, value?.TextData);
      SetRichTextBody(openXmlElement, value?.RichTextBody);
      return openXmlElement;
    }
    return default;
  }
}
