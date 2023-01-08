namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PictureOptions Class.
/// </summary>
public static class PictureOptionsConverter
{
  /// <summary>
  /// Picture Format.
  /// </summary>
  public static DocumentModel.Drawings.Charts.PictureFormatKind? GetPictureFormat(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DocumentModel.Drawings.Charts.PictureFormatKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPictureFormat(DocumentFormat.OpenXml.Drawing.Charts.PictureOptions? openXmlElement, DocumentModel.Drawings.Charts.PictureFormatKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PictureFormat, DocumentFormat.OpenXml.Drawing.Charts.PictureFormatValues, DocumentModel.Drawings.Charts.PictureFormatKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
