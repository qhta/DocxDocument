namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.HyperlinkRuby"/> class from/to OpenXml converter.
/// </summary>
public static class HyperlinkRubyConverter
{
  #region TargetFrame conversion.
  private static String? GetTargetFrame(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.TargetFrame);
  }
  
  private static bool CmpTargetFrame(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.TargetFrame, value, diffs, objName, "TargetFrame");
  }
  
  private static void SetTargetFrame(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.TargetFrame = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Tooltip conversion.
  private static String? GetTooltip(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tooltip);
  }
  
  private static bool CmpTooltip(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tooltip, value, diffs, objName, "Tooltip");
  }
  
  private static void SetTooltip(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.Tooltip = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region DocLocation conversion.
  private static String? GetDocLocation(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.DocLocation);
  }
  
  private static bool CmpDocLocation(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.DocLocation, value, diffs, objName, "DocLocation");
  }
  
  private static void SetDocLocation(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.DocLocation = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region History conversion.
  private static Boolean? GetHistory(DXW.HyperlinkRuby openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.History);
  }
  
  private static bool CmpHistory(DXW.HyperlinkRuby openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.History, value, diffs, objName, "History");
  }
  
  private static void SetHistory(DXW.HyperlinkRuby openXmlElement, Boolean? value)
  {
    openXmlElement.History = BooleanValueConverter.CreateOnOffValue(value);
  }
  #endregion

  #region Anchor conversion.
  private static String? GetAnchor(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Anchor);
  }
  
  private static bool CmpAnchor(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Anchor, value, diffs, objName, "Anchor");
  }
  
  private static void SetAnchor(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.Anchor = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Id conversion.
  private static String? GetId(DXW.HyperlinkRuby openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.HyperlinkRuby openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.HyperlinkRuby openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region HyperlinkRuby model conversion
  public static DMW.HyperlinkRuby? CreateModelElement(DXW.HyperlinkRuby? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.HyperlinkRuby();
      model.TargetFrame = GetTargetFrame(openXmlElement);
      model.Tooltip = GetTooltip(openXmlElement);
      model.DocLocation = GetDocLocation(openXmlElement);
      model.History = GetHistory(openXmlElement);
      model.Anchor = GetAnchor(openXmlElement);
      model.Id = GetId(openXmlElement);
      ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
        openXmlElement, model,
        RubyContentConverter.CreateRubyContentModelElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.HyperlinkRuby? openXmlElement, DMW.HyperlinkRuby? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpTargetFrame(openXmlElement, model.TargetFrame, diffs, objName))
        ok = false;
      if (!CmpTooltip(openXmlElement, model.Tooltip, diffs, objName))
        ok = false;
      if (!CmpDocLocation(openXmlElement, model.DocLocation, diffs, objName))
        ok = false;
      if (!CmpHistory(openXmlElement, model.History, diffs, objName))
        ok = false;
      if (!CmpAnchor(openXmlElement, model.Anchor, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, model.Id, diffs, objName))
        ok = false;
      if (!ElementCollectionConverter<DM.IModelElement>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        RubyContentConverter.CompareRubyContentElement, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static DXW.HyperlinkRuby CreateOpenXmlElement(DMW.HyperlinkRuby model)
  {
    var openXmlElement = new DXW.HyperlinkRuby();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.HyperlinkRuby openXmlElement, DMW.HyperlinkRuby model)
  {
    SetTargetFrame(openXmlElement, model.TargetFrame);
    SetTooltip(openXmlElement, model.Tooltip);
    SetDocLocation(openXmlElement, model.DocLocation);
    SetHistory(openXmlElement, model.History);
    SetAnchor(openXmlElement, model.Anchor);
    SetId(openXmlElement, model.Id);
    return ElementCollectionConverter<DM.IModelElement>.UpdateOpenXmlElementCollection(openXmlElement, model,
      RubyContentConverter.CompareRubyContentElement,
      RubyContentConverter.UpdateRubyContentOpenXmlElement,
      RubyContentConverter.CreateRubyContentOpenXmlElement);
  }
  #endregion
}
