namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Header"/> class from/to OpenXml converter.
/// </summary>
public static class HeaderConverter
{
  #region Header model conversion.
  public static DMW.Header? CreateModelElement(DXW.Header? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Header();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Header? openXmlElement, DMW.Header? model, DiffList? diffs, string? objName)
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Header model)
    where OpenXmlElementType : DXW.Header, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.Header openXmlElement, DMW.Header model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
