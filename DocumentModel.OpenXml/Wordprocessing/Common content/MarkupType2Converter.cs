namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupType Class.
/// </summary>
public static class MarkupType2Converter
{
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXO10W.MarkupType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10W.MarkupType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10W.MarkupType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static ElementType? CreateModelElement<ElementType>(DXO10W.MarkupType? openXmlElement)
    where ElementType: DMW.MarkupType2, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static DMW.CustomXmlConflictInsertionRangeEnd? CreateModelElement(DXO10W.CustomXmlConflictInsertionRangeEnd? openXmlElement)
    => CreateModelElement<DMW.CustomXmlConflictInsertionRangeEnd>(openXmlElement);

  public static DMW.CustomXmlConflictDeletionRangeEnd? CreateModelElement(DXO10W.CustomXmlConflictDeletionRangeEnd? openXmlElement)
    => CreateModelElement<DMW.CustomXmlConflictDeletionRangeEnd>(openXmlElement);

  public static bool CompareModelElement(DXO10W.MarkupType? openXmlElement, DMW.MarkupType2? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MarkupType2 value)
    where OpenXmlElementType: DXO10W.MarkupType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXO10W.MarkupType openXmlElement, DMW.MarkupType2 value)
  {
    SetId(openXmlElement, value.Id);
    return true;
  }
}
