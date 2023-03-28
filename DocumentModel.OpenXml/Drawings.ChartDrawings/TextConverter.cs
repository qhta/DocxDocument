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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TextData>();
    if (element != null)
      return DMXDrawsChartDraws.TextDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextData(DXO2016DrawChartDraw.Text openXmlElement, DMDrawsChartDraws.TextData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.TextDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TextData>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.RichTextBody>();
    if (element != null)
      return DMXDrawsChartDraws.RichTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRichTextBody(DXO2016DrawChartDraw.Text openXmlElement, DMDrawsChartDraws.RichTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.RichTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.RichTextBody>(), value, diffs, objName);
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
  
  public static DocumentModel.Drawings.ChartDrawings.Text? CreateModelElement(DXO2016DrawChartDraw.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Text();
      value.TextData = GetTextData(openXmlElement);
      value.RichTextBody = GetRichTextBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Text? openXmlElement, DMDrawsChartDraws.Text? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTextData(openXmlElement, value.TextData, diffs, objName))
        ok = false;
      if (!CmpRichTextBody(openXmlElement, value.RichTextBody, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Text value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Text, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.Text openXmlElement, DMDrawsChartDraws.Text value)
  {
    SetTextData(openXmlElement, value?.TextData);
    SetRichTextBody(openXmlElement, value?.RichTextBody);
  }
}
