namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ListStyle Class.
/// </summary>
public class ListStyle: ModelElement
{
  /// <summary>
  ///   Default Paragraph Style.
  /// </summary>
  public ParagraphProperties? DefaultParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 1 Text Style.
  /// </summary>
  public ParagraphProperties? Level1ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 2 Text Style.
  /// </summary>
  public ParagraphProperties? Level2ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 3 Text Style.
  /// </summary>
  public ParagraphProperties? Level3ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 4 Text Style.
  /// </summary>
  public ParagraphProperties? Level4ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 5 Text Style.
  /// </summary>
  public ParagraphProperties? Level5ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 6 Text Style.
  /// </summary>
  public ParagraphProperties? Level6ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 7 Text Style.
  /// </summary>
  public ParagraphProperties? Level7ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 8 Text Style.
  /// </summary>
  public ParagraphProperties? Level8ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 9 Text Style.
  /// </summary>
  public ParagraphProperties? Level9ParagraphProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}