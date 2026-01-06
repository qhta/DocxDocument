namespace DocumentModel.Drawings;

/// <summary>
/// Represents build diagram options, including build type, reverse animation, and additional extension settings for diagram elements.
/// </summary>
public interface BuildDiagram: ExtendableElement
{
  /// <summary>
  /// Build type or sequence for the diagram.
  /// </summary>
  public string? Build { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the animation should be reversed.
  /// </summary>
  public bool? ReverseAnimation { get; set; }
}