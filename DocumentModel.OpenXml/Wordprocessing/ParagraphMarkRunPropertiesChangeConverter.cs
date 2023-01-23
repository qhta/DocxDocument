namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public static class ParagraphMarkRunPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static bool CmpDate(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Date?.Value == value;
  }
  
  private static void SetDate(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  private static DMW.PreviousParagraphMarkRunProperties? GetPreviousParagraphMarkRunProperties(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return DMXW.PreviousParagraphMarkRunPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.PreviousParagraphMarkRunProperties>());
  }
  
  private static bool CmpPreviousParagraphMarkRunProperties(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DMW.PreviousParagraphMarkRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.PreviousParagraphMarkRunPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.PreviousParagraphMarkRunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPreviousParagraphMarkRunProperties(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DMW.PreviousParagraphMarkRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousParagraphMarkRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousParagraphMarkRunPropertiesConverter.CreateOpenXmlElement<DXW.PreviousParagraphMarkRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.ParagraphMarkRunPropertiesChange? CreateModelElement(DXW.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphMarkRunPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousParagraphMarkRunProperties = GetPreviousParagraphMarkRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphMarkRunPropertiesChange? openXmlElement, DMW.ParagraphMarkRunPropertiesChange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpPreviousParagraphMarkRunProperties(openXmlElement, value.PreviousParagraphMarkRunProperties, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphMarkRunPropertiesChange? value)
    where OpenXmlElementType: DXW.ParagraphMarkRunPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousParagraphMarkRunProperties(openXmlElement, value?.PreviousParagraphMarkRunProperties);
      return openXmlElement;
    }
    return default;
  }
}
