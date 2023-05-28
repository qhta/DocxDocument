namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Fill Overlay Effect.
/// </summary>
public static class FillOverlayConverter
{
  /// <summary>
  /// Blend
  /// </summary>
  private static DMD.BlendMode? GetBlend(DXD.FillOverlay openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMD.BlendMode>(openXmlElement?.Blend?.Value);
  }
  
  private static bool CmpBlend(DXD.FillOverlay openXmlElement, DMD.BlendMode? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMD.BlendMode>(openXmlElement?.Blend?.Value, value, diffs, objName, propName);
  }
  
  private static void SetBlend(DXD.FillOverlay openXmlElement, DMD.BlendMode? value)
  {
    openXmlElement.Blend = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.BlendModeValues, DMD.BlendMode>(value);
  }
  
  public static DMD.FillOverlay? CreateModelElement(DXD.FillOverlay? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMD.FillOverlay();
      model.Blend = GetBlend(openXmlElement);
      model.Fill = FillConverter.CreateFillModel(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.FillOverlay? openXmlElement, DMD.FillOverlay? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpBlend(openXmlElement, model.Blend, diffs, objName, propName))
        ok = false;
      if (!FillConverter.CompareFillModel(openXmlElement, model.Fill, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.FillOverlay model)
    where OpenXmlElementType: DXD.FillOverlay, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.FillOverlay openXmlElement, DMD.FillOverlay model)
  {
    SetBlend(openXmlElement, model.Blend);
    FillConverter.UpdateOpenXmlElement(openXmlElement, model.Fill);
  }
}
