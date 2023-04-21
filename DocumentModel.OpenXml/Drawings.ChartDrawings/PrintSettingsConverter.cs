namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  private static DMDCDs.HeaderFooter? GetHeaderFooter(DXO16DCD.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.HeaderFooter>();
    if (element != null)
      return DMXDCDs.HeaderFooterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeaderFooter(DXO16DCD.PrintSettings openXmlElement, DMDCDs.HeaderFooter? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.HeaderFooterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.HeaderFooter>(), value, diffs, objName);
  }
  
  private static void SetHeaderFooter(DXO16DCD.PrintSettings openXmlElement, DMDCDs.HeaderFooter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.HeaderFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.HeaderFooterConverter.CreateOpenXmlElement<DXO16DCD.HeaderFooter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  private static DMDCDs.PageMargins? GetPageMargins(DXO16DCD.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.PageMargins>();
    if (element != null)
      return DMXDCDs.PageMarginsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageMargins(DXO16DCD.PrintSettings openXmlElement, DMDCDs.PageMargins? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.PageMarginsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.PageMargins>(), value, diffs, objName);
  }
  
  private static void SetPageMargins(DXO16DCD.PrintSettings openXmlElement, DMDCDs.PageMargins? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.PageMargins>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.PageMarginsConverter.CreateOpenXmlElement<DXO16DCD.PageMargins>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  private static DMDCDs.PageSetup? GetPageSetup(DXO16DCD.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.PageSetup>();
    if (element != null)
      return DMXDCDs.PageSetupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageSetup(DXO16DCD.PrintSettings openXmlElement, DMDCDs.PageSetup? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.PageSetupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.PageSetup>(), value, diffs, objName);
  }
  
  private static void SetPageSetup(DXO16DCD.PrintSettings openXmlElement, DMDCDs.PageSetup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.PageSetup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.PageSetupConverter.CreateOpenXmlElement<DXO16DCD.PageSetup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PrintSettings? CreateModelElement(DXO16DCD.PrintSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.PrintSettings();
      value.HeaderFooter = GetHeaderFooter(openXmlElement);
      value.PageMargins = GetPageMargins(openXmlElement);
      value.PageSetup = GetPageSetup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.PrintSettings? openXmlElement, DMDCDs.PrintSettings? value, DiffList? diffs, string? objName)
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
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.PrintSettings value)
    where OpenXmlElementType: DXO16DCD.PrintSettings, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.PrintSettings openXmlElement, DMDCDs.PrintSettings value)
  {
    SetHeaderFooter(openXmlElement, value?.HeaderFooter);
    SetPageMargins(openXmlElement, value?.PageMargins);
    SetPageSetup(openXmlElement, value?.PageSetup);
  }
}
