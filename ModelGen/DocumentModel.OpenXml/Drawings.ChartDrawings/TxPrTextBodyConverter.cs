namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public static class TxPrTextBodyConverter
{
  private static DMDraws.BodyProperties? GetBodyProperties(DXO2016DrawChartDraw.TxPrTextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BodyProperties>();
    if (element != null)
      return DMXDraws.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDraws.BodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBodyProperties(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDraws.BodyProperties? value)
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
  
  private static DMDraws.ListStyle? GetListStyle(DXO2016DrawChartDraw.TxPrTextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ListStyle>();
    if (element != null)
      return DMXDraws.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDraws.ListStyle? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ListStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetListStyle(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDraws.ListStyle? value)
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
  
  private static DMDraws.Paragraph? GetParagraph(DXO2016DrawChartDraw.TxPrTextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Paragraph>();
    if (element != null)
      return DMXDraws.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDraws.Paragraph? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Paragraph>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraph(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDraws.Paragraph? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.TxPrTextBody? CreateModelElement(DXO2016DrawChartDraw.TxPrTextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.TxPrTextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.TxPrTextBody? openXmlElement, DMDrawsChartDraws.TxPrTextBody? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.TxPrTextBody value)
    where OpenXmlElementType: DXO2016DrawChartDraw.TxPrTextBody, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.TxPrTextBody openXmlElement, DMDrawsChartDraws.TxPrTextBody value)
  {
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
    SetParagraph(openXmlElement, value?.Paragraph);
  }
}
