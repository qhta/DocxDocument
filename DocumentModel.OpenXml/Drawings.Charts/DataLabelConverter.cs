namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Data Label.
/// </summary>
public static class DataLabelConverter
{
  /// <summary>
  /// Index.
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetDelete(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDelete(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ChartText? GetChartText(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartText(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartText? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.NumberingFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelPositionKind? GetDataLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
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
  
  public static void SetDataLabelPosition(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.DataLabelPositionKind? value)
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
  
  public static Boolean? GetShowLegendKey(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowLegendKey(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowValue(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowValue(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowCategoryName(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowCategoryName(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowSeriesName(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowSeriesName(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowPercent(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowPercent(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowBubbleSize(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowBubbleSize(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetSeparator(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Drawing.Charts.Separator");
  }
  
  public static void SetSeparator(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtensionList? GetDLblExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDLblExtensionList(DocumentFormat.OpenXml.Drawing.Charts.DataLabel? openXmlElement, DocumentModel.Drawings.Charts.DLblExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
