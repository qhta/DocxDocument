namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Rich Text.
/// </summary>
public static class RichTextConverter
{
  private static DMDraws.BodyProperties? GetBodyProperties(DXDrawCharts.RichText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBodyProperties(DXDrawCharts.RichText openXmlElement, DMDraws.BodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BodyPropertiesConverter.CreateOpenXmlElement<DXDraw.BodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.ListStyle? GetListStyle(DXDrawCharts.RichText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetListStyle(DXDrawCharts.RichText openXmlElement, DMDraws.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ListStyleConverter.CreateOpenXmlElement<DXDraw.ListStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Paragraph? GetParagraph(DXDrawCharts.RichText openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Paragraph>();
    if (itemElement != null)
      return DMXDraws.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraph(DXDrawCharts.RichText openXmlElement, DMDraws.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ParagraphConverter.CreateOpenXmlElement<DXDraw.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsCharts.RichText? CreateModelElement(DXDrawCharts.RichText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.RichText();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.RichText? value)
    where OpenXmlElementType: DXDrawCharts.RichText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBodyProperties(openXmlElement, value?.BodyProperties);
      SetListStyle(openXmlElement, value?.ListStyle);
      SetParagraph(openXmlElement, value?.Paragraph);
      return openXmlElement;
    }
    return default;
  }
}
