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
  
}
