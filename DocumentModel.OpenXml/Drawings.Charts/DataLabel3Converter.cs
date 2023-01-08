namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabel3Converter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDelete(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDelete(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ChartText? GetChartText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartText(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartText? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelPositionKind? GetDataLabelPosition(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DocumentModel.Drawings.Charts.DataLabelPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDataLabelPosition(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.DataLabelPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.DataLabelPositionValues, DocumentModel.Drawings.Charts.DataLabelPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetShowLegendKey(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowLegendKey(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowValue(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowValue(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowCategoryName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowCategoryName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowSeriesName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowSeriesName(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowPercent(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowPercent(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowBubbleSize(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowBubbleSize(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetSeparator(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Charts.Separator");
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtensionList? GetDLblExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDLblExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.DLblExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
