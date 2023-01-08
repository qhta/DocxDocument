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
  
}
