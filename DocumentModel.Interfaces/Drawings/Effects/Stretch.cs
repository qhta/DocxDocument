namespace DocumentModel.Drawings;

/// <summary>
///   Represents a stretch effect, specifying a fill rectangle for stretching content within a shape or element.
/// </summary>
public interface Stretch
{
  /// <summary>
  ///   Rectangle that defines the area to fill when stretching content.
  /// </summary>
  public RelativeRectangleType? FillRectangle { get; set; }
}