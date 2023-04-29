namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.Body"/> class from/to OpenXml converter.
/// </summary>
public static class BodyConverter
{
  #region Body content elements conversion
  public static DMW.IStoryContent? CreateBodyContentElement(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement is DXW.SectionProperties sectionProperties)
      return DMXW.SectionPropertiesConverter.CreateModelElement(sectionProperties);
    return BlockLevelElementsConverter.CreateBlockLevelElement(openXmlElement);
  }

  public static bool CompareBodyContentElement(DX.OpenXmlElement? openXmlElement, DM.IModelElement? model, DiffList? diffs = null, string? objName = null)
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

  #region Body conversion
  public static DMW.Body? CreateModelElement(DXW.Body? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.Body();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        CreateBodyContentElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.Body? openXmlElement, DMW.Body? model, DiffList? diffs, string? objName)
  {
     return ElementCollectionConverter<DMW.IStoryContent>.CompareOpenXmlElementCollection
        (openXmlElement, model, CompareBodyContentElement, diffs, objName);
  }

  public static DXW.Body CreateOpenXmlElement(DMW.Body value)
  {
    var openXmlElement = new DXW.Body();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.Body openXmlElement, DMW.Body value)
  {
    var bodyItems = value.ToArray();
    var elements = openXmlElement.Elements();
    var elementsEnumerator = elements.GetEnumerator();
    for (int i = 0; i < bodyItems.Count(); i++)
    {
      var item = bodyItems[i];
      OpenXmlElement? element = elementsEnumerator.MoveNext() ? elementsEnumerator.Current : null;
      if (element == null)
      {
        element = CreateOpenXmlElement(item);
        openXmlElement.AddChild(element);
      }
    }
  }
  #endregion
}
