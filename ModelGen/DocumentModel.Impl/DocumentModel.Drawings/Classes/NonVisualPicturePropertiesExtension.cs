namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public class NonVisualPicturePropertiesExtensionImpl: ModelElementImpl, NonVisualPicturePropertiesExtension
{
  public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualPicturePropertiesExtensionImpl(): base() {}
  
  public NonVisualPicturePropertiesExtensionImpl(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.CameraTool? CameraTool
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.SignatureLine? SignatureLine
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.ObjectProperties? ObjectProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.LiveFeedProperties? LiveFeedProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
