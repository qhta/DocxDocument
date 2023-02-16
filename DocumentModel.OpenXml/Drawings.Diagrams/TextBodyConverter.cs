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
    var element = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (element != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXDrawDgms.TextBody openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (element != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXDrawDgms.TextBody openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    var element = openXmlElement?.GetFirstChild<DXDraw.Paragraph>();
    if (element != null)
      return DMXDraws.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXDrawDgms.TextBody openXmlElement, DMDraws.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Drawings.Diagrams.TextBody? CreateModelElement(DXDrawDgms.TextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.TextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawDgms.TextBody? openXmlElement, DMDrawsDgms.TextBody? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
