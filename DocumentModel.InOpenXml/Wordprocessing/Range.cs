namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a range of model elements in a WordprocessingML document, defined by a start and end position.
/// </summary>
public class Range: ModelElement
{
  /// <summary>
  /// Data source for the range, representing the underlying model element that contains the structure for the range.
  /// </summary>
  public ModelElement SourceElement { get; private set; }

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
  /// <param name="sourceElement">The model element that serves as the data source for the range.</param>
  /// <param name="start">The starting model element of the range.</param>
  /// <param name="end">The ending model element of the range.</param>
  public Range(ModelElement parent, ModelElement sourceElement, ModelElement start, ModelElement end)
  {
    SetParent(parent);
    SourceElement = sourceElement;
    Start = start;
    End = end;
  }

  /// <summary>
  /// Gets the collection of items within the range, allowing access to the block-level content that exists between the start and end model elements.
  /// </summary>
  public RangeItemsCollections Items
  {
    get
    {
      var result = _Items ??= new RangeItemsCollections(this, SourceElement);
      return result;
    }
  }
  private RangeItemsCollections? _Items;
}