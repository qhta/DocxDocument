namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public static class TrendlineConverter
{
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TrendlineKind? GetTrendlineType(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DocumentModel.Drawings.Charts.TrendlineKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTrendlineType(DocumentFormat.OpenXml.Drawing.Charts.Trendline? openXmlElement, DocumentModel.Drawings.Charts.TrendlineKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TrendlineType, DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DocumentModel.Drawings.Charts.TrendlineKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
