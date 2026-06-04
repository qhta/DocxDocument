namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the story type of a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstorytype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdStoryType))]
public enum StoryType
{
  /// <summary>
  /// Main text story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdMainTextStory))]
  MainTextStory = 1,
  /// <summary>
  /// Footnotes story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdFootnotesStory))]
  FootnotesStory = 2,
  /// <summary>
  /// Endnotes story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdEndnotesStory))]
  EndnotesStory = 3,
  /// <summary>
  /// Comments story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdCommentsStory))]
  CommentsStory = 4,
  /// <summary>
  /// Text frame story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdTextFrameStory))]
  TextFrameStory = 5,
  /// <summary>
  /// Even pages header story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdEvenPagesHeaderStory))]
  EvenPagesHeaderStory = 6,
  /// <summary>
  /// Primary header story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdPrimaryHeaderStory))]
  PrimaryHeaderStory = 7,
  /// <summary>
  /// Even pages footer story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdEvenPagesFooterStory))]
  EvenPagesFooterStory = 8,
  /// <summary>
  /// Primary footer story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdPrimaryFooterStory))]
  PrimaryFooterStory = 9,
  /// <summary>
  /// First page header story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdFirstPageHeaderStory))]
  FirstPageHeaderStory = 10,
  /// <summary>
  /// First page footer story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdFirstPageFooterStory))]
  FirstPageFooterStory = 11,
  /// <summary>
  /// Footnote separator story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdFootnoteSeparatorStory))]
  FootnoteSeparatorStory = 12,
  /// <summary>
  /// Footnote continuation separator story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdFootnoteContinuationSeparatorStory))]
  FootnoteContinuationSeparatorStory = 13,
  /// <summary>
  /// Footnote continuation notice story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdFootnoteContinuationNoticeStory))]
  FootnoteContinuationNoticeStory = 14,
  /// <summary>
  /// Endnote separator story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdEndnoteSeparatorStory))]
  EndnoteSeparatorStory = 15,
  /// <summary>
  /// Endnote continuation separator story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdEndnoteContinuationSeparatorStory))]
  EndnoteContinuationSeparatorStory = 16,
  /// <summary>
  /// Endnote continuation notice story.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdStoryType.wdEndnoteContinuationNoticeStory))]
  EndnoteContinuationNoticeStory = 17
}
