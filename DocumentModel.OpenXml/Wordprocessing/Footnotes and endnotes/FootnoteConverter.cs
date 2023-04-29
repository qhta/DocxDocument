namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Footnote"/> class from/to OpenXml converter.
/// </summary>
public static class FootnoteConverter
{
  #region Footnote model conversion.
  public static DMW.Footnote? CreateModelElement(DXW.Footnote? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Footnote();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Footnote? openXmlElement, DMW.Footnote? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.IStoryContent>.CompareOpenXmlElementCollection
         (openXmlElement, model,
         BlockLevelElementsConverter.CompareBlockLevelElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Footnote model)
    where OpenXmlElementType : DXW.Footnote, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Footnote openXmlElement, DMW.Footnote model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
