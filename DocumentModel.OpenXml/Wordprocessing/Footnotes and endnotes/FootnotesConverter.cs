namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Footnotes"/> class from/to OpenXml converter.
/// </summary>
public static class FootnotesConverter
{
  #region item conversion
  private static DM.IModelElement? GetFootnote(DX.OpenXmlElement openXmlElement)
  {
    return DMXW.FootnoteConverter.CreateModelElement(openXmlElement as DXW.Footnote);
  }

  private static bool CmpFootnote(DX.OpenXmlElement? openXmlElement, DM.IModelElement? value, 
    DiffList? diffs = null, string? objName = null)
  {
    return DMXW.FootnoteConverter.CompareModelElement(openXmlElement as DXW.Footnote, value as DMW.Footnote, diffs, objName);
  }

  private static bool UpdateFootnote(DX.OpenXmlElement openXmlElement, DM.IModelElement model)
  {
    if (openXmlElement is DXW.Footnote endnoteElement && model is DMW.Footnote endnoteModel)
      return DMXW.FootnoteConverter.UpdateOpenXmlElement(endnoteElement, endnoteModel);
    return false;
  }

  private static OpenXmlElement CreateFootnoteElement(DM.IModelElement model)
  {
    if (model is DMW.Footnote modelElement)
    {
     return DMXW.FootnoteConverter.CreateOpenXmlElement(modelElement);
    }
    return null!;
  }
  #endregion

  #region model conversion
  public static DMW.Footnotes? CreateModelElement(DXW.Footnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Footnotes();
      ElementCollectionConverter<DMW.Footnote>.FillModelElementCollection(
      openXmlElement.Elements<DXW.Footnote>(), model, GetFootnote);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Footnotes? openXmlElement, DMW.Footnotes? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.Footnote>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CmpFootnote, diffs, objName))
        return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Footnotes model)
    where OpenXmlElementType : DXW.Footnotes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Footnotes openXmlElement, DMW.Footnotes model)
  {
    return ElementCollectionConverter<DMW.Footnote>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CmpFootnote,
      UpdateFootnote,
      CreateFootnoteElement);
  }
  #endregion
}
