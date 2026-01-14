namespace DocumentModel.Drawings;

/// <summary>
/// Represents a bi-level effect, which applies a threshold to convert an image or shape to strictly two levels (e.g., black and white).
/// </summary>
public class BiLevel: ModelElement
{
  /// <summary>
  /// Threshold value used to determine the separation between the two levels.
  /// </summary>
  public Int32? Threshold { get; set; }
}