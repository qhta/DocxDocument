namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Endnotes"/> class from/to OpenXml converter.
/// </summary>
public static class EndnotesConverter
{
  #region item conversion
  private static DM.IModelElement? GetEndnote(DX.OpenXmlElement openXmlElement)
  {
    return DMXW.EndnoteConverter.CreateModelElement(openXmlElement as DXW.Endnote);
  }

  private static bool CmpEndnote(DX.OpenXmlElement? openXmlElement, DM.IModelElement? value, DiffList? diffs = null, string? objName = null)
  {
    return DMXW.EndnoteConverter.CompareModelElement(openXmlElement as DXW.Endnote, value as DMW.Endnote, diffs, objName);
  }

  private static bool UpdateEndnote(DX.OpenXmlElement openXmlElement, DM.IModelElement model)
  {
    if (openXmlElement is DXW.Endnote endnoteElement && model is DMW.Endnote endnoteModel)
      return DMXW.EndnoteConverter.UpdateOpenXmlElement(endnoteElement, endnoteModel);
    return false;
  }

  private static OpenXmlElement CreateEndnoteElement(DM.IModelElement model)
  {
    if (model is DMW.Endnote modelElement)
    {
     return DMXW.EndnoteConverter.CreateOpenXmlElement(modelElement);
    }
    return null!;
  }
  #endregion

  #region model conversion
  public static DMW.Endnotes? CreateModelElement(DXW.Endnotes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Endnotes();
      ElementCollectionConverter<DMW.Endnote>.FillModelElementCollection(
      openXmlElement.Elements<DXW.Endnote>(), model, GetEndnote);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Endnotes? openXmlElement, DMW.Endnotes? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.Endnote>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CmpEndnote, diffs, objName))
        return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Endnotes model)
    where OpenXmlElementType : DXW.Endnotes, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Endnotes openXmlElement, DMW.Endnotes model)
  {
    return ElementCollectionConverter<DMW.Endnote>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CmpEndnote,
      UpdateEndnote,
      CreateEndnoteElement);
  }
  #endregion
}
