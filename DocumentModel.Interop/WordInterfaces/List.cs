namespace DocumentModel.Interop;

/// <summary>
/// Represents a single list format that's been applied to specified paragraphs in a document.
/// </summary>
public partial interface List : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The list paragraphs.
  /// </summary>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// The single list template.
  /// </summary>
  public bool SingleListTemplate { get; }

  /// <summary>
  /// The style name.
  /// </summary>
  public string StyleName { get; }
}
