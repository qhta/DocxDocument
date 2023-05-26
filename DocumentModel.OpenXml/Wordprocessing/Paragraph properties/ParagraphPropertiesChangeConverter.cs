namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ParagraphPropertiesChange"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphPropertiesChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.ParagraphPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.ParagraphPropertiesChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.ParagraphPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXW.ParagraphPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.ParagraphPropertiesChange openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.ParagraphPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.ParagraphPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.ParagraphPropertiesChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.ParagraphPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region PreviousParagraphProperties conversion.
  private static DMW.PreviousParagraphProperties? GetPreviousParagraphProperties(DXW.ParagraphPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousParagraphProperties>();
    if (element != null)
      return DMXW.PreviousParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousParagraphProperties(DXW.ParagraphPropertiesChange openXmlElement, DMW.PreviousParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.PreviousParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousParagraphProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetPreviousParagraphProperties(DXW.ParagraphPropertiesChange openXmlElement, DMW.PreviousParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousParagraphPropertiesConverter.CreateOpenXmlElement<DXW.PreviousParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ParagraphPropertiesChange model conversion.
  public static DMW.ParagraphPropertiesChange? CreateModelElement(DXW.ParagraphPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ParagraphPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.AnnotationId = GetId(openXmlElement);
      value.PreviousParagraphProperties = GetPreviousParagraphProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphPropertiesChange? openXmlElement, DMW.ParagraphPropertiesChange? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.AnnotationId, diffs, objName, propName))
        ok = false;
      if (!CmpPreviousParagraphProperties(openXmlElement, value.PreviousParagraphProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphPropertiesChange value)
    where OpenXmlElementType: DXW.ParagraphPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ParagraphPropertiesChange openXmlElement, DMW.ParagraphPropertiesChange value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.AnnotationId);
    SetPreviousParagraphProperties(openXmlElement, value?.PreviousParagraphProperties);
  }
  #endregion

}
