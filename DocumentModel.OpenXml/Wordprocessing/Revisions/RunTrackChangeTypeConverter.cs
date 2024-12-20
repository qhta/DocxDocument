namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RunTrackChangeType"/> class from/to OpenXml converter
/// using <see cref="DXW.RunTrackChangeType"/>.
/// </summary>
public static class RunTrackChangeTypeConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXW.RunTrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.RunTrackChangeType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.RunTrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXW.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.RunTrackChangeType openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.RunTrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion


  #region Annotation Identifier conversion.
  private static String? GetId(DXW.RunTrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.RunTrackChangeType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.RunTrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  public static ElementType? CreateModelElement<ElementType>(DXW.RunTrackChangeType? openXmlElement)
    where ElementType : DMW.RunTrackChangeType, new ()
  {
    if (openXmlElement != null)
    {
      var model = new ElementType();
      model.Author = GetAuthor(openXmlElement);
      model.Date = GetDate(openXmlElement);
      model.Id = GetId(openXmlElement);
      ElementCollectionConverter<DMW.IParagraphContent>.FillModelElementCollection(
        openXmlElement, model,
        ParagraphContentConverter.CreateParagraphContent);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RunTrackChangeType? openXmlElement, DMW.RunTrackChangeType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, model.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, model.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, model.Id, diffs, objName, propName))
        ok = false;
      if (!ElementCollectionConverter<DMW.IParagraphContent>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        ParagraphContentConverter.CompareParagraphContent, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunTrackChangeType model)
    where OpenXmlElementType: DXW.RunTrackChangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.RunTrackChangeType openXmlElement, DMW.RunTrackChangeType model)
  {
    SetAuthor(openXmlElement, model.Author);
    SetDate(openXmlElement, model.Date);
    SetId(openXmlElement, model.Id);
    return ElementCollectionConverter<DMW.IParagraphContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      ParagraphContentConverter.CompareParagraphContent,
      ParagraphContentConverter.UpdateOpenXmlParagraphContent,
      ParagraphContentConverter.CreateOpenXmlParagraphContent);
  }
}
