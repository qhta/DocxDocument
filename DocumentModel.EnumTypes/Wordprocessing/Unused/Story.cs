namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Story enumeration.
/// Used in types such as CommentReference, BodyType, DocPartBody.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum StoryType
{
  /// <summary>Main text story</summary>
  [OpenXmlEnumValue("MainText")]
  MainText = 1,
  /// <summary>Footnotes story</summary>
  [OpenXmlEnumValue("Footnotes")]
  Footnotes = 2,
  /// <summary>Endnotes story</summary>
  [OpenXmlEnumValue("Endnotes")]
  Endnotes = 3,
  /// <summary>Comments story</summary>
  [OpenXmlEnumValue("Comments")]
  Comments = 4,
  /// <summary>Text frame story</summary>
  [OpenXmlEnumValue("TextFrame")]
  TextFrame = 5,
  /// <summary>Even pages header story</summary>
  [OpenXmlEnumValue("EvenPagesHeader")]
  EvenPagesHeader = 6,
  /// <summary>Primary header story</summary>
  [OpenXmlEnumValue("PrimaryHeader")]
  PrimaryHeader = 7,
  /// <summary>Even pages footer story</summary>
  [OpenXmlEnumValue("EvenPagesFooter")]
  EvenPagesFooter = 8,
  /// <summary>Primary footer story</summary>
  [OpenXmlEnumValue("PrimaryFooter")]
  PrimaryFooter = 9,
  /// <summary>First page header story</summary>
  [OpenXmlEnumValue("FirstPageHeader")]
  FirstPageHeader = 10,
  /// <summary>First page footer story</summary>
  [OpenXmlEnumValue("FirstPageFooter")]
  FirstPageFooter = 11,
  /// <summary>Footnote continuation notice story</summary>
  [OpenXmlEnumValue("FootnoteContinuationNotice")]
  FootnoteContinuationNotice = 12,
  /// <summary>Footnote continuation separator story</summary>
  [OpenXmlEnumValue("FootnoteContinuationSeparator")]
  FootnoteContinuationSeparator = 13,
  /// <summary>Footnote separator story</summary>
  [OpenXmlEnumValue("FootnoteSeparator")]
  FootnoteSeparator = 14,
  /// <summary>Endnote continuation notice story</summary>
  [OpenXmlEnumValue("EndnoteContinuationNotice")]
  EndnoteContinuationNotice = 15,
  /// <summary>Endnote continuation separator story</summary>
  [OpenXmlEnumValue("EndnoteContinuationSeparator")]
  EndnoteContinuationSeparator = 16,
  /// <summary>Endnote separator story</summary>
  [OpenXmlEnumValue("EndnoteSeparator")]
  EndnoteSeparator = 17
}
