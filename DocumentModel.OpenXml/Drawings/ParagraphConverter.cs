namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  private static DMDraws.ParagraphProperties? GetParagraphProperties(DXDraw.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraphProperties(DXDraw.Paragraph openXmlElement, DMDraws.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Run? GetRun(DXDraw.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Run>();
    if (itemElement != null)
      return DMXDraws.RunConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRun(DXDraw.Paragraph openXmlElement, DMDraws.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RunConverter.CreateOpenXmlElement<DXDraw.Run>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Break? GetBreak(DXDraw.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Break>();
    if (itemElement != null)
      return DMXDraws.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBreak(DXDraw.Paragraph openXmlElement, DMDraws.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BreakConverter.CreateOpenXmlElement<DXDraw.Break>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.Field? GetField(DXDraw.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Field>();
    if (itemElement != null)
      return DMXDraws.FieldConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetField(DXDraw.Paragraph openXmlElement, DMDraws.Field? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Field>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FieldConverter.CreateOpenXmlElement<DXDraw.Field>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetTextMath(DXDraw.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.TextMath>();
    return itemElement != null;
  }
  
  private static void SetTextMath(DXDraw.Paragraph openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010Draw.TextMath>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010Draw.TextMath();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.EndParagraphRunProperties? GetEndParagraphRunProperties(DXDraw.Paragraph openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.EndParagraphRunProperties>();
    if (itemElement != null)
      return DMXDraws.EndParagraphRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEndParagraphRunProperties(DXDraw.Paragraph openXmlElement, DMDraws.EndParagraphRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.EndParagraphRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.EndParagraphRunPropertiesConverter.CreateOpenXmlElement<DXDraw.EndParagraphRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.Paragraph? CreateModelElement(DXDraw.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Paragraph();
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.Run = GetRun(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Field = GetField(openXmlElement);
      value.TextMath = GetTextMath(openXmlElement);
      value.EndParagraphRunProperties = GetEndParagraphRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Paragraph? value)
    where OpenXmlElementType: DXDraw.Paragraph, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetRun(openXmlElement, value?.Run);
      SetBreak(openXmlElement, value?.Break);
      SetField(openXmlElement, value?.Field);
      SetTextMath(openXmlElement, value?.TextMath);
      SetEndParagraphRunProperties(openXmlElement, value?.EndParagraphRunProperties);
      return openXmlElement;
    }
    return default;
  }
}
