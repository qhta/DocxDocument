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
      var model = new DMW.NoteReferenceMark{ Type = DMW.NoteReferenceKind.Footnote };
      return model;
    }
    return null;
  }

  public static DMW.NoteReferenceMark? CreateModelElement(DXW.EndnoteReferenceMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NoteReferenceMark{ Type = DMW.NoteReferenceKind.Endnote };
      return model;
    }
    return null;
  }

  public static DMW.NoteReferenceMark? CreateModelElement(DXW.AnnotationReferenceMark? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NoteReferenceMark{ Type = DMW.NoteReferenceKind.Annotation };
      return model;
    }
    return null;
  }

  private static bool CheckModelElement(DX.OpenXmlElement? openXmlElement, DMW.NoteReferenceMark? model, DMW.NoteReferenceKind kind, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!EnumValueConverter.CmpValue(kind, model.Type, diffs, objName, "Type"))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static bool CompareModelElement(DXW.FootnoteReferenceMark? openXmlElement, DMW.NoteReferenceMark? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.NoteReferenceKind.Footnote, diffs, objName, propName);

  public static bool CompareModelElement(DXW.EndnoteReferenceMark? openXmlElement, DMW.NoteReferenceMark? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.NoteReferenceKind.Endnote, diffs, objName, propName);

  public static bool CompareModelElement(DXW.AnnotationReferenceMark? openXmlElement, DMW.NoteReferenceMark? model, DiffList? diffs = null, string? objName = null, string? propName = null)
    => CheckModelElement(openXmlElement, model, DMW.NoteReferenceKind.Annotation, diffs, objName, propName);

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.NoteReferenceMark model)
  {
    switch (model.Type)
    {
      case DMW.NoteReferenceKind.Footnote:
        return new DXW.FootnoteReferenceMark();
      case DMW.NoteReferenceKind.Endnote:
        return new DXW.EndnoteReferenceMark();
      case DMW.NoteReferenceKind.Annotation:
        return new DXW.AnnotationReferenceMark();
    }
    throw new InvalidOperationException($"Not supported type {model.Type} in NoteReferenceMarkConverter.CreateOpenXmlParagraphContent");
  }

  public static bool UpdateOpenXmlElement(DXW.FootnoteReferenceMark? openXmlElement, DMW.NoteReferenceMark? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.EndnoteReferenceMark? openXmlElement, DMW.NoteReferenceMark? model)
    => true;

  public static bool UpdateOpenXmlElement(DXW.AnnotationReferenceMark? openXmlElement, DMW.NoteReferenceMark? model)
    => true;

}
