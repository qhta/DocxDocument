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
  
  public DocumentModel.Office2010.Drawing.ICameraTool? CameraTool { get ; set; }
  
  public DocumentModel.Office2013.Drawing.ISignatureLine? SignatureLine { get ; set; }
  
  public DocumentModel.Office2013.Drawing.IObjectProperties? ObjectProperties { get ; set; }
  
  public DocumentModel.Office2021.Drawing.Livefeed.ILiveFeedProperties? LiveFeedProperties { get ; set; }
  
}
