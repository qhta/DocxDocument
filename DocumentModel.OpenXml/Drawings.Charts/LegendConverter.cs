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
  
}
