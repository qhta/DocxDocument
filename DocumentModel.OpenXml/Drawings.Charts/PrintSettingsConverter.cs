namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  /// Header and Footer.
  /// </summary>
  private static DMDC.HeaderFooter? GetHeaderFooter(DXDC.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.HeaderFooter>();
    if (element != null)
      return DMXDC.HeaderFooterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeaderFooter(DXDC.PrintSettings openXmlElement, DMDC.HeaderFooter? value, DiffList? diffs, string? objName)
  {
    return DMXDC.HeaderFooterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.HeaderFooter>(), value, diffs, objName);
  }
  
  private static void SetHeaderFooter(DXDC.PrintSettings openXmlElement, DMDC.HeaderFooter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.HeaderFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.HeaderFooterConverter.CreateOpenXmlElement<DXDC.HeaderFooter>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Page Margins.
  /// </summary>
  private static DMDC.PageMargins? GetPageMargins(DXDC.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PageMargins>();
    if (element != null)
      return DMXDC.PageMarginsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageMargins(DXDC.PrintSettings openXmlElement, DMDC.PageMargins? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PageMarginsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PageMargins>(), value, diffs, objName);
  }
  
  private static void SetPageMargins(DXDC.PrintSettings openXmlElement, DMDC.PageMargins? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PageMargins>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PageMarginsConverter.CreateOpenXmlElement<DXDC.PageMargins>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Page Setup.
  /// </summary>
  private static DMDC.PageSetup? GetPageSetup(DXDC.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.PageSetup>();
    if (element != null)
      return DMXDC.PageSetupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageSetup(DXDC.PrintSettings openXmlElement, DMDC.PageSetup? value, DiffList? diffs, string? objName)
  {
    return DMXDC.PageSetupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.PageSetup>(), value, diffs, objName);
  }
  
  private static void SetPageSetup(DXDC.PrintSettings openXmlElement, DMDC.PageSetup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.PageSetup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.PageSetupConverter.CreateOpenXmlElement<DXDC.PageSetup>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Legacy Drawing for Headers and Footers.
  /// </summary>
  private static DMDC.RelationshipIdType? GetLegacyDrawingHeaderFooter(DXDC.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDC.LegacyDrawingHeaderFooter>();
    if (element != null)
      return DMXDC.RelationshipIdTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLegacyDrawingHeaderFooter(DXDC.PrintSettings openXmlElement, DMDC.RelationshipIdType? value, DiffList? diffs, string? objName)
  {
    return DMXDC.RelationshipIdTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDC.LegacyDrawingHeaderFooter>(), value, diffs, objName);
  }
  
  private static void SetLegacyDrawingHeaderFooter(DXDC.PrintSettings openXmlElement, DMDC.RelationshipIdType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDC.LegacyDrawingHeaderFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDC.RelationshipIdTypeConverter.CreateOpenXmlElement<DXDC.LegacyDrawingHeaderFooter>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PrintSettings? CreateModelElement(DXDC.PrintSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PrintSettings();
      value.HeaderFooter = GetHeaderFooter(openXmlElement);
      value.PageMargins = GetPageMargins(openXmlElement);
      value.PageSetup = GetPageSetup(openXmlElement);
      value.LegacyDrawingHeaderFooter = GetLegacyDrawingHeaderFooter(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.PrintSettings? openXmlElement, DMDC.PrintSettings? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHeaderFooter(openXmlElement, value.HeaderFooter, diffs, objName))
        ok = false;
      if (!CmpPageMargins(openXmlElement, value.PageMargins, diffs, objName))
        ok = false;
      if (!CmpPageSetup(openXmlElement, value.PageSetup, diffs, objName))
        ok = false;
      if (!CmpLegacyDrawingHeaderFooter(openXmlElement, value.LegacyDrawingHeaderFooter, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.PrintSettings value)
    where OpenXmlElementType: DXDC.PrintSettings, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.PrintSettings openXmlElement, DMDC.PrintSettings value)
  {
    SetHeaderFooter(openXmlElement, value?.HeaderFooter);
    SetPageMargins(openXmlElement, value?.PageMargins);
    SetPageSetup(openXmlElement, value?.PageSetup);
    SetLegacyDrawingHeaderFooter(openXmlElement, value?.LegacyDrawingHeaderFooter);
  }
}
