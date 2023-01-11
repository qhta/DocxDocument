namespace DocumentModel.OpenXml.Drawings.Office.OEmbed;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public static class OEmbedSharedConverter
{
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public static String? GetSrcUrl(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement)
  {
    return openXmlElement?.SrcUrl?.Value;
  }
  
  public static void SetSrcUrl(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.SrcUrl = new StringValue { Value = value };
      else
        openXmlElement.SrcUrl = null;
  }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  public static String? GetType(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  public static void SetType(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Type = new StringValue { Value = value };
      else
        openXmlElement.Type = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Office.OEmbed.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Office.OEmbed.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement, DocumentModel.Drawings.Office.OEmbed.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Office.OEmbed.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Office.OEmbed.OEmbedShared? CreateModelElement(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.OEmbed.OEmbedShared();
      value.SrcUrl = GetSrcUrl(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Office.OEmbed.OEmbedShared? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
