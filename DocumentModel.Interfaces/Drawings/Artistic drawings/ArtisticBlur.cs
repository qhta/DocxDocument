namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic blur effect, which applies a blur to an image or shape with a specified radius.
/// </summary>
public interface ArtisticBlur
{
  /// <summary>
  /// Gets or sets the radius of the artistic blur effect.
  /// </summary>
  public Int32? Radius { get; set; }
}