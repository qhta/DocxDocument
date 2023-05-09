namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.FootnoteEndnoteSeparatorReferenceType"/> from/to OpenXml converter.
/// </summary>
public static class FootnoteEndnoteSeparatorReferenceTypeConverter
{
  #region Footnote/Endnote ID
  private static Int32? GetId(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement)
  {
    return (Int32?)openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "AnnotationId", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  #endregion

  #region FootnoteEndnoteSeparatorReferenceType model conversion.
  public static ElementType? CreateModelElement<ElementType>(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement)
    where ElementType : DMW.FootnoteEndnoteSeparatorReferenceType, new()
  {
    if (openXmlElement != null)
    {
      var model = new ElementType();
      model.Id = GetId(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement, DMW.FootnoteEndnoteSeparatorReferenceType? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, model.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.FootnoteEndnoteSeparatorReferenceType model)
    where OpenXmlElementType: DXW.FootnoteEndnoteSeparatorReferenceType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.FootnoteEndnoteSeparatorReferenceType openXmlElement, DMW.FootnoteEndnoteSeparatorReferenceType model)
  {
    SetId(openXmlElement, model?.Id);
  }
  #endregion
}
