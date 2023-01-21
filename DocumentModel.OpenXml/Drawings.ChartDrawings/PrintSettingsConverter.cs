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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.HeaderFooter>();
    if (itemElement != null)
      return DMXDrawsChartDraws.HeaderFooterConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PageMargins>();
    if (itemElement != null)
      return DMXDrawsChartDraws.PageMarginsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.PageSetup>();
    if (itemElement != null)
      return DMXDrawsChartDraws.PageSetupConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsChartDraws.PrintSettings? CreateModelElement(DXO2016DrawChartDraw.PrintSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.PrintSettings();
      value.HeaderFooter = GetHeaderFooter(openXmlElement);
      value.PageMargins = GetPageMargins(openXmlElement);
      value.PageSetup = GetPageSetup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.PrintSettings? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.PrintSettings, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHeaderFooter(openXmlElement, value?.HeaderFooter);
      SetPageMargins(openXmlElement, value?.PageMargins);
      SetPageSetup(openXmlElement, value?.PageSetup);
      return openXmlElement;
    }
    return default;
  }
}
