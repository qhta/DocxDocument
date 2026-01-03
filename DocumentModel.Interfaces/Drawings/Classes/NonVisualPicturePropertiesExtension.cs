namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtension interface.
/// </summary>
public interface NonVisualPicturePropertiesExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public CameraTool? CameraTool { get; set; }
  public SignatureLine? SignatureLine { get; set; }
  public ObjectProperties? ObjectProperties { get; set; }
  public LiveFeedProperties? LiveFeedProperties { get; set; }
}