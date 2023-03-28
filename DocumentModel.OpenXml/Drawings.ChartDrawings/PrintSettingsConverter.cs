namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the PrintSettings Class.
/// </summary>
public static class PrintSettingsConverter
{
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  private static DMDrawsChartDraws.HeaderFooter? GetHeaderFooter(DXO2016DrawChartDraw.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.HeaderFooter>();
    if (element != null)
      return DMXDrawsChartDraws.HeaderFooterConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeaderFooter(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.HeaderFooter? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.HeaderFooterConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.HeaderFooter>(), value, diffs, objName);
  }
  
  private static void SetHeaderFooter(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.HeaderFooter? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.HeaderFooter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.HeaderFooterConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.HeaderFooter>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PageMargins.
  /// </summary>
  private static DMDrawsChartDraws.PageMargins? GetPageMargins(DXO2016DrawChartDraw.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PageMargins>();
    if (element != null)
      return DMXDrawsChartDraws.PageMarginsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageMargins(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.PageMargins? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.PageMarginsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PageMargins>(), value, diffs, objName);
  }
  
  private static void SetPageMargins(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.PageMargins? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PageMargins>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.PageMarginsConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.PageMargins>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PageSetup.
  /// </summary>
  private static DMDrawsChartDraws.PageSetup? GetPageSetup(DXO2016DrawChartDraw.PrintSettings openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PageSetup>();
    if (element != null)
      return DMXDrawsChartDraws.PageSetupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPageSetup(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.PageSetup? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.PageSetupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PageSetup>(), value, diffs, objName);
  }
  
  private static void SetPageSetup(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.PageSetup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.PageSetup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.PageSetupConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.PageSetup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.PrintSettings? CreateModelElement(DXO2016DrawChartDraw.PrintSettings? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.PrintSettings? openXmlElement, DMDrawsChartDraws.PrintSettings? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PrintSettings value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PrintSettings, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.PrintSettings openXmlElement, DMDrawsChartDraws.PrintSettings value)
  {
    SetHeaderFooter(openXmlElement, value?.HeaderFooter);
    SetPageMargins(openXmlElement, value?.PageMargins);
    SetPageSetup(openXmlElement, value?.PageSetup);
  }
}
