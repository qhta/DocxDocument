namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Text Body.
/// </summary>
public static class TextBodyConverter
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  private static DMDraws.BodyProperties? GetBodyProperties(DXDrawDgms.TextBody openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (itemElement != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBodyProperties(DXDrawDgms.TextBody openXmlElement, DMDraws.BodyProperties? value)
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
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  private static DMDraws.ListStyle? GetListStyle(DXDrawDgms.TextBody openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (itemElement != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetListStyle(DXDrawDgms.TextBody openXmlElement, DMDraws.ListStyle? value)
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
  
  private static DMDraws.Paragraph? GetParagraph(DXDrawDgms.TextBody openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Paragraph>();
    if (itemElement != null)
      return DMXDraws.ParagraphConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraph(DXDrawDgms.TextBody openXmlElement, DMDraws.Paragraph? value)
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
  
  public static DMDrawsDgms.TextBody? CreateModelElement(DXDrawDgms.TextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.TextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.TextBody? value)
    where OpenXmlElementType: DXDrawDgms.TextBody, new()
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
