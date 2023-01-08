namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Bubble Charts.
/// </summary>
public static class BubbleChartConverter
{
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
  
}
