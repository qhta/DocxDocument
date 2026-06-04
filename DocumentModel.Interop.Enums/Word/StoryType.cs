namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the story type of a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstorytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdStoryType")]
public enum StoryType
{
  /// <summary>
  /// Main text story.
  /// </summary>
  [WordInteropEnumValue("wdMainTextStory")]
  MainTextStory = 1,
  /// <summary>
  /// Footnotes story.
  /// </summary>
  [WordInteropEnumValue("wdFootnotesStory")]
  FootnotesStory = 2,
  /// <summary>
  /// Endnotes story.
  /// </summary>
  [WordInteropEnumValue("wdEndnotesStory")]
  EndnotesStory = 3,
  /// <summary>
  /// Comments story.
  /// </summary>
  [WordInteropEnumValue("wdCommentsStory")]
  CommentsStory = 4,
  /// <summary>
  /// Text frame story.
  /// </summary>
  [WordInteropEnumValue("wdTextFrameStory")]
  TextFrameStory = 5,
  /// <summary>
  /// Even pages header story.
  /// </summary>
  [WordInteropEnumValue("wdEvenPagesHeaderStory")]
  EvenPagesHeaderStory = 6,
  /// <summary>
  /// Primary header story.
  /// </summary>
  [WordInteropEnumValue("wdPrimaryHeaderStory")]
  PrimaryHeaderStory = 7,
  /// <summary>
  /// Even pages footer story.
  /// </summary>
  [WordInteropEnumValue("wdEvenPagesFooterStory")]
  EvenPagesFooterStory = 8,
  /// <summary>
  /// Primary footer story.
  /// </summary>
  [WordInteropEnumValue("wdPrimaryFooterStory")]
  PrimaryFooterStory = 9,
  /// <summary>
  /// First page header story.
  /// </summary>
  [WordInteropEnumValue("wdFirstPageHeaderStory")]
  FirstPageHeaderStory = 10,
  /// <summary>
  /// First page footer story.
  /// </summary>
  [WordInteropEnumValue("wdFirstPageFooterStory")]
  FirstPageFooterStory = 11,
  /// <summary>
  /// Footnote separator story.
  /// </summary>
  [WordInteropEnumValue("wdFootnoteSeparatorStory")]
  FootnoteSeparatorStory = 12,
  /// <summary>
  /// Footnote continuation separator story.
  /// </summary>
  [WordInteropEnumValue("wdFootnoteContinuationSeparatorStory")]
  FootnoteContinuationSeparatorStory = 13,
  /// <summary>
  /// Footnote continuation notice story.
  /// </summary>
  [WordInteropEnumValue("wdFootnoteContinuationNoticeStory")]
  FootnoteContinuationNoticeStory = 14,
  /// <summary>
  /// Endnote separator story.
  /// </summary>
  [WordInteropEnumValue("wdEndnoteSeparatorStory")]
  EndnoteSeparatorStory = 15,
  /// <summary>
  /// Endnote continuation separator story.
  /// </summary>
  [WordInteropEnumValue("wdEndnoteContinuationSeparatorStory")]
  EndnoteContinuationSeparatorStory = 16,
  /// <summary>
  /// Endnote continuation notice story.
  /// </summary>
  [WordInteropEnumValue("wdEndnoteContinuationNoticeStory")]
  EndnoteContinuationNoticeStory = 17
}
