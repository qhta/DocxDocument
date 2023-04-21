namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  /// SharedQatControls.
  /// </summary>
  private static DMUI.SharedQatControls? GetSharedQatControls(DXOCUI.QuickAccessToolbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.SharedQatControls>();
    if (element != null)
      return DMXUI.SharedQatControlsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSharedQatControls(DXOCUI.QuickAccessToolbar openXmlElement, DMUI.SharedQatControls? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SharedQatControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.SharedQatControls>(), value, diffs, objName);
  }
  
  private static void SetSharedQatControls(DXOCUI.QuickAccessToolbar openXmlElement, DMUI.SharedQatControls? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.SharedQatControls>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SharedQatControlsConverter.CreateOpenXmlElement<DXOCUI.SharedQatControls>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DocumentSpecificQuickAccessToolbarControls.
  /// </summary>
  private static DMUI.DocumentSpecificQuickAccessToolbarControls? GetDocumentSpecificQuickAccessToolbarControls(DXOCUI.QuickAccessToolbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.DocumentSpecificQuickAccessToolbarControls>();
    if (element != null)
      return DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentSpecificQuickAccessToolbarControls(DXOCUI.QuickAccessToolbar openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.DocumentSpecificQuickAccessToolbarControls>(), value, diffs, objName);
  }
  
  private static void SetDocumentSpecificQuickAccessToolbarControls(DXOCUI.QuickAccessToolbar openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.DocumentSpecificQuickAccessToolbarControls>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CreateOpenXmlElement<DXOCUI.DocumentSpecificQuickAccessToolbarControls>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.QuickAccessToolbar? CreateModelElement(DXOCUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.QuickAccessToolbar();
      value.SharedQatControls = GetSharedQatControls(openXmlElement);
      value.DocumentSpecificQuickAccessToolbarControls = GetDocumentSpecificQuickAccessToolbarControls(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.QuickAccessToolbar? openXmlElement, DMUI.QuickAccessToolbar? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.QuickAccessToolbar value)
    where OpenXmlElementType: DXOCUI.QuickAccessToolbar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.QuickAccessToolbar openXmlElement, DMUI.QuickAccessToolbar value)
  {
    SetSharedQatControls(openXmlElement, value?.SharedQatControls);
    SetDocumentSpecificQuickAccessToolbarControls(openXmlElement, value?.DocumentSpecificQuickAccessToolbarControls);
  }
}
