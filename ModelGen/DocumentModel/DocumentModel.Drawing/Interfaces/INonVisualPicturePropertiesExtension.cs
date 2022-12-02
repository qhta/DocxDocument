namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public interface INonVisualPicturePropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.ICameraTool? CameraTool { get ; set; }
  
  public DocumentModel.Drawing.ISignatureLine? SignatureLine { get ; set; }
  
  public DocumentModel.Drawing.IObjectProperties? ObjectProperties { get ; set; }
  
  public DocumentModel.Drawing.ILiveFeedProperties? LiveFeedProperties { get ; set; }
  
}
