namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public static class Line3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  public static DocumentModel.Drawings.Charts.GroupingKind? GetGrouping(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
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
  
  public static void SetGrouping(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, DocumentModel.Drawings.Charts.GroupingKind? value)
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
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries>? GetLineChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DropLines? GetDropLines(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDropLines(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, DocumentModel.Drawings.Charts.DropLines? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt16? GetGapDepth(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGapDepth(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChartExtensionList? GetLine3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLine3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement, DocumentModel.Drawings.Charts.Line3DChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
