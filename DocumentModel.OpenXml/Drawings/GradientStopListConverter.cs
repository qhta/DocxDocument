namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DMD.GradientStopList"/> class from/to OpenXml converter.
/// </summary>
public static class GradientStopListConverter
{
  #region GradientStop conversion.
  private static DMD.GradientStop? GetGradientStop(DXD.GradientStop openXmlElement)
  {
    if (openXmlElement != null)
      return DMXD.GradientStopConverter.CreateModelElement(openXmlElement);
    return null;
  }
  
  private static bool CmpGradientStop(DXD.GradientStop openXmlElement, DMD.GradientStop? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.GradientStopConverter.CompareModelElement(openXmlElement, value, diffs, objName, propName);
  }
  
  private static DXD.GradientStop CreateGradientStop(DMD.GradientStop value)
  {
    return DMXD.GradientStopConverter.CreateOpenXmlElement(value);
  }

  private static bool UpdateGradientStop(DXD.GradientStop openXmlElement, DMD.GradientStop value)
  {
    return DMXD.GradientStopConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  
  public static DMD.GradientStopList? CreateModelElement(DXD.GradientStopList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.GradientStopList();
      ElementCollectionConverter2<DXD.GradientStop, DMD.GradientStop>.FillModelElementCollection(
        openXmlElement.Elements<DXD.GradientStop>(), model,
        GetGradientStop);
      return model;
    }
    return null;
  }
  #endregion

  #region GradientStopList model conversion.
  public static bool CompareModelElement(DXD.GradientStopList? openXmlElement, DMD.GradientStopList? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      return ElementCollectionConverter2<DXD.GradientStop, DMD.GradientStop>.CompareOpenXmlElementCollection(
        openXmlElement.Elements<DXD.GradientStop>(),
        model,
        CmpGradientStop,
        diffs, objName, propName);
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.GradientStopList model)
    where OpenXmlElementType: DXD.GradientStopList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXD.GradientStopList openXmlElement, DMD.GradientStopList model)
  {
    return ElementCollectionConverter2<DXD.GradientStop, DMD.GradientStop>.UpdateOpenXmlElementCollection(
      openXmlElement, model,
      CmpGradientStop,
      UpdateGradientStop,
      CreateGradientStop
      );  
  }
  #endregion
}
