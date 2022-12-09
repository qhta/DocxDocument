namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public class OEmbedSharedImpl: ModelElementImpl, OEmbedShared
{
  public DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? SrcUrl
  {
    get => (String?)OpenXmlElement?.SrcUrl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SrcUrl = (System.String?)value;
    }
  }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Type
  {
    get => (String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList7? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
