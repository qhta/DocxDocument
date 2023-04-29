namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.BodyType"/> class from/to OpenXml converter.
/// </summary>
public static class BodyTypeConverter
{
  #region BodyType content elements conversion
  public static DMW.IStoryContent? CreateBodyTypeContentElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateModelElement(sectionProperties);
    return BlockLevelElementsConverter.CreateBlockLevelElement(openXmlElement);
  }

  public static bool CompareBodyTypeContentElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
  {
    if (openXmlElement is DXW.SectionProperties sectionProperties && model is DMW.SectionProperties sectionPropertiesModel)
      return DMXW.SectionPropertiesConverter.CompareModelElement(sectionProperties, sectionPropertiesModel, diffs, objName);
    return BlockLevelElementsConverter.CompareBlockLevelElement(openXmlElement, model, diffs, objName);
  }
  public static OpenXmlElement CreateOpenXmlElement(DMW.IStoryContent model)
  {
    if (model is DMW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateOpenXmlElement(sectionProperties);
    return BlockLevelElementsConverter.CreateOpenXmlElement(model);
  }
  #endregion

  #region BodyType conversion
  public static ElementType? CreateModelElement<ElementType>(DXW.BodyType? openXmlElement)
    where ElementType : DMW.BodyType, new()
  {
    if (openXmlElement != null)
    {
      var model = new ElementType();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        CreateBodyTypeContentElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.BodyType? openXmlElement, DMW.BodyType? model, DiffList? diffs, string? objName)
  {
     return ElementCollectionConverter<DMW.IStoryContent>.CompareOpenXmlElementCollection
        (openXmlElement, model, CompareBodyTypeContentElement, diffs, objName);
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.BodyType model)
    where OpenXmlElementType: DXW.BodyType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.BodyType openXmlElement, DMW.BodyType model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
