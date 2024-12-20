namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public class NonVisualPicturePropertiesExtension: ModelElement
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