namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.TextBoxContent"/> class from/to OpenXml converter.
/// </summary>
public static class TextBoxContentConverter
{
  public static DMW.TextBoxContent? CreateModelElement(DXW.TextBoxContent? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TextBoxContent();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TextBoxContent? openXmlElement, DMW.TextBoxContent? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.IStoryContent>.CompareOpenXmlElementCollection
         (openXmlElement, model,
         BlockLevelElementsConverter.CompareBlockLevelElement, diffs, objName, propName))
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TextBoxContent model)
    where OpenXmlElementType: DXW.TextBoxContent, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.TextBoxContent openXmlElement, DMW.TextBoxContent model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
}
