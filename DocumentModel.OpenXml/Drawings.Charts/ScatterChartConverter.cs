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
  
}
