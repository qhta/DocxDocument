namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TrackChangeType Class.
/// </summary>
public static class TrackChangeType2Converter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXO10W.TrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }

  private static bool CmpAuthor(DXO10W.TrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }

  private static void SetAuthor(DXO10W.TrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }

  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXO10W.TrackChangeType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }

  private static bool CmpDate(DXO10W.TrackChangeType openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }

  private static void SetDate(DXO10W.TrackChangeType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }

  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXO10W.TrackChangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }

  private static bool CmpId(DXO10W.TrackChangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }

  private static void SetId(DXO10W.TrackChangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }

  public static ElementType? CreateModelElement<ElementType>(DXO10W.TrackChangeType? openXmlElement)
    where ElementType : DMW.TrackChangeType2, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static DMW.CustomXmlConflictInsertionRangeStart? CreateModelElement(DXO10W.CustomXmlConflictInsertionRangeStart? openXmlElement)
    => CreateModelElement<DMW.CustomXmlConflictInsertionRangeStart>(openXmlElement);

  public static DMW.CustomXmlConflictDeletionRangeStart? CreateModelElement(DXO10W.CustomXmlConflictDeletionRangeStart? openXmlElement)
    => CreateModelElement<DMW.CustomXmlConflictDeletionRangeStart>(openXmlElement);

  public static DMW.ConflictInsertion? CreateModelElement(DXO10W.ConflictInsertion? openXmlElement)
    => CreateModelElement<DMW.ConflictInsertion>(openXmlElement);

  public static DMW.ConflictDeletion? CreateModelElement(DXO10W.ConflictDeletion? openXmlElement)
    => CreateModelElement<DMW.ConflictDeletion>(openXmlElement);

  public static bool CompareModelElement(DXO10W.TrackChangeType? openXmlElement, DMW.TrackChangeType2? value, DiffList? diffs, string? objName)
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TrackChangeType2 value)
    where OpenXmlElementType : DXO10W.TrackChangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXO10W.TrackChangeType openXmlElement, DMW.TrackChangeType2 value)
  {
    SetAuthor(openXmlElement, value.Author);
    SetDate(openXmlElement, value.Date);
    SetId(openXmlElement, value.Id);
    return true;
  }
}
