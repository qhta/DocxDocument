namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the story type of a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstorytype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdStoryType")]
public enum StoryType
{
  /// <summary>
  /// Main text story.
  /// </summary>
  [InteropEnumValue("wdMainTextStory")]
  MainTextStory = 1,
  /// <summary>
  /// Footnotes story.
  /// </summary>
  [InteropEnumValue("wdFootnotesStory")]
  FootnotesStory = 2,
  /// <summary>
  /// Endnotes story.
  /// </summary>
  [InteropEnumValue("wdEndnotesStory")]
  EndnotesStory = 3,
  /// <summary>
  /// Comments story.
  /// </summary>
  [InteropEnumValue("wdCommentsStory")]
  CommentsStory = 4,
  /// <summary>
  /// Text frame story.
  /// </summary>
  [InteropEnumValue("wdTextFrameStory")]
  TextFrameStory = 5,
  /// <summary>
  /// Even pages header story.
  /// </summary>
  [InteropEnumValue("wdEvenPagesHeaderStory")]
  EvenPagesHeaderStory = 6,
  /// <summary>
  /// Primary header story.
  /// </summary>
  [InteropEnumValue("wdPrimaryHeaderStory")]
  PrimaryHeaderStory = 7,
  /// <summary>
  /// Even pages footer story.
  /// </summary>
  [InteropEnumValue("wdEvenPagesFooterStory")]
  EvenPagesFooterStory = 8,
  /// <summary>
  /// Primary footer story.
  /// </summary>
  [InteropEnumValue("wdPrimaryFooterStory")]
  PrimaryFooterStory = 9,
  /// <summary>
  /// First page header story.
  /// </summary>
  [InteropEnumValue("wdFirstPageHeaderStory")]
  FirstPageHeaderStory = 10,
  /// <summary>
  /// First page footer story.
  /// </summary>
  [InteropEnumValue("wdFirstPageFooterStory")]
  FirstPageFooterStory = 11,
  /// <summary>
  /// Footnote separator story.
  /// </summary>
  [InteropEnumValue("wdFootnoteSeparatorStory")]
  FootnoteSeparatorStory = 12,
  /// <summary>
  /// Footnote continuation separator story.
  /// </summary>
  [InteropEnumValue("wdFootnoteContinuationSeparatorStory")]
  FootnoteContinuationSeparatorStory = 13,
  /// <summary>
  /// Footnote continuation notice story.
  /// </summary>
  [InteropEnumValue("wdFootnoteContinuationNoticeStory")]
  FootnoteContinuationNoticeStory = 14,
  /// <summary>
  /// Endnote separator story.
  /// </summary>
  [InteropEnumValue("wdEndnoteSeparatorStory")]
  EndnoteSeparatorStory = 15,
  /// <summary>
  /// Endnote continuation separator story.
  /// </summary>
  [InteropEnumValue("wdEndnoteContinuationSeparatorStory")]
  EndnoteContinuationSeparatorStory = 16,
  /// <summary>
  /// Endnote continuation notice story.
  /// </summary>
  [InteropEnumValue("wdEndnoteContinuationNoticeStory")]
  EndnoteContinuationNoticeStory = 17
}
