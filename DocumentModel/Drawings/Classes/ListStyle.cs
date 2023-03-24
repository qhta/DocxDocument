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
  public DefaultParagraphProperties? DefaultParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 1 Text Style.
  /// </summary>
  public Level1ParagraphProperties? Level1ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 2 Text Style.
  /// </summary>
  public Level2ParagraphProperties? Level2ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 3 Text Style.
  /// </summary>
  public Level3ParagraphProperties? Level3ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 4 Text Style.
  /// </summary>
  public Level4ParagraphProperties? Level4ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 5 Text Style.
  /// </summary>
  public Level5ParagraphProperties? Level5ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 6 Text Style.
  /// </summary>
  public Level6ParagraphProperties? Level6ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 7 Text Style.
  /// </summary>
  public Level7ParagraphProperties? Level7ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 8 Text Style.
  /// </summary>
  public Level8ParagraphProperties? Level8ParagraphProperties { get; set; }

  /// <summary>
  ///   List Level 9 Text Style.
  /// </summary>
  public Level9ParagraphProperties? Level9ParagraphProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}