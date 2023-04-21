namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// TextData.
  /// </summary>
  private static DMDCDs.TextData? GetTextData(DXO16DCD.Text openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.TextData>();
    if (element != null)
      return DMXDCDs.TextDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextData(DXO16DCD.Text openXmlElement, DMDCDs.TextData? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.TextDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.TextData>(), value, diffs, objName);
  }
  
  private static void SetTextData(DXO16DCD.Text openXmlElement, DMDCDs.TextData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.TextData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.TextDataConverter.CreateOpenXmlElement<DXO16DCD.TextData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  private static DMDCDs.RichTextBody? GetRichTextBody(DXO16DCD.Text openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.RichTextBody>();
    if (element != null)
      return DMXDCDs.RichTextBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRichTextBody(DXO16DCD.Text openXmlElement, DMDCDs.RichTextBody? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.RichTextBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.RichTextBody>(), value, diffs, objName);
  }
  
  private static void SetRichTextBody(DXO16DCD.Text openXmlElement, DMDCDs.RichTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.RichTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.RichTextBodyConverter.CreateOpenXmlElement<DXO16DCD.RichTextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Text? CreateModelElement(DXO16DCD.Text? openXmlElement)
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
  
  public static bool CompareModelElement(DXO16DCD.Text? openXmlElement, DMDCDs.Text? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.Text value)
    where OpenXmlElementType: DXO16DCD.Text, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.Text openXmlElement, DMDCDs.Text value)
  {
    SetTextData(openXmlElement, value?.TextData);
    SetRichTextBody(openXmlElement, value?.RichTextBody);
  }
}
