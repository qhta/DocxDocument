namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a range of model elements in a WordprocessingML document, defined by a start and end position.
/// </summary>
public class Range
{
  /// <summary>
  /// Gets the parent model element that contains this range, providing context for the range within the document structure.
  /// </summary>
  public ModelElement Parent { get; private set; }

  /// <summary>
  /// Gets or sets the starting model element of the range, indicating where the range begins within the document.
  /// </summary>
  public ModelElement Start { get; set; }

  /// <summary>
  /// Gets or sets the ending model element of the range, indicating where the range ends within the document.
  /// </summary>
  public ModelElement End { get; set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="Range"/> class with the specified parent, start, and end model elements.
  /// </summary>
  /// <param name="parent">The parent model element that contains this range.</param>
  /// <param name="start">The starting model element of the range.</param>
  /// <param name="end">The ending model element of the range.</param>
  public Range(ModelElement parent, ModelElement start, ModelElement end)
  {
    Parent = parent;
    Start = start;
    End = end;
  }
}