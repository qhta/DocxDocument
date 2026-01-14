namespace DocumentModel.Drawings;

/// <summary>
/// Represents an artistic blur effect, which applies a blur to an image or shape with a specified radius.
/// </summary>
public class ArtisticBlur: ModelElement
{
  /// <summary>
  /// Radius of the artistic blur effect.
  /// </summary>
  public Int32? Radius { get; set; }
}