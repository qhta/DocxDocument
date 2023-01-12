namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public static class SeriesLayoutPropertiesConverter
{
  /// <summary>
  /// ParentLabelLayout.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? GetParentLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ParentLabelLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetParentLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ParentLabelLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ParentLabelLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum? GetRegionLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetRegionLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SeriesElementVisibilities.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? GetSeriesElementVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesElementVisibilitiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeriesElementVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesElementVisibilitiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesElementVisibilities>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetAggregation(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetAggregation(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Aggregation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Binning? GetBinning(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.BinningConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBinning(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Binning? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.BinningConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Binning>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Geography? GetGeography(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.GeographyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGeography(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Geography? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.GeographyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Geography>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Statistics? GetStatistics(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.StatisticsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStatistics(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Statistics? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.StatisticsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Statistics>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Subtotals? GetSubtotals(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.SubtotalsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSubtotals(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Subtotals? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.SubtotalsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Subtotals>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParentLabelLayout(openXmlElement, value?.ParentLabelLayout);
      SetRegionLabelLayout(openXmlElement, value?.RegionLabelLayout);
      SetSeriesElementVisibilities(openXmlElement, value?.SeriesElementVisibilities);
      return openXmlElement;
    }
    return default;
  }
}
