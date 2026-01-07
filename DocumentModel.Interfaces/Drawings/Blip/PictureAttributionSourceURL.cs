namespace DocumentModel.Drawings;

/// <summary>
///   Represents a picture attribution source URL, providing an identifier for the attribution source.
/// </summary>
public interface PictureAttributionSourceURL
{
  /// <summary>
  ///   Identifier for the picture attribution source.
  /// </summary>
  public string? Id { get; set; }
}