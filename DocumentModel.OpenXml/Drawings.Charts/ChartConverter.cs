namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the Chart Class.
/// </summary>
public static class ChartConverter
{
  /// <summary>
  /// The way that blank cells are plotted on a chart..
  /// </summary>
  public static DocumentModel.Drawings.Charts.DisplayBlanksAsKind? GetDisplayBlanksAs(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DocumentModel.Drawings.Charts.DisplayBlanksAsKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDisplayBlanksAs(DocumentFormat.OpenXml.Drawing.Charts.Chart? openXmlElement, DocumentModel.Drawings.Charts.DisplayBlanksAsKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAs, DocumentFormat.OpenXml.Drawing.Charts.DisplayBlanksAsValues, DocumentModel.Drawings.Charts.DisplayBlanksAsKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
