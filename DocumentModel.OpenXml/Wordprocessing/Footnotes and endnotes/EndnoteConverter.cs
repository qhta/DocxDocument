namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Endnote"/> class from/to OpenXml converter.
/// </summary>
public static class EndnoteConverter
{
  #region Endnote model conversion.
  public static DMW.Endnote? CreateModelElement(DXW.Endnote? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Endnote();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Endnote? openXmlElement, DMW.Endnote? model, DiffList? diffs, string? objName)
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Endnote model)
    where OpenXmlElementType : DXW.Endnote, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Endnote openXmlElement, DMW.Endnote model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
