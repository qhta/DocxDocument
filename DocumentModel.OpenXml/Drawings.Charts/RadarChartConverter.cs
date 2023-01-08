namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Radar Charts.
/// </summary>
public static class RadarChartConverter
{
  /// <summary>
  /// RadarStyle.
  /// </summary>
  public static DocumentModel.Drawings.Charts.RadarStyleKind? GetRadarStyle(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DocumentModel.Drawings.Charts.RadarStyleKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetRadarStyle(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement, DocumentModel.Drawings.Charts.RadarStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarStyle, DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DocumentModel.Drawings.Charts.RadarStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.RadarChartSeries>? GetRadarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRadarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.RadarChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.RadarChartExtensionList? GetRadarChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRadarChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.RadarChart? openXmlElement, DocumentModel.Drawings.Charts.RadarChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
