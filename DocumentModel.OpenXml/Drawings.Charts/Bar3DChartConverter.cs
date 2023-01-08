namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Bar Charts.
/// </summary>
public static class Bar3DChartConverter
{
  /// <summary>
  /// Bar Direction.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BarDirectionKind? GetBarDirection(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarDirection>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DocumentModel.Drawings.Charts.BarDirectionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBarDirection(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, DocumentModel.Drawings.Charts.BarDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarDirection, DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DocumentModel.Drawings.Charts.BarDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Bar Grouping.
  /// </summary>
  public static DocumentModel.Drawings.Charts.BarGroupingKind? GetBarGrouping(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DocumentModel.Drawings.Charts.BarGroupingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBarGrouping(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, DocumentModel.Drawings.Charts.BarGroupingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarGrouping, DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DocumentModel.Drawings.Charts.BarGroupingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartSeries>? GetBarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBarChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.BarChartSeries>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt16? GetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGapWidth(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static UInt16? GetGapDepth(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGapDepth(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.ShapeKind? GetShape(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DocumentModel.Drawings.Charts.ShapeKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetShape(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, DocumentModel.Drawings.Charts.ShapeKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DocumentModel.Drawings.Charts.ShapeKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Drawings.Charts.Bar3DChartExtensionList? GetBar3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBar3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Bar3DChart? openXmlElement, DocumentModel.Drawings.Charts.Bar3DChartExtensionList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
