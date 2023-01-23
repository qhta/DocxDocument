namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  /// SharedQatControls.
  /// </summary>
  private static DMUI.SharedQatControls? GetSharedQatControls(DXOCustUI.QuickAccessToolbar openXmlElement)
  {
    return DMXUI.SharedQatControlsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.SharedQatControls>());
  }
  
  private static bool CmpSharedQatControls(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.SharedQatControls? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SharedQatControlsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.SharedQatControls>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSharedQatControls(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.SharedQatControls? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.SharedQatControls>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SharedQatControlsConverter.CreateOpenXmlElement<DXOCustUI.SharedQatControls>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  private static DMUI.DocumentSpecificQuickAccessToolbarControls? GetDocumentSpecificQuickAccessToolbarControls(DXOCustUI.QuickAccessToolbar openXmlElement)
  {
    return DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.DocumentSpecificQuickAccessToolbarControls>());
  }
  
  private static bool CmpDocumentSpecificQuickAccessToolbarControls(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.DocumentSpecificQuickAccessToolbarControls>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocumentSpecificQuickAccessToolbarControls(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.DocumentSpecificQuickAccessToolbarControls>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CreateOpenXmlElement<DXOCustUI.DocumentSpecificQuickAccessToolbarControls>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.QuickAccessToolbar? CreateModelElement(DXOCustUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.QuickAccessToolbar();
      value.SharedQatControls = GetSharedQatControls(openXmlElement);
      value.DocumentSpecificQuickAccessToolbarControls = GetDocumentSpecificQuickAccessToolbarControls(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.QuickAccessToolbar? openXmlElement, DMUI.QuickAccessToolbar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSharedQatControls(openXmlElement, value.SharedQatControls, diffs, objName))
        ok = false;
      if (!CmpDocumentSpecificQuickAccessToolbarControls(openXmlElement, value.DocumentSpecificQuickAccessToolbarControls, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.QuickAccessToolbar? value)
    where OpenXmlElementType: DXOCustUI.QuickAccessToolbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSharedQatControls(openXmlElement, value?.SharedQatControls);
      SetDocumentSpecificQuickAccessToolbarControls(openXmlElement, value?.DocumentSpecificQuickAccessToolbarControls);
      return openXmlElement;
    }
    return default;
  }
}
