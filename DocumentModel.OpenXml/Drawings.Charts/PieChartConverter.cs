using DocumentFormat.OpenXml.Drawing.Charts;
using DataLabels = DocumentModel.Drawings.Charts.DataLabels;
using PieChartExtensionList = DocumentModel.Drawings.Charts.PieChartExtensionList;
using PieChartSeries = DocumentModel.Drawings.Charts.PieChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Pie Charts.
/// </summary>
public static class PieChartConverter
{
  /// <summary>
  ///   VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<VaryColors>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetVaryColors(PieChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<VaryColors>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new VaryColors();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<PieChartSeries>? GetPieChartSerieses(PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<PieChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>())
      {
        var newItem = PieChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetPieChartSerieses(PieChart? openXmlElement, Collection<PieChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = PieChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(PieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(PieChart? openXmlElement, DataLabels? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetFirstSliceAngle(PieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<FirstSliceAngle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetFirstSliceAngle(PieChart? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<FirstSliceAngle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new FirstSliceAngle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PieChartExtensionList? GetPieChartExtensionList(PieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList>();
    if (itemElement != null)
      return PieChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPieChartExtensionList(PieChart? openXmlElement, PieChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PieChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.PieChart? CreateModelElement(PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.FirstSliceAngle = GetFirstSliceAngle(openXmlElement);
      value.PieChartExtensionList = GetPieChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PieChart? value)
    where OpenXmlElementType : PieChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetPieChartSerieses(openXmlElement, value?.PieChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetFirstSliceAngle(openXmlElement, value?.FirstSliceAngle);
      SetPieChartExtensionList(openXmlElement, value?.PieChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}