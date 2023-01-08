namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public static class ScatterChartConverter
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ScatterStyleKind? GetScatterStyle(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DocumentModel.Drawings.Charts.ScatterStyleKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetScatterStyle(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, DocumentModel.Drawings.Charts.ScatterStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle, DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DocumentModel.Drawings.Charts.ScatterStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>? GetScatterChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScatterChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartExtensionList? GetScatterChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetScatterChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, DocumentModel.Drawings.Charts.ScatterChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
