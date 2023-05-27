namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.EffectStyleList"/> class from/to OpenXml converter.
/// </summary>
public static class EffectStyleListConverter
{
  public static DMD.EffectStyleList? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.EffectStyleList();
      ElementCollectionConverter2<DXD.EffectStyle, DMD.EffectStyle>
        .FillModelElementCollection(openXmlElement.Elements<DXD.EffectStyle>(), model,
        EffectStyleConverter.CreateModelElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMD.EffectStyleList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      return ElementCollectionConverter2<DXD.EffectStyle, DMD.EffectStyle>
        .CompareOpenXmlElementCollection(openXmlElement.Elements<DXD.EffectStyle>(), model,
        EffectStyleConverter.CompareModelElement, diffs, objName, propName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.EffectStyleList model)
    where OpenXmlElementType: DX.OpenXmlCompositeElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMD.EffectStyleList model)
  {
    return ElementCollectionConverter2<DXD.EffectStyle, DMD.EffectStyle>.UpdateOpenXmlElementCollection(openXmlElement, model,
        EffectStyleConverter.CompareModelElement,
        EffectStyleConverter.UpdateOpenXmlElement,
        EffectStyleConverter.CreateOpenXmlElement);
  }
}
