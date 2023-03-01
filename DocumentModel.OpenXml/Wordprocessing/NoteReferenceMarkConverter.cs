namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// NoteReferenceMark element converter.
/// </summary>
public static class NoteReferenceMarkConverter
{
  public static DMW.NoteReferenceMark? CreateModelElement(DXW.FootnoteReferenceMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoteReferenceMark{ Type = DMW.NoteReferenceKind.Footnote };
      return value;
    }
    return null;
  }

  public static DMW.NoteReferenceMark? CreateModelElement(DXW.EndnoteReferenceMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoteReferenceMark{ Type = DMW.NoteReferenceKind.Endnote };
      return value;
    }
    return null;
  }

  public static DMW.NoteReferenceMark? CreateModelElement(DXW.AnnotationReferenceMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoteReferenceMark{ Type = DMW.NoteReferenceKind.Annotation };
      return value;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.NoteReferenceMark? value, DMW.NoteReferenceKind kind, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue<DMW.NoteReferenceKind, DMW.NoteReferenceKind>(kind, value.Type, diffs, objName, "Type"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static bool CompareModelElement(DXW.FootnoteReferenceMark? openXmlElement, DMW.NoteReferenceMark? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.NoteReferenceKind.Footnote, diffs, objName);

  public static bool CompareModelElement(DXW.EndnoteReferenceMark? openXmlElement, DMW.NoteReferenceMark? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.NoteReferenceKind.Endnote, diffs, objName);

  public static bool CompareModelElement(DXW.AnnotationReferenceMark? openXmlElement, DMW.NoteReferenceMark? value, DiffList? diffs, string? objName)
    => CheckModelElement(openXmlElement, value, DMW.NoteReferenceKind.Annotation, diffs, objName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.NoteReferenceMark value)
  {
    switch (value.Type)
    {
      case DMW.NoteReferenceKind.Footnote:
        return new DXW.FootnoteReferenceMark();
      case DMW.NoteReferenceKind.Endnote:
        return new DXW.EndnoteReferenceMark();
      case DMW.NoteReferenceKind.Annotation:
        return new DXW.AnnotationReferenceMark();
    }
    throw new InvalidOperationException($"Not supported type {value.Type} in NoteReferenceMarkConverter.CreateOpenXmlElement");
  }
}
