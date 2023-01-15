using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Binning = DocumentModel.Drawings.ChartDrawings.Binning;
using Geography = DocumentModel.Drawings.ChartDrawings.Geography;
using ParentLabelLayout = DocumentModel.Drawings.ChartDrawings.ParentLabelLayout;
using RegionLabelLayoutEnum = DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum;
using SeriesElementVisibilities = DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities;
using SeriesLayoutProperties = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties;
using Statistics = DocumentModel.Drawings.ChartDrawings.Statistics;
using Subtotals = DocumentModel.Drawings.ChartDrawings.Subtotals;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the SeriesLayoutProperties Class.
/// </summary>
public static class SeriesLayoutPropertiesConverter
{
  /// <summary>
  ///   ParentLabelLayout.
  /// </summary>
  public static ParentLabelLayout? GetParentLabelLayout(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>();
    if (itemElement != null)
      return ParentLabelLayoutConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParentLabelLayout(SeriesLayoutProperties? openXmlElement, ParentLabelLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParentLabelLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   RegionLabelLayout.
  /// </summary>
  public static RegionLabelLayoutEnum? GetRegionLabelLayout(SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RegionLabelLayout>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, RegionLabelLayoutEnum>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetRegionLabelLayout(SeriesLayoutProperties? openXmlElement, RegionLabelLayoutEnum? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<RegionLabelLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, RegionLabelLayoutEnum>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   SeriesElementVisibilities.
  /// </summary>
  public static SeriesElementVisibilities? GetSeriesElementVisibilities(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>();
    if (itemElement != null)
      return SeriesElementVisibilitiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesElementVisibilities(SeriesLayoutProperties? openXmlElement, SeriesElementVisibilities? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesElementVisibilitiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetAggregation(SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Aggregation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAggregation(SeriesLayoutProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Aggregation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Aggregation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Binning? GetBinning(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>();
    if (itemElement != null)
      return BinningConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBinning(SeriesLayoutProperties? openXmlElement, Binning? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BinningConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Geography? GetGeography(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>();
    if (itemElement != null)
      return GeographyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGeography(SeriesLayoutProperties? openXmlElement, Geography? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeographyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Statistics? GetStatistics(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>();
    if (itemElement != null)
      return StatisticsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStatistics(SeriesLayoutProperties? openXmlElement, Statistics? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StatisticsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Subtotals? GetSubtotals(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>();
    if (itemElement != null)
      return SubtotalsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSubtotals(SeriesLayoutProperties? openXmlElement, Subtotals? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubtotalsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? CreateModelElement(SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties();
      value.ParentLabelLayout = GetParentLabelLayout(openXmlElement);
      value.RegionLabelLayout = GetRegionLabelLayout(openXmlElement);
      value.SeriesElementVisibilities = GetSeriesElementVisibilities(openXmlElement);
      value.Aggregation = GetAggregation(openXmlElement);
      value.Binning = GetBinning(openXmlElement);
      value.Geography = GetGeography(openXmlElement);
      value.Statistics = GetStatistics(openXmlElement);
      value.Subtotals = GetSubtotals(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? value)
    where OpenXmlElementType : SeriesLayoutProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParentLabelLayout(openXmlElement, value?.ParentLabelLayout);
      SetRegionLabelLayout(openXmlElement, value?.RegionLabelLayout);
      SetSeriesElementVisibilities(openXmlElement, value?.SeriesElementVisibilities);
      SetAggregation(openXmlElement, value?.Aggregation);
      SetBinning(openXmlElement, value?.Binning);
      SetGeography(openXmlElement, value?.Geography);
      SetStatistics(openXmlElement, value?.Statistics);
      SetSubtotals(openXmlElement, value?.Subtotals);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}