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
    var itemElement = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesBaseStyle>();
    if (itemElement != null)
      return DMXW.ParagraphPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.ParagraphPropertiesDefault? CreateModelElement(DXW.ParagraphPropertiesDefault? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphPropertiesDefault();
      value.ParagraphPropertiesBaseStyle = GetParagraphPropertiesBaseStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphPropertiesDefault? value)
    where OpenXmlElementType: DXW.ParagraphPropertiesDefault, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParagraphPropertiesBaseStyle(openXmlElement, value?.ParagraphPropertiesBaseStyle);
      return openXmlElement;
    }
    return default;
  }
}
