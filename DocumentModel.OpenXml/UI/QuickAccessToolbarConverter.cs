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
    var element = openXmlElement?.GetFirstChild<DXOCustUI.SharedQatControls>();
    if (element != null)
      return DMXUI.SharedQatControlsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSharedQatControls(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.SharedQatControls? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SharedQatControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.SharedQatControls>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXOCustUI.DocumentSpecificQuickAccessToolbarControls>();
    if (element != null)
      return DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentSpecificQuickAccessToolbarControls(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DocumentSpecificQuickAccessToolbarControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.DocumentSpecificQuickAccessToolbarControls>(), value, diffs, objName);
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
  
  public static DocumentModel.UI.QuickAccessToolbar? CreateModelElement(DXOCustUI.QuickAccessToolbar? openXmlElement)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.QuickAccessToolbar value)
    where OpenXmlElementType: DXOCustUI.QuickAccessToolbar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.QuickAccessToolbar openXmlElement, DMUI.QuickAccessToolbar value)
  {
    SetSharedQatControls(openXmlElement, value?.SharedQatControls);
    SetDocumentSpecificQuickAccessToolbarControls(openXmlElement, value?.DocumentSpecificQuickAccessToolbarControls);
  }
}
