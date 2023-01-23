namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Rich Text.
/// </summary>
public static class RichTextConverter
{
  private static DMDraws.BodyProperties? GetBodyProperties(DXDrawCharts.RichText openXmlElement)
  {
    return DMXDraws.BodyPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.BodyProperties>());
  }
  
  private static bool CmpBodyProperties(DXDrawCharts.RichText openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ListStyleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ListStyle>());
  }
  
  private static bool CmpListStyle(DXDrawCharts.RichText openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.ParagraphConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Paragraph>());
  }
  
  private static bool CmpParagraph(DXDrawCharts.RichText openXmlElement, DMDraws.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ParagraphConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDrawCharts.RichText? openXmlElement, DMDrawsCharts.RichText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBodyProperties(openXmlElement, value.BodyProperties, diffs, objName))
        ok = false;
      if (!CmpListStyle(openXmlElement, value.ListStyle, diffs, objName))
        ok = false;
      if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
