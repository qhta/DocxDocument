namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the story type of a selection or item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdstorytype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdStoryType
{
  /// <summary>
  /// Main text story.
  /// </summary>
  MainTextStory = 1,
  /// <summary>
  /// Footnotes story.
  /// </summary>
  FootnotesStory = 2,
  /// <summary>
  /// Endnotes story.
  /// </summary>
  EndnotesStory = 3,
  /// <summary>
  /// Comments story.
  /// </summary>
  CommentsStory = 4,
  /// <summary>
  /// Text frame story.
  /// </summary>
  TextFrameStory = 5,
  /// <summary>
  /// Even pages header story.
  /// </summary>
  EvenPagesHeaderStory = 6,
  /// <summary>
  /// Primary header story.
  /// </summary>
  PrimaryHeaderStory = 7,
  /// <summary>
  /// Even pages footer story.
  /// </summary>
  EvenPagesFooterStory = 8,
  /// <summary>
  /// Primary footer story.
  /// </summary>
  PrimaryFooterStory = 9,
  /// <summary>
  /// First page header story.
  /// </summary>
  FirstPageHeaderStory = 10,
  /// <summary>
  /// First page footer story.
  /// </summary>
  FirstPageFooterStory = 11,
  /// <summary>
  /// Specifies the story type of a selection or item.
  /// </summary>
  FootnoteSeparatorStory = 12,
  /// <summary>
  /// Specifies the story type of a selection or item.
  /// </summary>
  FootnoteContinuationSeparatorStory = 13,
  /// <summary>
  /// Specifies the story type of a selection or item.
  /// </summary>
  FootnoteContinuationNoticeStory = 14,
  /// <summary>
  /// Specifies the story type of a selection or item.
  /// </summary>
  EndnoteSeparatorStory = 15,
  /// <summary>
  /// Specifies the story type of a selection or item.
  /// </summary>
  EndnoteContinuationSeparatorStory = 16,
  /// <summary>
  /// Specifies the story type of a selection or item.
  /// </summary>
  EndnoteContinuationNoticeStory = 17
}
