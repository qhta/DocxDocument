namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Paragraphs.
/// </summary>
public static class ParagraphConverter
{
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  private static DMD.ParagraphProperties? GetParagraphProperties(DXD.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphProperties(DXD.Paragraph openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetParagraphProperties(DXD.Paragraph openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Run? GetRun(DXD.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Run>();
    if (element != null)
      return DMXD.RunConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRun(DXD.Paragraph openXmlElement, DMD.Run? value, DiffList? diffs, string? objName)
  {
    return DMXD.RunConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Run>(), value, diffs, objName);
  }
  
  private static void SetRun(DXD.Paragraph openXmlElement, DMD.Run? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Run>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RunConverter.CreateOpenXmlElement<DXD.Run>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Break? GetBreak(DXD.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Break>();
    if (element != null)
      return DMXD.BreakConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBreak(DXD.Paragraph openXmlElement, DMD.Break? value, DiffList? diffs, string? objName)
  {
    return DMXD.BreakConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Break>(), value, diffs, objName);
  }
  
  private static void SetBreak(DXD.Paragraph openXmlElement, DMD.Break? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Break>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BreakConverter.CreateOpenXmlElement<DXD.Break>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Field? GetField(DXD.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Field>();
    if (element != null)
      return DMXD.FieldConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpField(DXD.Paragraph openXmlElement, DMD.Field? value, DiffList? diffs, string? objName)
  {
    return DMXD.FieldConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Field>(), value, diffs, objName);
  }
  
  private static void SetField(DXD.Paragraph openXmlElement, DMD.Field? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Field>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FieldConverter.CreateOpenXmlElement<DXD.Field>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Boolean? GetTextMath(DXD.Paragraph openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10D.TextMath>() != null;
  }
  
  private static bool CmpTextMath(DXD.Paragraph openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10D.TextMath>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10D.TextMath", val, value);
    return false;
  }
  
  private static void SetTextMath(DXD.Paragraph openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10D.TextMath>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10D.TextMath();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.EndParagraphRunProperties? GetEndParagraphRunProperties(DXD.Paragraph openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.EndParagraphRunProperties>();
    if (element != null)
      return DMXD.EndParagraphRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEndParagraphRunProperties(DXD.Paragraph openXmlElement, DMD.EndParagraphRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.EndParagraphRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.EndParagraphRunProperties>(), value, diffs, objName);
  }
  
  private static void SetEndParagraphRunProperties(DXD.Paragraph openXmlElement, DMD.EndParagraphRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.EndParagraphRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.EndParagraphRunPropertiesConverter.CreateOpenXmlElement<DXD.EndParagraphRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Paragraph? CreateModelElement(DXD.Paragraph? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Paragraph();
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
  
  public static bool CompareModelElement(DXD.Paragraph? openXmlElement, DMD.Paragraph? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Paragraph value)
    where OpenXmlElementType: DXD.Paragraph, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Paragraph openXmlElement, DMD.Paragraph value)
  {
    SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
    SetRun(openXmlElement, value?.Run);
    SetBreak(openXmlElement, value?.Break);
    SetField(openXmlElement, value?.Field);
    SetTextMath(openXmlElement, value?.TextMath);
    SetEndParagraphRunProperties(openXmlElement, value?.EndParagraphRunProperties);
  }
}
