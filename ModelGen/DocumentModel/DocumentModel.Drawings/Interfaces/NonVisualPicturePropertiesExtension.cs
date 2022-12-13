namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public interface NonVisualPicturePropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.CameraTool? CameraTool { get ; set; }
  
  public DocumentModel.Drawings13.SignatureLine? SignatureLine { get ; set; }
  
  public DocumentModel.Drawings13.ObjectProperties? ObjectProperties { get ; set; }
  
  public DocumentModel.Drawings.LiveFeedProperties? LiveFeedProperties { get ; set; }
  
}
