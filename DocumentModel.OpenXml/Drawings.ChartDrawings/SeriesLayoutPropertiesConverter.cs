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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetParentLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.ParentLabelLayout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSeriesElementVisibilities(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesElementVisibilities? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetAggregation(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAggregation(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Binning? GetBinning(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBinning(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Binning? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Geography? GetGeography(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGeography(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Geography? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Statistics? GetStatistics(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStatistics(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Statistics? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Subtotals? GetSubtotals(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSubtotals(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.Subtotals? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
