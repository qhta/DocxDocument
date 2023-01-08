namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public static class OfPieChartConverter
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public static DocumentModel.Drawings.Charts.OfPieKind? GetOfPieType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DocumentModel.Drawings.Charts.OfPieKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetOfPieType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.OfPieKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieType, DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DocumentModel.Drawings.Charts.OfPieKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? GetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt16? GetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.SplitKind? GetSplitType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DocumentModel.Drawings.Charts.SplitKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSplitType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.SplitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SplitType, DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DocumentModel.Drawings.Charts.SplitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Double? GetSplitPosition(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSplitPosition(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.CustomSplit? GetCustomSplit(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCustomSplit(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.CustomSplit? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt16? GetSecondPieSize(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSecondPieSize(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>? GetSeriesLineses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSeriesLineses(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SeriesLines>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
