namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Legend data and formatting.
/// </summary>
public static class LegendConverter
{
  /// <summary>
  /// Legend Position.
  /// </summary>
  public static DocumentModel.Drawings.Charts.LegendPositionKind? GetLegendPosition(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DocumentModel.Drawings.Charts.LegendPositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLegendPosition(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.LegendPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LegendPosition, DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DocumentModel.Drawings.Charts.LegendPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LegendEntry>? GetLegendEntries(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLegendEntries(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LegendEntry>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetOverlay(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetOverlay(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Legend? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
