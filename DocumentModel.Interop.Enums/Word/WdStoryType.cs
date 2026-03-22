namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the story type of a selection or item.
/// </summary>
public enum WdStoryType
{
  /// <summary>
  /// Main text story.
  /// </summary>
  wdMainTextStory = unchecked((int)1),
  /// <summary>
  /// Footnotes story.
  /// </summary>
  wdFootnotesStory = unchecked((int)2),
  /// <summary>
  /// Endnotes story.
  /// </summary>
  wdEndnotesStory = unchecked((int)3),
  /// <summary>
  /// Comments story.
  /// </summary>
  wdCommentsStory = unchecked((int)4),
  /// <summary>
  /// Text frame story.
  /// </summary>
  wdTextFrameStory = unchecked((int)5),
  /// <summary>
  /// Even pages header story.
  /// </summary>
  wdEvenPagesHeaderStory = unchecked((int)6),
  /// <summary>
  /// Primary header story.
  /// </summary>
  wdPrimaryHeaderStory = unchecked((int)7),
  /// <summary>
  /// Even pages footer story.
  /// </summary>
  wdEvenPagesFooterStory = unchecked((int)8),
  /// <summary>
  /// Primary footer story.
  /// </summary>
  wdPrimaryFooterStory = unchecked((int)9),
  /// <summary>
  /// First page header story.
  /// </summary>
  wdFirstPageHeaderStory = unchecked((int)10),
  /// <summary>
  /// First page footer story. [System.Runtime.InteropServices.Guid("28594D1A-A83A-3372-A275-C1700CFB7D42")] public
  /// enum WdStoryType ﾉ Expand table
  /// </summary>
  wdFirstPageFooterStory = unchecked((int)11),
  /// <summary>
  /// Footnote separator story.
  /// </summary>
  wdFootnoteSeparatorStory = unchecked((int)12),
  /// <summary>
  /// Footnote continuation separator story.
  /// </summary>
  wdFootnoteContinuationSeparatorStory = unchecked((int)13),
  /// <summary>
  /// Footnote continuation notice story.
  /// </summary>
  wdFootnoteContinuationNoticeStory = unchecked((int)14),
  /// <summary>
  /// Endnote separator story.
  /// </summary>
  wdEndnoteSeparatorStory = unchecked((int)15),
  /// <summary>
  /// Endnote continuation separator story.
  /// </summary>
  wdEndnoteContinuationSeparatorStory = unchecked((int)16),
  /// <summary>
  /// Endnote continuation notice story.
  /// </summary>
  wdEndnoteContinuationNoticeStory = unchecked((int)17)
}
