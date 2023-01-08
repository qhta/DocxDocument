namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// Title data and formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Title? GetTitle(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.Title? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  public static Boolean? GetAutoTitleDeleted(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAutoTitleDeleted(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PivotFormats? GetPivotFormats(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPivotFormats(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.PivotFormats? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public static DocumentModel.Drawings.Charts.View3D? GetView3D(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetView3D(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.View3D? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Floor? GetFloor(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFloor(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.Floor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.SideWall? GetSideWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSideWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.SideWall? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BackWall? GetBackWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.BackWall? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PlotArea? GetPlotArea(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPlotArea(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.PlotArea? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Legend? GetLegend(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLegend(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.Legend? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  public static Boolean? GetPlotVisibleOnly(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPlotVisibleOnly(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public static DocumentModel.Drawings.Charts.DisplayBlanksAsKind? GetDisplayBlanksAs(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DocumentModel.Drawings.Charts.DisplayBlanksAsKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDisplayBlanksAs(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.DisplayBlanksAsKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs, DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DocumentModel.Drawings.Charts.DisplayBlanksAsKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// True if we should render datalabels over the maximum scale.
  /// </summary>
  public static Boolean? GetShowDataLabelsOverMaximum(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowDataLabelsOverMaximum(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartExtensionList? GetChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.ChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
