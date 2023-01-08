namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Area Charts.
/// </summary>
public static class AreaChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public static DocumentModel.Drawings.Charts.GroupingKind? GetGrouping(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
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
  
  public static void SetGrouping(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, DocumentModel.Drawings.Charts.GroupingKind? value)
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
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaChartSeries>? GetAreaChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAreaChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.AreaChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DropLines? GetDropLines(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDropLines(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, DocumentModel.Drawings.Charts.DropLines? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.AreaChartExtensionList? GetAreaChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAreaChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.AreaChart? openXmlElement, DocumentModel.Drawings.Charts.AreaChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
