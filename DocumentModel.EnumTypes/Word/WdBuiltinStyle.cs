namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in Microsoft Word style.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdBuiltinStyle
{
  /// <summary>
  /// TOC Heading.
  /// </summary>
  TocHeading = -267,
  /// <summary>
  /// Bibliography.
  /// </summary>
  Bibliography = -266,
  /// <summary>
  /// Book title.
  /// </summary>
  BookTitle = -265,
  /// <summary>
  /// Intense Reference.
  /// </summary>
  IntenseReference = -264,
  /// <summary>
  /// Subtle Reference.
  /// </summary>
  SubtleReference = -263,
  /// <summary>
  /// Intense Emphasis.
  /// </summary>
  IntenseEmphasis = -262,
  /// <summary>
  /// Subtle Emphasis.
  /// </summary>
  SubtleEmphasis = -261,
  /// <summary>
  /// Intense Quote.
  /// </summary>
  IntenseQuote = -182,
  /// <summary>
  /// Quote.
  /// </summary>
  Quote = -181,
  /// <summary>
  /// List Paragraph.
  /// </summary>
  ListParagraph = -180,
  /// <summary>
  /// Medium List 1 Accent 1.
  /// </summary>
  TableMediumList1Accent1 = -178,
  /// <summary>
  /// Medium Shading 2 Accent 1.
  /// </summary>
  TableMediumShading2Accent1 = -177,
  /// <summary>
  /// Medium List 1 Accent 1.
  /// </summary>
  TableMediumShading1Accent1 = -176,
  /// <summary>
  /// Light Grid Accent 1.
  /// </summary>
  TableLightGridAccent1 = -175,
  /// <summary>
  /// Light List Accent 1.
  /// </summary>
  TableLightListAccent1 = -174,
  /// <summary>
  /// Light Shading Accent 1.
  /// </summary>
  TableLightShadingAccent1 = -173,
  /// <summary>
  /// Colorful Grid.
  /// </summary>
  TableColorfulGrid = -172,
  /// <summary>
  /// Colorful List.
  /// </summary>
  TableColorfulList = -171,
  /// <summary>
  /// Colorful Shading.
  /// </summary>
  TableColorfulShading = -170,
  /// <summary>
  /// Dark List.
  /// </summary>
  TableDarkList = -169,
  /// <summary>
  /// Medium Grid 3.
  /// </summary>
  TableMediumGrid3 = -168,
  /// <summary>
  /// Medium Grid 2.
  /// </summary>
  TableMediumGrid2 = -167,
  /// <summary>
  /// Medium Grid 1.
  /// </summary>
  TableMediumGrid1 = -166,
  /// <summary>
  /// Medium List 2.
  /// </summary>
  TableMediumList2 = -165,
  /// <summary>
  /// Medium List 1.
  /// </summary>
  TableMediumList1 = -164,
  /// <summary>
  /// Medium Shading 2.
  /// </summary>
  TableMediumShading2 = -163,
  /// <summary>
  /// Medium Shading 1.
  /// </summary>
  TableMediumShading1 = -162,
  /// <summary>
  /// Light Grid.
  /// </summary>
  TableLightGrid = -161,
  /// <summary>
  /// Light List.
  /// </summary>
  TableLightList = -160,
  /// <summary>
  /// Light Shading.
  /// </summary>
  TableLightShading = -159,
  /// <summary>
  /// Normal (applied to an object).
  /// </summary>
  NormalObject = -158,
  /// <summary>
  /// Normal (applied within a table).
  /// </summary>
  NormalTable = -106,
  /// <summary>
  /// HTML Variable.
  /// </summary>
  HtmlVar = -105,
  /// <summary>
  /// HTML Typewriter.
  /// </summary>
  HtmlTt = -104,
  /// <summary>
  /// HTML Sample.
  /// </summary>
  HtmlSamp = -103,
  /// <summary>
  /// HTML Preformatted.
  /// </summary>
  HtmlPre = -102,
  /// <summary>
  /// HTML Keyboard.
  /// </summary>
  HtmlKbd = -101,
  /// <summary>
  /// HTML Definition.
  /// </summary>
  HtmlDfn = -100,
  /// <summary>
  /// HTML Code.
  /// </summary>
  HtmlCode = -99,
  /// <summary>
  /// HTML City.
  /// </summary>
  HtmlCite = -98,
  /// <summary>
  /// HTML Address.
  /// </summary>
  HtmlAddress = -97,
  /// <summary>
  /// HTML Acronym.
  /// </summary>
  HtmlAcronym = -96,
  /// <summary>
  /// Normal (Web).
  /// </summary>
  HtmlNormal = -95,
  /// <summary>
  /// Plain Text.
  /// </summary>
  PlainText = -91,
  /// <summary>
  /// Document Map.
  /// </summary>
  NavPane = -90,
  /// <summary>
  /// Emphasis.
  /// </summary>
  Emphasis = -89,
  /// <summary>
  /// Strong.
  /// </summary>
  Strong = -88,
  /// <summary>
  /// Followed Hyperlink.
  /// </summary>
  HyperlinkFollowed = -87,
  /// <summary>
  /// Hyperlink.
  /// </summary>
  Hyperlink = -86,
  /// <summary>
  /// Block Quotation.
  /// </summary>
  BlockQuotation = -85,
  /// <summary>
  /// Body Text Indent 3.
  /// </summary>
  BodyTextIndent3 = -84,
  /// <summary>
  /// Body Text Indent 2.
  /// </summary>
  BodyTextIndent2 = -83,
  /// <summary>
  /// Body Text 3.
  /// </summary>
  BodyText3 = -82,
  /// <summary>
  /// Body Text 2.
  /// </summary>
  BodyText2 = -81,
  /// <summary>
  /// Note Heading.
  /// </summary>
  NoteHeading = -80,
  /// <summary>
  /// Body Text First Indent 2.
  /// </summary>
  BodyTextFirstIndent2 = -79,
  /// <summary>
  /// Body Text First Indent.
  /// </summary>
  BodyTextFirstIndent = -78,
  /// <summary>
  /// Date.
  /// </summary>
  Date = -77,
  /// <summary>
  /// Salutation.
  /// </summary>
  Salutation = -76,
  /// <summary>
  /// Subtitle.
  /// </summary>
  Subtitle = -75,
  /// <summary>
  /// Message Header.
  /// </summary>
  MessageHeader = -74,
  /// <summary>
  /// List Continue 5.
  /// </summary>
  ListContinue5 = -73,
  /// <summary>
  /// List Continue 4.
  /// </summary>
  ListContinue4 = -72,
  /// <summary>
  /// List Continue 3.
  /// </summary>
  ListContinue3 = -71,
  /// <summary>
  /// List Continue 2.
  /// </summary>
  ListContinue2 = -70,
  /// <summary>
  /// List Continue.
  /// </summary>
  ListContinue = -69,
  /// <summary>
  /// Body Text Indent.
  /// </summary>
  BodyTextIndent = -68,
  /// <summary>
  /// Body Text.
  /// </summary>
  BodyText = -67,
  /// <summary>
  /// Default Paragraph Font.
  /// </summary>
  DefaultParagraphFont = -66,
  /// <summary>
  /// Signature.
  /// </summary>
  Signature = -65,
  /// <summary>
  /// Closing.
  /// </summary>
  Closing = -64,
  /// <summary>
  /// Title.
  /// </summary>
  Title = -63,
  /// <summary>
  /// List Number 5.
  /// </summary>
  ListNumber5 = -62,
  /// <summary>
  /// List Number 4.
  /// </summary>
  ListNumber4 = -61,
  /// <summary>
  /// List Number 3.
  /// </summary>
  ListNumber3 = -60,
  /// <summary>
  /// List Number 2.
  /// </summary>
  ListNumber2 = -59,
  /// <summary>
  /// List Bullet 5.
  /// </summary>
  ListBullet5 = -58,
  /// <summary>
  /// List Bullet 4.
  /// </summary>
  ListBullet4 = -57,
  /// <summary>
  /// List Bullet 3.
  /// </summary>
  ListBullet3 = -56,
  /// <summary>
  /// List Bullet 2.
  /// </summary>
  ListBullet2 = -55,
  /// <summary>
  /// List 5.
  /// </summary>
  List5 = -54,
  /// <summary>
  /// List 4.
  /// </summary>
  List4 = -53,
  /// <summary>
  /// List 3.
  /// </summary>
  List3 = -52,
  /// <summary>
  /// List 2.
  /// </summary>
  List2 = -51,
  /// <summary>
  /// List Number.
  /// </summary>
  ListNumber = -50,
  /// <summary>
  /// List Bullet.
  /// </summary>
  ListBullet = -49,
  /// <summary>
  /// List.
  /// </summary>
  List = -48,
  /// <summary>
  /// TOA Heading.
  /// </summary>
  TOAHeading = -47,
  /// <summary>
  /// Macro Text.
  /// </summary>
  MacroText = -46,
  /// <summary>
  /// Table of Authorities.
  /// </summary>
  TableOfAuthorities = -45,
  /// <summary>
  /// Endnote Text.
  /// </summary>
  EndnoteText = -44,
  /// <summary>
  /// Endnote Reference.
  /// </summary>
  EndnoteReference = -43,
  /// <summary>
  /// Page Number.
  /// </summary>
  PageNumber = -42,
  /// <summary>
  /// Line Number.
  /// </summary>
  LineNumber = -41,
  /// <summary>
  /// Comment Reference.
  /// </summary>
  CommentReference = -40,
  /// <summary>
  /// Footnote Reference.
  /// </summary>
  FootnoteReference = -39,
  /// <summary>
  /// Envelope Return.
  /// </summary>
  EnvelopeReturn = -38,
  /// <summary>
  /// Envelope Address.
  /// </summary>
  EnvelopeAddress = -37,
  /// <summary>
  /// Table of Figures.
  /// </summary>
  TableOfFigures = -36,
  /// <summary>
  /// Caption.
  /// </summary>
  Caption = -35,
  /// <summary>
  /// Index Heading
  /// </summary>
  IndexHeading = -34,
  /// <summary>
  /// Footer.
  /// </summary>
  Footer = -33,
  /// <summary>
  /// Header.
  /// </summary>
  Header = -32,
  /// <summary>
  /// Comment Text.
  /// </summary>
  CommentText = -31,
  /// <summary>
  /// Footnote Text.
  /// </summary>
  FootnoteText = -30,
  /// <summary>
  /// Normal Indent.
  /// </summary>
  NormalIndent = -29,
  /// <summary>
  /// TOC 9.
  /// </summary>
  TOC9 = -28,
  /// <summary>
  /// TOC 8.
  /// </summary>
  TOC8 = -27,
  /// <summary>
  /// TOC 7.
  /// </summary>
  TOC7 = -26,
  /// <summary>
  /// TOC 6.
  /// </summary>
  TOC6 = -25,
  /// <summary>
  /// TOC 5.
  /// </summary>
  TOC5 = -24,
  /// <summary>
  /// TOC 4.
  /// </summary>
  TOC4 = -23,
  /// <summary>
  /// TOC 3.
  /// </summary>
  TOC3 = -22,
  /// <summary>
  /// TOC 2.
  /// </summary>
  TOC2 = -21,
  /// <summary>
  /// TOC 1.
  /// </summary>
  TOC1 = -20,
  /// <summary>
  /// Index 9.
  /// </summary>
  Index9 = -19,
  /// <summary>
  /// Index8.
  /// </summary>
  Index8 = -18,
  /// <summary>
  /// Index 7.
  /// </summary>
  Index7 = -17,
  /// <summary>
  /// Index 6.
  /// </summary>
  Index6 = -16,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Index5 = -15,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Index4 = -14,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Index3 = -13,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Index2 = -12,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Index1 = -11,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading9 = -10,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading8 = -9,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading7 = -8,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading6 = -7,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading5 = -6,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading4 = -5,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading3 = -4,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading2 = -3,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Heading1 = -2,
  /// <summary>
  /// Specifies a built-in Microsoft Word style.
  /// </summary>
  Normal = -1
}
