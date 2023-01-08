namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Line Charts.
/// </summary>
public static class LineChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public static DocumentModel.Drawings.Charts.GroupingKind? GetGrouping(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Grouping>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DocumentModel.Drawings.Charts.GroupingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetGrouping(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, DocumentModel.Drawings.Charts.GroupingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Grouping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DocumentModel.Drawings.Charts.GroupingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries>? GetLineChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DropLines? GetDropLines(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDropLines(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, DocumentModel.Drawings.Charts.DropLines? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.HighLowLines? GetHighLowLines(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHighLowLines(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, DocumentModel.Drawings.Charts.HighLowLines? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.UpDownBars? GetUpDownBars(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetUpDownBars(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, DocumentModel.Drawings.Charts.UpDownBars? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowMarker(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowMarker(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetSmooth(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSmooth(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.LineChartExtensionList? GetLineChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.LineChart? openXmlElement, DocumentModel.Drawings.Charts.LineChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
