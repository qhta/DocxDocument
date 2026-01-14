namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
///   Represents an inline shape (picture, diagram, etc.) within the text flow.
/// </summary>
/// <remarks>
///   Inline shapes flow with surrounding text like characters, as opposed to
///   floating shapes which can be positioned independently.
/// </remarks>
public interface InlineShape: CollectionItem
{
  #region Properties

  /// <summary>
  ///   Gets or sets the width of the inline shape in points.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  ///   Gets or sets the height of the inline shape in points.
  /// </summary>
  public float Height { get; set; }

  /// <summary>
  ///   Gets the type of the inline shape.
  /// </summary>
  public InlineShapeKind Type { get; }

  /// <summary>
  ///   Gets or sets the alternative text for the shape.
  /// </summary>
  public string? AlternativeText { get; set; }

  /// <summary>
  ///   Gets the range that contains the inline shape.
  /// </summary>
  public Range? Range { get; }

  #endregion
}