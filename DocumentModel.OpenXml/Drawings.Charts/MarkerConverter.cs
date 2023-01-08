namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Marker.
/// </summary>
public static class MarkerConverter
{
  /// <summary>
  /// Symbol.
  /// </summary>
  public static DocumentModel.Drawings.Charts.MarkerStyleKind? GetSymbol(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DocumentModel.Drawings.Charts.MarkerStyleKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSymbol(DocumentFormat.OpenXml.Drawing.Charts.Marker? openXmlElement, DocumentModel.Drawings.Charts.MarkerStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Symbol>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol, DocumentFormat.OpenXml.Drawing.Charts.MarkerStyleValues, DocumentModel.Drawings.Charts.MarkerStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
