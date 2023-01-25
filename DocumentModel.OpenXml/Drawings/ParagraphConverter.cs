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
    return DMXDraws.ParagraphPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ParagraphProperties>());
  }
  
  private static bool CmpParagraphProperties(DXDraw.Paragraph openXmlElement, DMDraws.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.RunConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Run>());
  }
  
  private static bool CmpRun(DXDraw.Paragraph openXmlElement, DMDraws.Run? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Run>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.BreakConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Break>());
  }
  
  private static bool CmpBreak(DXDraw.Paragraph openXmlElement, DMDraws.Break? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Break>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.FieldConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.Field>());
  }
  
  private static bool CmpField(DXDraw.Paragraph openXmlElement, DMDraws.Field? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FieldConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Field>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement.GetFirstChild<DXO2010Draw.TextMath>() != null;
  }
  
  private static bool CmpTextMath(DXDraw.Paragraph openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXO2010Draw.TextMath>() != null == value;
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
    return DMXDraws.EndParagraphRunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.EndParagraphRunProperties>());
  }
  
  private static bool CmpEndParagraphRunProperties(DXDraw.Paragraph openXmlElement, DMDraws.EndParagraphRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.EndParagraphRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.EndParagraphRunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXDraw.Paragraph? openXmlElement, DMDraws.Paragraph? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParagraphProperties(openXmlElement, value.ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpRun(openXmlElement, value.Run, diffs, objName))
        ok = false;
      if (!CmpBreak(openXmlElement, value.Break, diffs, objName))
        ok = false;
      if (!CmpField(openXmlElement, value.Field, diffs, objName))
        ok = false;
      if (!CmpTextMath(openXmlElement, value.TextMath, diffs, objName))
        ok = false;
      if (!CmpEndParagraphRunProperties(openXmlElement, value.EndParagraphRunProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
