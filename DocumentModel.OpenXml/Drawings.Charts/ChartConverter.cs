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
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.Title? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.TitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Title>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// True if the chart automatic title has been deleted..
  /// </summary>
  public static Boolean? GetAutoTitleDeleted(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAutoTitleDeleted(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.AutoTitleDeleted();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// pivot chart format persistence data.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PivotFormats? GetPivotFormats(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PivotFormatsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPivotFormats(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.PivotFormats? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PivotFormatsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// 3D view settings.
  /// </summary>
  public static DocumentModel.Drawings.Charts.View3D? GetView3D(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.View3D>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.View3DConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetView3D(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.View3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.View3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.View3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.View3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// 3D floor formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Floor? GetFloor(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Floor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FloorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFloor(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.Floor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Floor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.FloorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Floor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// 3D side wall formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.SideWall? GetSideWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SideWall>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SideWallConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSideWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.SideWall? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SideWall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.SideWallConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SideWall>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// 3D back wall formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BackWall? GetBackWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BackWall>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BackWallConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackWall(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.BackWall? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BackWall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.BackWallConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BackWall>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Plot data and formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PlotArea? GetPlotArea(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPlotArea(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.PlotArea? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PlotAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Legend data and formatting.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Legend? GetLegend(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Legend>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LegendConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLegend(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.Legend? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Legend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LegendConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Legend>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// True if only visible cells are plotted..
  /// </summary>
  public static Boolean? GetPlotVisibleOnly(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetPlotVisibleOnly(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.PlotVisibleOnly();
        openXmlElement.AddChild(itemElement);
      }
    }
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
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetShowDataLabelsOverMaximum(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.ShowDataLabelsOverMaximum();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Extensibility container.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartExtensionList? GetChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.ChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Chart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Chart();
      value.Title = GetTitle(openXmlElement);
      value.AutoTitleDeleted = GetAutoTitleDeleted(openXmlElement);
      value.PivotFormats = GetPivotFormats(openXmlElement);
      value.View3D = GetView3D(openXmlElement);
      value.Floor = GetFloor(openXmlElement);
      value.SideWall = GetSideWall(openXmlElement);
      value.BackWall = GetBackWall(openXmlElement);
      value.PlotArea = GetPlotArea(openXmlElement);
      value.Legend = GetLegend(openXmlElement);
      value.PlotVisibleOnly = GetPlotVisibleOnly(openXmlElement);
      value.DisplayBlanksAs = GetDisplayBlanksAs(openXmlElement);
      value.ShowDataLabelsOverMaximum = GetShowDataLabelsOverMaximum(openXmlElement);
      value.ChartExtensionList = GetChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Chart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Chart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTitle(openXmlElement, value?.Title);
      SetAutoTitleDeleted(openXmlElement, value?.AutoTitleDeleted);
      SetPivotFormats(openXmlElement, value?.PivotFormats);
      SetView3D(openXmlElement, value?.View3D);
      SetFloor(openXmlElement, value?.Floor);
      SetSideWall(openXmlElement, value?.SideWall);
      SetBackWall(openXmlElement, value?.BackWall);
      SetPlotArea(openXmlElement, value?.PlotArea);
      SetLegend(openXmlElement, value?.Legend);
      SetPlotVisibleOnly(openXmlElement, value?.PlotVisibleOnly);
      SetDisplayBlanksAs(openXmlElement, value?.DisplayBlanksAs);
      SetShowDataLabelsOverMaximum(openXmlElement, value?.ShowDataLabelsOverMaximum);
      SetChartExtensionList(openXmlElement, value?.ChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
