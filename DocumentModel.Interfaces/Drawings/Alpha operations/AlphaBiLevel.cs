namespace DocumentModel.Drawings;

/// <summary>
/// Represents an alpha bi-level effect, which applies a threshold to the alpha channel of an image or shape.
/// </summary>
public interface AlphaBiLevel
{
  /// <summary>
  /// Gets or sets the threshold value used to determine the bi-level separation of the alpha channel.
  /// </summary>
  public Int32? Threshold { get; set; }
}