namespace DocumentModel.Wordprocessing;

/// <summary>
/// Story types in a document.
/// </summary>
public enum StoryKind
{
  /// <summary>Main text story</summary>
  MainText = 1,
  /// <summary>Footnotes story</summary>
  Footnotes = 2,
  /// <summary>Endnotes story</summary>
  Endnotes = 3,
  /// <summary>Comments story</summary>
  Comments = 4,
  /// <summary>Text frame story</summary>
  TextFrame = 5,
  /// <summary>Even pages header story</summary>
  EvenPagesHeader = 6,
  /// <summary>Primary header story</summary>
  PrimaryHeader = 7,
  /// <summary>Even pages footer story</summary>
  EvenPagesFooter = 8,
  /// <summary>Primary footer story</summary>
  PrimaryFooter = 9,
  /// <summary>First page header story</summary>
  FirstPageHeader = 10,
  /// <summary>First page footer story</summary>
  FirstPageFooter = 11,
  /// <summary>Footnote continuation notice story</summary>
  FootnoteContinuationNotice = 12,
  /// <summary>Footnote continuation separator story</summary>
  FootnoteContinuationSeparator = 13,
  /// <summary>Footnote separator story</summary>
  FootnoteSeparator = 14,
  /// <summary>Endnote continuation notice story</summary>
  EndnoteContinuationNotice = 15,
  /// <summary>Endnote continuation separator story</summary>
  EndnoteContinuationSeparator = 16,
  /// <summary>Endnote separator story</summary>
  EndnoteSeparator = 17
}