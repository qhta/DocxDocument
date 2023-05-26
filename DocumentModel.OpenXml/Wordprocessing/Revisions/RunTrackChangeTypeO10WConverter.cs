namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RunTrackChangeType"/> class from/to OpenXml converter
/// using <see cref="DXO10W.RunTrackChangeType"/>.
/// </summary>
public static class RunTrackChangeTypeO10WConverter
{
  #region Author conversion.
  private static String? GetAuthor(DXO10W.RunTrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXO10W.RunTrackChangeType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXO10W.RunTrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Date conversion.
  private static DateTime? GetDate(DXO10W.RunTrackChangeType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXO10W.RunTrackChangeType openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXO10W.RunTrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  #endregion


  #region Annotation Identifier conversion.
  private static String? GetId(DXO10W.RunTrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10W.RunTrackChangeType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10W.RunTrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  public static ElementType? CreateModelElement<ElementType>(DXO10W.RunTrackChangeType? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10W.RunTrackChangeType? openXmlElement, DMW.RunTrackChangeType? model, DiffList? diffs = null, string? objName = null, string? propName = null)
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
    where OpenXmlElementType: DXO10W.RunTrackChangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXO10W.RunTrackChangeType openXmlElement, DMW.RunTrackChangeType model)
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
