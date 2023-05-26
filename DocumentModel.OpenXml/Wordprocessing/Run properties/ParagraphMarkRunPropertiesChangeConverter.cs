namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.ParagraphMarkRunPropertiesChange"/> class from/to OpenXml converter.
/// </summary>
public static class ParagraphMarkRunPropertiesChangeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion

  #region Annotation Identifier conversion.
  private static String? GetId(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.ParagraphMarkRunPropertiesChange openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region PreviousParagraphMarkRunProperties conversion.
  private static DMW.PreviousParagraphMarkRunProperties? GetPreviousParagraphMarkRunProperties(DXW.ParagraphMarkRunPropertiesChange openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.PreviousParagraphMarkRunProperties>();
    if (element != null)
      return DMXW.PreviousParagraphMarkRunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPreviousParagraphMarkRunProperties(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DMW.PreviousParagraphMarkRunProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.PreviousParagraphMarkRunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.PreviousParagraphMarkRunProperties>(), value, diffs, objName, propName);
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
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ParagraphMarkRunPropertiesChange model conversion.
  public static DMW.ParagraphMarkRunPropertiesChange? CreateModelElement(DXW.ParagraphMarkRunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.ParagraphMarkRunPropertiesChange();
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.AnnotationId = GetId(openXmlElement);
      model.PreviousParagraphMarkRunProperties = GetPreviousParagraphMarkRunProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.ParagraphMarkRunPropertiesChange? openXmlElement, DMW.ParagraphMarkRunPropertiesChange? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, model.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, model.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, model.AnnotationId, diffs, objName, propName))
        ok = false;
      if (!CmpPreviousParagraphMarkRunProperties(openXmlElement, model.PreviousParagraphMarkRunProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ParagraphMarkRunPropertiesChange model)
    where OpenXmlElementType: DXW.ParagraphMarkRunPropertiesChange, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.ParagraphMarkRunPropertiesChange openXmlElement, DMW.ParagraphMarkRunPropertiesChange model)
  {
    SetAuthor(openXmlElement, model?.Author);
    SetDate(openXmlElement, model?.Date);
    SetId(openXmlElement, model?.AnnotationId);
    SetPreviousParagraphMarkRunProperties(openXmlElement, model?.PreviousParagraphMarkRunProperties);
  }
  #endregion
}
