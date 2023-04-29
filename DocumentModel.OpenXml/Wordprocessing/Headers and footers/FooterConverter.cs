namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Footer"/> class from/to OpenXml converter.
/// </summary>
public static class FooterConverter
{
  #region Footer model conversion.
  public static DMW.Footer? CreateModelElement(DXW.Footer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Footer();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Footer? openXmlElement, DMW.Footer? model, DiffList? diffs, string? objName)
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Footer model)
    where OpenXmlElementType : DXW.Footer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Footer openXmlElement, DMW.Footer model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
