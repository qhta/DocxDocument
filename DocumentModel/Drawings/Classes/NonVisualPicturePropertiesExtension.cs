namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public partial class NonVisualPicturePropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.CameraTool? CameraTool { get; set; }
  
  public DocumentModel.Drawings.SignatureLine? SignatureLine { get; set; }
  
  public DocumentModel.Drawings.ObjectProperties? ObjectProperties { get; set; }
  
  public DocumentModel.Drawings.LiveFeedProperties? LiveFeedProperties { get; set; }
  
}
