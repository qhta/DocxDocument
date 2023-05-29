namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.LineStyleList"/> class from/to OpenXml converter.
/// </summary>
public static class LineStyleListConverter
{
  public static DMD.LineStyleList? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.LineStyleList();
      ElementCollectionConverter2<DXD.Outline, DMD.LineProperties>
        .FillModelElementCollection(openXmlElement.Elements<DXD.Outline>(), model,
        LinePropertiesConverter.CreateModelElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMD.LineStyleList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      return ElementCollectionConverter2<DXD.Outline, DMD.LineProperties>
        .CompareOpenXmlElementCollection(openXmlElement.Elements<DXD.Outline>(), model,
        LinePropertiesConverter.CompareModelElement, diffs, objName, propName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXD.LineStyleList CreateOpenXmlElement(DMD.LineStyleList model)
  {
    var openXmlElement = new DXD.LineStyleList();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXD.LineStyleList openXmlElement, DMD.LineStyleList model)
  {
    return ElementCollectionConverter2<DXD.Outline, DMD.LineProperties>.UpdateOpenXmlElementCollection(openXmlElement, model,
        LinePropertiesConverter.CompareModelElement,
        LinePropertiesConverter.UpdateOpenXmlElement,
        LinePropertiesConverter.CreateOpenXmlElement<DXD.Outline>);
  }
}
