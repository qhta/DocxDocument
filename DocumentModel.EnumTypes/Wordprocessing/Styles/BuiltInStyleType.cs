namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies built-in style identifiers.
/// </summary>
[OpenXmlNotMapped]
public enum BuiltInStyleType
{
  /// <summary>Normal style</summary>
  Normal = -1,
  /// <summary>Heading 1</summary>
  Heading1 = -2,
  /// <summary>Heading 2</summary>
  Heading2 = -3,
  /// <summary>Heading 3</summary>
  Heading3 = -4,
  /// <summary>Heading 4</summary>
  Heading4 = -5,
  /// <summary>Heading 5</summary>
  Heading5 = -6,
  /// <summary>Heading 6</summary>
  Heading6 = -7,
  /// <summary>Heading 7</summary>
  Heading7 = -8,
  /// <summary>Heading 8</summary>
  Heading8 = -9,
  /// <summary>Heading 9</summary>
  Heading9 = -10,
  /// <summary>Index 1</summary>
  Index1 = -11,
  /// <summary>Index 2</summary>
  Index2 = -12,
  /// <summary>Table of contents 1</summary>
  TOC1 = -13,
  /// <summary>Table of contents 2</summary>
  TOC2 = -14,
  /// <summary>Table of contents 3</summary>
  TOC3 = -15,
  /// <summary>Normal indent</summary>
  NormalIndent = -16,
  /// <summary>Footnote text</summary>
  FootnoteText = -17,
  /// <summary>Comment text</summary>
  CommentText = -18,
  /// <summary>Header</summary>
  Header = -19,
  /// <summary>Footer</summary>
  Footer = -20,
  /// <summary>Body text</summary>
  BodyText = -67,
  /// <summary>Title</summary>
  Title = -63,
  /// <summary>Subtitle</summary>
  Subtitle = -75,
  /// <summary>Quote</summary>
  Quote = -181,
  /// <summary>List paragraph</summary>
  ListParagraph = -180,
  /// <summary>No style (no list)</summary>
  NoList = -159
}