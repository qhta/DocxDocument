using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using BackWall = DocumentModel.Drawings.Charts.BackWall;
using Chart = DocumentFormat.OpenXml.Drawing.Charts.Chart;
using ChartExtensionList = DocumentModel.Drawings.Charts.ChartExtensionList;
using Floor = DocumentModel.Drawings.Charts.Floor;
using Legend = DocumentModel.Drawings.Charts.Legend;
using PivotFormats = DocumentModel.Drawings.Charts.PivotFormats;
using PlotArea = DocumentModel.Drawings.Charts.PlotArea;
using SideWall = DocumentModel.Drawings.Charts.SideWall;
using Title = DocumentModel.Drawings.Charts.Title;
using View3D = DocumentModel.Drawings.Charts.View3D;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  ///   Title data and formatting.
  /// </summary>
  public static Title? GetTitle(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return TitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTitle(Chart? openXmlElement, Title? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Title>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   True if the chart automatic title has been deleted..
  /// </summary>
  public static Boolean? GetAutoTitleDeleted(Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoTitleDeleted>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoTitleDeleted(Chart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoTitleDeleted>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoTitleDeleted();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   pivot chart format persistence data.
  /// </summary>
  public static PivotFormats? GetPivotFormats(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>();
    if (itemElement != null)
      return PivotFormatsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPivotFormats(Chart? openXmlElement, PivotFormats? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotFormatsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PivotFormats>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   3D view settings.
  /// </summary>
  public static View3D? GetView3D(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.View3D>();
    if (itemElement != null)
      return View3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetView3D(Chart? openXmlElement, View3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.View3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = View3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.View3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   3D floor formatting.
  /// </summary>
  public static Floor? GetFloor(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Floor>();
    if (itemElement != null)
      return FloorConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFloor(Chart? openXmlElement, Floor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Floor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FloorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Floor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   3D side wall formatting.
  /// </summary>
  public static SideWall? GetSideWall(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SideWall>();
    if (itemElement != null)
      return SideWallConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSideWall(Chart? openXmlElement, SideWall? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SideWall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SideWallConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SideWall>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   3D back wall formatting.
  /// </summary>
  public static BackWall? GetBackWall(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BackWall>();
    if (itemElement != null)
      return BackWallConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackWall(Chart? openXmlElement, BackWall? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BackWall>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackWallConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BackWall>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Plot data and formatting.
  /// </summary>
  public static PlotArea? GetPlotArea(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>();
    if (itemElement != null)
      return PlotAreaConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPlotArea(Chart? openXmlElement, PlotArea? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PlotArea>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Legend data and formatting.
  /// </summary>
  public static Legend? GetLegend(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Legend>();
    if (itemElement != null)
      return LegendConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLegend(Chart? openXmlElement, Legend? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Legend>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegendConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Legend>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   True if only visible cells are plotted..
  /// </summary>
  public static Boolean? GetPlotVisibleOnly(Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PlotVisibleOnly>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetPlotVisibleOnly(Chart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<PlotVisibleOnly>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new PlotVisibleOnly();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   The way that blank cells are plotted on a chart..
  /// </summary>
  public static DisplayBlanksAsKind? GetDisplayBlanksAs(Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayBlanksAs>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DisplayBlanksAsValues, DisplayBlanksAsKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDisplayBlanksAs(Chart? openXmlElement, DisplayBlanksAsKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayBlanksAs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DisplayBlanksAs, DisplayBlanksAsValues, DisplayBlanksAsKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   True if we should render datalabels over the maximum scale.
  /// </summary>
  public static Boolean? GetShowDataLabelsOverMaximum(Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ShowDataLabelsOverMaximum>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetShowDataLabelsOverMaximum(Chart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ShowDataLabelsOverMaximum>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ShowDataLabelsOverMaximum();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Extensibility container.
  /// </summary>
  public static ChartExtensionList? GetChartExtensionList(Chart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>();
    if (itemElement != null)
      return ChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartExtensionList(Chart? openXmlElement, ChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.Chart? CreateModelElement(Chart? openXmlElement)
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
    where OpenXmlElementType : Chart, new()
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