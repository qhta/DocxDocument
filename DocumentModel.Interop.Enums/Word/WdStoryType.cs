namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the story type of a selection or item.
/// </summary>
public enum WdStoryType
{
  /// <summary>
  /// Main text story.
  /// </summary>
  MainTextStory = unchecked((int)1),
  /// <summary>
  /// Footnotes story.
  /// </summary>
  FootnotesStory = unchecked((int)2),
  /// <summary>
  /// Endnotes story.
  /// </summary>
  EndnotesStory = unchecked((int)3),
  /// <summary>
  /// Comments story.
  /// </summary>
  CommentsStory = unchecked((int)4),
  /// <summary>
  /// Text frame story.
  /// </summary>
  TextFrameStory = unchecked((int)5),
  /// <summary>
  /// Even pages header story.
  /// </summary>
  EvenPagesHeaderStory = unchecked((int)6),
  /// <summary>
  /// Primary header story.
  /// </summary>
  PrimaryHeaderStory = unchecked((int)7),
  /// <summary>
  /// Even pages footer story.
  /// </summary>
  EvenPagesFooterStory = unchecked((int)8),
  /// <summary>
  /// Primary footer story.
  /// </summary>
  PrimaryFooterStory = unchecked((int)9),
  /// <summary>
  /// First page header story.
  /// </summary>
  FirstPageHeaderStory = unchecked((int)10),
  /// <summary>
  /// First page footer story. [System.Runtime.InteropServices.Guid("28594D1A-A83A-3372-A275-C1700CFB7D42")] public
  /// enum WdStoryType ﾉ Expand table
  /// </summary>
  FirstPageFooterStory = unchecked((int)11),
  /// <summary>
  /// Footnote separator story.
  /// </summary>
  FootnoteSeparatorStory = unchecked((int)12),
  /// <summary>
  /// Footnote continuation separator story.
  /// </summary>
  FootnoteContinuationSeparatorStory = unchecked((int)13),
  /// <summary>
  /// Footnote continuation notice story.
  /// </summary>
  FootnoteContinuationNoticeStory = unchecked((int)14),
  /// <summary>
  /// Endnote separator story.
  /// </summary>
  EndnoteSeparatorStory = unchecked((int)15),
  /// <summary>
  /// Endnote continuation separator story.
  /// </summary>
  EndnoteContinuationSeparatorStory = unchecked((int)16),
  /// <summary>
  /// Endnote continuation notice story.
  /// </summary>
  EndnoteContinuationNoticeStory = unchecked((int)17)
}
