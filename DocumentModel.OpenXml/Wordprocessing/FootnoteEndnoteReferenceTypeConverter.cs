namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteEndnoteReferenceType Class.
/// </summary>
public static class FootnoteEndnoteReferenceTypeConverter
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  private static Boolean? GetCustomMarkFollows(DXW.FootnoteEndnoteReferenceType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.CustomMarkFollows);
  }
  
  private static bool CmpCustomMarkFollows(DXW.FootnoteEndnoteReferenceType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.CustomMarkFollows, value, diffs, objName, "CustomMarkFollows");
  }
  
  private static void SetCustomMarkFollows(DXW.FootnoteEndnoteReferenceType openXmlElement, Boolean? value)
  {
    openXmlElement.CustomMarkFollows = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  private static Int64? GetId(DXW.FootnoteEndnoteReferenceType openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.FootnoteEndnoteReferenceType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.FootnoteEndnoteReferenceType openXmlElement, Int64? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DMW.NoteReference? CreateModelElement(DXW.FootnoteEndnoteReferenceType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoteReference();
      value.CustomMarkFollows = GetCustomMarkFollows(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteEndnoteReferenceType? openXmlElement, DMW.NoteReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomMarkFollows(openXmlElement, value.CustomMarkFollows, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NoteReference value)
    where OpenXmlElementType: DXW.FootnoteEndnoteReferenceType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.NoteReference value)
  {
    DXW.FootnoteEndnoteReferenceType openXmlElement; 
    switch (value.Kind)
    {
      case DMW.NoteReferenceKind.Footnote:
        openXmlElement = CreateOpenXmlElement<DXW.FootnoteReference>(value);
        break;
      case DMW.NoteReferenceKind.Endnote:
        openXmlElement = CreateOpenXmlElement<DXW.EndnoteReference>(value);
        break;
      default:
        throw new InvalidOperationException($"Not supported kind {value.Kind} in FootnoteEndNoteReferenceTypeConverter.CreateOpenXmlParagraphElement");
    }
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.FootnoteEndnoteReferenceType openXmlElement, DMW.NoteReference value)
  {
    SetCustomMarkFollows(openXmlElement, value?.CustomMarkFollows);
    SetId(openXmlElement, value?.Id);
    return true;
  }
}
