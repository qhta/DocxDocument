namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ListStyle Class.
/// </summary>
public class ListStyle: ModelElement
{
  /// <summary>
  ///   Default IParagraph IStyle.
  /// </summary>
  public ParagraphProperties? DefaultParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 1 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level1ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 2 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level2ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 3 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level3ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 4 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level4ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 5 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level5ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 6 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level6ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 7 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level7ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 8 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level8ParagraphProperties { get; set; }

  /// <summary>
  ///   IList Level 9 Text IStyle.
  /// </summary>
  public ParagraphProperties? Level9ParagraphProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
