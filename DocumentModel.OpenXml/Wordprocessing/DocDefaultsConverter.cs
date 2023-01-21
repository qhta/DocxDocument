namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public static class DocDefaultsConverter
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  private static DMW.RunPropertiesDefault? GetRunPropertiesDefault(DXW.DocDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunPropertiesDefault>();
    if (itemElement != null)
      return DMXW.RunPropertiesDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunPropertiesDefault(DXW.DocDefaults openXmlElement, DMW.RunPropertiesDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesDefaultConverter.CreateOpenXmlElement<DXW.RunPropertiesDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  private static DMW.ParagraphPropertiesDefault? GetParagraphPropertiesDefault(DXW.DocDefaults openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesDefault>();
    if (itemElement != null)
      return DMXW.ParagraphPropertiesDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraphPropertiesDefault(DXW.DocDefaults openXmlElement, DMW.ParagraphPropertiesDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesDefaultConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DocDefaults? CreateModelElement(DXW.DocDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocDefaults();
      value.RunPropertiesDefault = GetRunPropertiesDefault(openXmlElement);
      value.ParagraphPropertiesDefault = GetParagraphPropertiesDefault(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocDefaults? value)
    where OpenXmlElementType: DXW.DocDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunPropertiesDefault(openXmlElement, value?.RunPropertiesDefault);
      SetParagraphPropertiesDefault(openXmlElement, value?.ParagraphPropertiesDefault);
      return openXmlElement;
    }
    return default;
  }
}
