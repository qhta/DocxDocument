namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.HeaderFooter"/> class from/to OpenXml converter.
/// </summary>
public static class HeaderFooterConverter
{
  #region Header model conversion.
  public static ElementType? CreateModelElement<ElementType>(DX.TypedOpenXmlPartRootElement? openXmlElement)
    where ElementType : DMW.HeaderFooter, new()
  {
    if (openXmlElement != null)
    {
      var model = new ElementType();
      ElementCollectionConverter<DMW.IStoryContent>.FillModelElementCollection(openXmlElement, model,
        BlockLevelElementsConverter.CreateBlockLevelElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DX.TypedOpenXmlPartRootElement? openXmlElement, DMW.HeaderFooter? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMW.IStoryContent>.CompareOpenXmlElementCollection
         (openXmlElement, model,
         BlockLevelElementsConverter.CompareBlockLevelElement, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.HeaderFooter model)
    where OpenXmlElementType : DX.TypedOpenXmlPartRootElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DX.TypedOpenXmlPartRootElement openXmlElement, DMW.HeaderFooter model)
  {
    return ElementCollectionConverter<DMW.IStoryContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
      BlockLevelElementsConverter.CompareBlockLevelElement,
      BlockLevelElementsConverter.UpdateOpenXmlElement,
      BlockLevelElementsConverter.CreateOpenXmlElement);
  }
  #endregion
}
