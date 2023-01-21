namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public static class ParagraphPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXW.ParagraphPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXW.ParagraphPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.ParagraphPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  private static DMW.ParagraphPropertiesExtended? GetParagraphPropertiesExtended(DXW.ParagraphPropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesExtended>();
    if (itemElement != null)
      return DMXW.ParagraphPropertiesExtendedConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetParagraphPropertiesExtended(DXW.ParagraphPropertiesChange openXmlElement, DMW.ParagraphPropertiesExtended? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesExtended>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesExtendedConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesExtended>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.ParagraphPropertiesChange? CreateModelElement(DXW.ParagraphPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.ParagraphPropertiesExtended = GetParagraphPropertiesExtended(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphPropertiesChange? value)
    where OpenXmlElementType: DXW.ParagraphPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetParagraphPropertiesExtended(openXmlElement, value?.ParagraphPropertiesExtended);
      return openXmlElement;
    }
    return default;
  }
}
