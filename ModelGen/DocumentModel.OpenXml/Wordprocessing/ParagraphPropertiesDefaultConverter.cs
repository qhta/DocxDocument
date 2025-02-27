namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesDefaultConverter
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  private static DMW.ParagraphPropertiesBaseStyle? GetParagraphPropertiesBaseStyle(DXW.ParagraphPropertiesDefault openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
    if (element != null)
      return DMXW.ParagraphPropertiesBaseStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphPropertiesBaseStyle(DXW.ParagraphPropertiesDefault openXmlElement, DMW.ParagraphPropertiesBaseStyle? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesBaseStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphPropertiesBaseStyle(DXW.ParagraphPropertiesDefault openXmlElement, DMW.ParagraphPropertiesBaseStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesBaseStyleConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesBaseStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.ParagraphPropertiesDefault? CreateModelElement(DXW.ParagraphPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.ParagraphPropertiesDefault();
      value.ParagraphPropertiesBaseStyle = GetParagraphPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphPropertiesDefault? openXmlElement, DMW.ParagraphPropertiesDefault? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpParagraphPropertiesBaseStyle(openXmlElement, value.ParagraphPropertiesBaseStyle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphPropertiesDefault value)
    where OpenXmlElementType: DXW.ParagraphPropertiesDefault, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ParagraphPropertiesDefault openXmlElement, DMW.ParagraphPropertiesDefault value)
  {
    SetParagraphPropertiesBaseStyle(openXmlElement, value?.ParagraphPropertiesBaseStyle);
  }
}
