namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.FillStyleList"/> class from/to OpenXml converter.
/// </summary>
public static class FillStyleListConverter
{
 
  public static DMD.FillStyleList? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.FillStyleList();
      ElementCollectionConverter<DMD.Fill>.FillModelElementCollection(openXmlElement.Elements(), model,
        FillConverter.CreateFill);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMD.FillStyleList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      return ElementCollectionConverter<DMD.Fill>.CompareOpenXmlElementCollection(openXmlElement.Elements(), model,
        FillConverter.CompareFill, diffs, objName, propName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.FillStyleList model)
    where OpenXmlElementType: DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMD.FillStyleList model)
  {
    return ElementCollectionConverter<DMD.Fill>.UpdateOpenXmlElementCollection(openXmlElement, model,
        FillConverter.CompareFill,
        FillConverter.UpdateOpenXmlFillElement,
        FillConverter.CreateOpenXmlFillElement);
  }
}
