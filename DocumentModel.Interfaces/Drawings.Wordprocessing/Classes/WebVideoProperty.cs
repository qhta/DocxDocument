namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public interface WebVideoProperty:
{
  /// <summary>
  ///   embeddedHtml
  /// </summary>
  public string? EmbeddedHtml { get; set; }
  /// <summary>
  ///   h
  /// </summary>
  public UInt32? Height { get; set; }
  /// <summary>
  ///   w
  /// </summary>
  public UInt32? Width { get; set; }
}