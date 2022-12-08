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
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public CameraTool? CameraTool
  {
    get;
    set;
  }
  
  public SignatureLine? SignatureLine
  {
    get;
    set;
  }
  
  public ObjectProperties? ObjectProperties
  {
    get;
    set;
  }
  
  public LiveFeedProperties? LiveFeedProperties
  {
    get;
    set;
  }
  
}
