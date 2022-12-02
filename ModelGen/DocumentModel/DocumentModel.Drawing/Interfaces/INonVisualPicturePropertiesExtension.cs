namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public interface INonVisualPicturePropertiesExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ICameraTool? CameraTool { get ; set; }
  
  public ISignatureLine? SignatureLine { get ; set; }
  
  public IObjectProperties? ObjectProperties { get ; set; }
  
  public ILiveFeedProperties? LiveFeedProperties { get ; set; }
  
}
