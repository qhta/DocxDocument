namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualPicturePropertiesExtension interface.
/// </summary>
public class NonVisualPicturePropertiesExtension: ModelElement<DXD.NonVisualPicturePropertiesExtension>,
  IExtension
{
  public CameraTool? CameraTool { get; set; }
  public SignatureLine? SignatureLine { get; set; }
  public ObjectProperties? ObjectProperties { get; set; }
  public LiveFeedProperties? LiveFeedProperties { get; set; }
  public string? UriString { get; set; }
}