namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public static class BubbleChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartSeries>? GetBubbleChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBubbleChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BubbleChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBubble3D(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt32? GetBubbleScale(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBubbleScale(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetShowNegativeBubbles(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetShowNegativeBubbles(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.SizeRepresentsKind? GetSizeRepresents(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DocumentModel.Drawings.Charts.SizeRepresentsKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSizeRepresents(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, DocumentModel.Drawings.Charts.SizeRepresentsKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresents, DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DocumentModel.Drawings.Charts.SizeRepresentsKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.BubbleChartExtensionList? GetBubbleChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBubbleChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.BubbleChart? openXmlElement, DocumentModel.Drawings.Charts.BubbleChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
