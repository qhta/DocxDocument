namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in Microsoft Word style.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBuiltinStyle")]
public enum BuiltinStyle
{
  /// <summary>
  /// Specifies Word Built-in style for Table of Contents Heading.
  /// </summary>
  [InteropEnumValue("wdStyleTocHeading")]
  TocHeading = -267,
  /// <summary>
  /// Specifies Word Built-in style for Bibliography.
  /// </summary>
  [InteropEnumValue("wdStyleBibliography")]
  Bibliography = -266,
  /// <summary>
  /// Specifies Word Built-in style for Book Title.
  /// </summary>
  [InteropEnumValue("wdStyleBookTitle")]
  BookTitle = -265,
  /// <summary>
  /// Specifies Word Built-in style for Intense Reference.
  /// </summary>
  [InteropEnumValue("wdStyleIntenseReference")]
  IntenseReference = -264,
  /// <summary>
  /// Specifies Word Built-in style for Subtle Reference.
  /// </summary>
  [InteropEnumValue("wdStyleSubtleReference")]
  SubtleReference = -263,
  /// <summary>
  /// Specifies Word Built-in style for Intense Emphasis.
  /// </summary>
  [InteropEnumValue("wdStyleIntenseEmphasis")]
  IntenseEmphasis = -262,
  /// <summary>
  /// Specifies Word Built-in style for Subtle Emphasis.
  /// </summary>
  [InteropEnumValue("wdStyleSubtleEmphasis")]
  SubtleEmphasis = -261,
  /// <summary>
  /// Specifies Word Built-in style for Intense Quote.
  /// </summary>
  [InteropEnumValue("wdStyleIntenseQuote")]
  IntenseQuote = -182,
  /// <summary>
  /// Specifies Word Built-in style for Quote.
  /// </summary>
  [InteropEnumValue("wdStyleQuote")]
  Quote = -181,
  /// <summary>
  /// Specifies Word Built-in style for List Paragraph.
  /// </summary>
  [InteropEnumValue("wdStyleListParagraph")]
  ListParagraph = -180,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 1 Accent 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumList1Accent1")]
  TableMediumList1Accent1 = -178,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 2 Accent 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumShading2Accent1")]
  TableMediumShading2Accent1 = -177,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 1 Accent 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumShading1Accent1")]
  TableMediumShading1Accent1 = -176,
  /// <summary>
  /// Specifies Word Built-in style for Light Grid Accent 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableLightGridAccent1")]
  TableLightGridAccent1 = -175,
  /// <summary>
  /// Specifies Word Built-in style for Light List Accent 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableLightListAccent1")]
  TableLightListAccent1 = -174,
  /// <summary>
  /// Specifies Word Built-in style for Light Shading Accent 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableLightShadingAccent1")]
  TableLightShadingAccent1 = -173,
  /// <summary>
  /// Specifies Word Built-in style for Colorful Grid.
  /// </summary>
  [InteropEnumValue("wdStyleTableColorfulGrid")]
  TableColorfulGrid = -172,
  /// <summary>
  /// Specifies Word Built-in style for Colorful List.
  /// </summary>
  [InteropEnumValue("wdStyleTableColorfulList")]
  TableColorfulList = -171,
  /// <summary>
  /// Specifies Word Built-in style for Colorful Shading.
  /// </summary>
  [InteropEnumValue("wdStyleTableColorfulShading")]
  TableColorfulShading = -170,
  /// <summary>
  /// Specifies Word Built-in style for Dark List.
  /// </summary>
  [InteropEnumValue("wdStyleTableDarkList")]
  TableDarkList = -169,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 3.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumGrid3")]
  TableMediumGrid3 = -168,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 2.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumGrid2")]
  TableMediumGrid2 = -167,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumGrid1")]
  TableMediumGrid1 = -166,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 2.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumList2")]
  TableMediumList2 = -165,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumList1")]
  TableMediumList1 = -164,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 2.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumShading2")]
  TableMediumShading2 = -163,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 1.
  /// </summary>
  [InteropEnumValue("wdStyleTableMediumShading1")]
  TableMediumShading1 = -162,
  /// <summary>
  /// Specifies Word Built-in style for Light Grid.
  /// </summary>
  [InteropEnumValue("wdStyleTableLightGrid")]
  TableLightGrid = -161,
  /// <summary>
  /// Specifies Word Built-in style for Light List.
  /// </summary>
  [InteropEnumValue("wdStyleTableLightList")]
  TableLightList = -160,
  /// <summary>
  /// Specifies Word Built-in style for Light Shading.
  /// </summary>
  [InteropEnumValue("wdStyleTableLightShading")]
  TableLightShading = -159,
  /// <summary>
  /// Specifies Word Built-in style for Normal (applied to an object).
  /// </summary>
  [InteropEnumValue("wdStyleNormalObject")]
  NormalObject = -158,
  /// <summary>
  /// Specifies Word Built-in style for Normal (applied within a table).
  /// </summary>
  [InteropEnumValue("wdStyleNormalTable")]
  NormalTable = -106,
  /// <summary>
  /// Specifies Word Built-in style for HTML Variable.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlVar")]
  HtmlVar = -105,
  /// <summary>
  /// Specifies Word Built-in style for HTML Typewriter.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlTt")]
  HtmlTt = -104,
  /// <summary>
  /// Specifies Word Built-in style for HTML Sample.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlSamp")]
  HtmlSamp = -103,
  /// <summary>
  /// Specifies Word Built-in style for HTML Preformatted.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlPre")]
  HtmlPre = -102,
  /// <summary>
  /// Specifies Word Built-in style for HTML Keyboard.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlKbd")]
  HtmlKbd = -101,
  /// <summary>
  /// Specifies Word Built-in style for HTML Definition.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlDfn")]
  HtmlDfn = -100,
  /// <summary>
  /// Specifies Word Built-in style for HTML Code.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlCode")]
  HtmlCode = -99,
  /// <summary>
  /// Specifies Word Built-in style for HTML City.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlCite")]
  HtmlCite = -98,
  /// <summary>
  /// Specifies Word Built-in style for HTML Address.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlAddress")]
  HtmlAddress = -97,
  /// <summary>
  /// Specifies Word Built-in style for HTML Acronym.
  /// </summary>
  [InteropEnumValue("wdStyleHtmlAcronym")]
  HtmlAcronym = -96,
  /// <summary>
  /// Specifies Word Built-in style for Normal (Web).
  /// </summary>
  [InteropEnumValue("wdStyleHtmlNormal")]
  HtmlNormal = -95,
  /// <summary>
  /// Specifies Word Built-in style for Plain Text.
  /// </summary>
  [InteropEnumValue("wdStylePlainText")]
  PlainText = -91,
  /// <summary>
  /// Specifies Word Built-in style for Document Map.
  /// </summary>
  [InteropEnumValue("wdStyleNavPane")]
  NavPane = -90,
  /// <summary>
  /// Specifies Word Built-in style for Emphasis.
  /// </summary>
  [InteropEnumValue("wdStyleEmphasis")]
  Emphasis = -89,
  /// <summary>
  /// Specifies Word Built-in style for Strong.
  /// </summary>
  [InteropEnumValue("wdStyleStrong")]
  Strong = -88,
  /// <summary>
  /// Specifies Word Built-in style for Followed Hyperlink.
  /// </summary>
  [InteropEnumValue("wdStyleHyperlinkFollowed")]
  HyperlinkFollowed = -87,
  /// <summary>
  /// Specifies Word Built-in style for Hyperlink.
  /// </summary>
  [InteropEnumValue("wdStyleHyperlink")]
  Hyperlink = -86,
  /// <summary>
  /// Specifies Word Built-in style for Block Quotation.
  /// </summary>
  [InteropEnumValue("wdStyleBlockQuotation")]
  BlockQuotation = -85,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent 3.
  /// </summary>
  [InteropEnumValue("wdStyleBodyTextIndent3")]
  BodyTextIndent3 = -84,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent 2.
  /// </summary>
  [InteropEnumValue("wdStyleBodyTextIndent2")]
  BodyTextIndent2 = -83,
  /// <summary>
  /// Specifies Word Built-in style for Body Text 3.
  /// </summary>
  [InteropEnumValue("wdStyleBodyText3")]
  BodyText3 = -82,
  /// <summary>
  /// Specifies Word Built-in style for Body Text 2.
  /// </summary>
  [InteropEnumValue("wdStyleBodyText2")]
  BodyText2 = -81,
  /// <summary>
  /// Specifies Word Built-in style for Note Heading.
  /// </summary>
  [InteropEnumValue("wdStyleNoteHeading")]
  NoteHeading = -80,
  /// <summary>
  /// Specifies Word Built-in style for Body Text First Indent 2.
  /// </summary>
  [InteropEnumValue("wdStyleBodyTextFirstIndent2")]
  BodyTextFirstIndent2 = -79,
  /// <summary>
  /// Specifies Word Built-in style for Body Text First Indent.
  /// </summary>
  [InteropEnumValue("wdStyleBodyTextFirstIndent")]
  BodyTextFirstIndent = -78,
  /// <summary>
  /// Specifies Word Built-in style for Date.
  /// </summary>
  [InteropEnumValue("wdStyleDate")]
  Date = -77,
  /// <summary>
  /// Specifies Word Built-in style for Salutation.
  /// </summary>
  [InteropEnumValue("wdStyleSalutation")]
  Salutation = -76,
  /// <summary>
  /// Specifies Word Built-in style for Subtitle.
  /// </summary>
  [InteropEnumValue("wdStyleSubtitle")]
  Subtitle = -75,
  /// <summary>
  /// Specifies Word Built-in style for Message Header.
  /// </summary>
  [InteropEnumValue("wdStyleMessageHeader")]
  MessageHeader = -74,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 5.
  /// </summary>
  [InteropEnumValue("wdStyleListContinue5")]
  ListContinue5 = -73,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 4.
  /// </summary>
  [InteropEnumValue("wdStyleListContinue4")]
  ListContinue4 = -72,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 3.
  /// </summary>
  [InteropEnumValue("wdStyleListContinue3")]
  ListContinue3 = -71,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 2.
  /// </summary>
  [InteropEnumValue("wdStyleListContinue2")]
  ListContinue2 = -70,
  /// <summary>
  /// Specifies Word Built-in style for List Continue.
  /// </summary>
  [InteropEnumValue("wdStyleListContinue")]
  ListContinue = -69,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent.
  /// </summary>
  [InteropEnumValue("wdStyleBodyTextIndent")]
  BodyTextIndent = -68,
  /// <summary>
  /// Specifies Word Built-in style for Body Text.
  /// </summary>
  [InteropEnumValue("wdStyleBodyText")]
  BodyText = -67,
  /// <summary>
  /// Specifies Word Built-in style for Default Paragraph Font.
  /// </summary>
  [InteropEnumValue("wdStyleDefaultParagraphFont")]
  DefaultParagraphFont = -66,
  /// <summary>
  /// Specifies Word Built-in style for Signature.
  /// </summary>
  [InteropEnumValue("wdStyleSignature")]
  Signature = -65,
  /// <summary>
  /// Specifies Word Built-in style for Closing.
  /// </summary>
  [InteropEnumValue("wdStyleClosing")]
  Closing = -64,
  /// <summary>
  /// Specifies Word Built-in style for Title.
  /// </summary>
  [InteropEnumValue("wdStyleTitle")]
  Title = -63,
  /// <summary>
  /// Specifies Word Built-in style for List Number 5.
  /// </summary>
  [InteropEnumValue("wdStyleListNumber5")]
  ListNumber5 = -62,
  /// <summary>
  /// Specifies Word Built-in style for List Number 4.
  /// </summary>
  [InteropEnumValue("wdStyleListNumber4")]
  ListNumber4 = -61,
  /// <summary>
  /// Specifies Word Built-in style for List Number 3.
  /// </summary>
  [InteropEnumValue("wdStyleListNumber3")]
  ListNumber3 = -60,
  /// <summary>
  /// Specifies Word Built-in style for List Number 2.
  /// </summary>
  [InteropEnumValue("wdStyleListNumber2")]
  ListNumber2 = -59,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 5.
  /// </summary>
  [InteropEnumValue("wdStyleListBullet5")]
  ListBullet5 = -58,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 4.
  /// </summary>
  [InteropEnumValue("wdStyleListBullet4")]
  ListBullet4 = -57,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 3.
  /// </summary>
  [InteropEnumValue("wdStyleListBullet3")]
  ListBullet3 = -56,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 2.
  /// </summary>
  [InteropEnumValue("wdStyleListBullet2")]
  ListBullet2 = -55,
  /// <summary>
  /// Specifies Word Built-in style for List 5.
  /// </summary>
  [InteropEnumValue("wdStyleList5")]
  List5 = -54,
  /// <summary>
  /// Specifies Word Built-in style for List 4.
  /// </summary>
  [InteropEnumValue("wdStyleList4")]
  List4 = -53,
  /// <summary>
  /// Specifies Word Built-in style for List 3.
  /// </summary>
  [InteropEnumValue("wdStyleList3")]
  List3 = -52,
  /// <summary>
  /// Specifies Word Built-in style for List 2.
  /// </summary>
  [InteropEnumValue("wdStyleList2")]
  List2 = -51,
  /// <summary>
  /// Specifies Word Built-in style for List Number.
  /// </summary>
  [InteropEnumValue("wdStyleListNumber")]
  ListNumber = -50,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet.
  /// </summary>
  [InteropEnumValue("wdStyleListBullet")]
  ListBullet = -49,
  /// <summary>
  /// Specifies Word Built-in style for List.
  /// </summary>
  [InteropEnumValue("wdStyleList")]
  List = -48,
  /// <summary>
  /// Specifies Word Built-in style for TOA Heading.
  /// </summary>
  [InteropEnumValue("wdStyleTOAHeading")]
  TOAHeading = -47,
  /// <summary>
  /// Specifies Word Built-in style for Macro Text.
  /// </summary>
  [InteropEnumValue("wdStyleMacroText")]
  MacroText = -46,
  /// <summary>
  /// Specifies Word Built-in style for Table of Authorities.
  /// </summary>
  [InteropEnumValue("wdStyleTableOfAuthorities")]
  TableOfAuthorities = -45,
  /// <summary>
  /// Specifies Word Built-in style for Endnote Text.
  /// </summary>
  [InteropEnumValue("wdStyleEndnoteText")]
  EndnoteText = -44,
  /// <summary>
  /// Specifies Word Built-in style for Endnote Reference.
  /// </summary>
  [InteropEnumValue("wdStyleEndnoteReference")]
  EndnoteReference = -43,
  /// <summary>
  /// Specifies Word Built-in style for Page Number.
  /// </summary>
  [InteropEnumValue("wdStylePageNumber")]
  PageNumber = -42,
  /// <summary>
  /// Specifies Word Built-in style for Line Number.
  /// </summary>
  [InteropEnumValue("wdStyleLineNumber")]
  LineNumber = -41,
  /// <summary>
  /// Specifies Word Built-in style for Comment Reference.
  /// </summary>
  [InteropEnumValue("wdStyleCommentReference")]
  CommentReference = -40,
  /// <summary>
  /// Specifies Word Built-in style for Footnote Reference.
  /// </summary>
  [InteropEnumValue("wdStyleFootnoteReference")]
  FootnoteReference = -39,
  /// <summary>
  /// Specifies Word Built-in style for Envelope Return.
  /// </summary>
  [InteropEnumValue("wdStyleEnvelopeReturn")]
  EnvelopeReturn = -38,
  /// <summary>
  /// Specifies Word Built-in style for Envelope Address.
  /// </summary>
  [InteropEnumValue("wdStyleEnvelopeAddress")]
  EnvelopeAddress = -37,
  /// <summary>
  /// Specifies Word Built-in style for Table of Figures.
  /// </summary>
  [InteropEnumValue("wdStyleTableOfFigures")]
  TableOfFigures = -36,
  /// <summary>
  /// Specifies Word Built-in style for Caption.
  /// </summary>
  [InteropEnumValue("wdStyleCaption")]
  Caption = -35,
  /// <summary>
  /// Specifies Word Built-in style for Index Heading
  /// </summary>
  [InteropEnumValue("wdStyleIndexHeading")]
  IndexHeading = -34,
  /// <summary>
  /// Specifies Word Built-in style for Footer.
  /// </summary>
  [InteropEnumValue("wdStyleFooter")]
  Footer = -33,
  /// <summary>
  /// Specifies Word Built-in style for   Header.
  /// </summary>
  [InteropEnumValue("wdStyleHeader")]
  Header = -32,
  /// <summary>
  /// Specifies Word Built-in style for Comment Text.
  /// </summary>
  [InteropEnumValue("wdStyleCommentText")]
  CommentText = -31,
  /// <summary>
  /// Specifies Word Built-in style for Footnote Text.
  /// </summary>
  [InteropEnumValue("wdStyleFootnoteText")]
  FootnoteText = -30,
  /// <summary>
  /// Specifies Word Built-in style for Normal Indent.
  /// </summary>
  [InteropEnumValue("wdStyleNormalIndent")]
  NormalIndent = -29,
  /// <summary>
  /// Specifies Word Built-in style for TOC 9.
  /// </summary>
  [InteropEnumValue("wdStyleTOC9")]
  TOC9 = -28,
  /// <summary>
  /// Specifies Word Built-in style for TOC 8.
  /// </summary>
  [InteropEnumValue("wdStyleTOC8")]
  TOC8 = -27,
  /// <summary>
  /// Specifies Word Built-in style for TOC 7.
  /// </summary>
  [InteropEnumValue("wdStyleTOC7")]
  TOC7 = -26,
  /// <summary>
  /// Specifies Word Built-in style for TOC 6.
  /// </summary>
  [InteropEnumValue("wdStyleTOC6")]
  TOC6 = -25,
  /// <summary>
  /// Specifies Word Built-in style for TOC 5.
  /// </summary>
  [InteropEnumValue("wdStyleTOC5")]
  TOC5 = -24,
  /// <summary>
  /// Specifies Word Built-in style for TOC 4.
  /// </summary>
  [InteropEnumValue("wdStyleTOC4")]
  TOC4 = -23,
  /// <summary>
  /// Specifies Word Built-in style for TOC 3.
  /// </summary>
  [InteropEnumValue("wdStyleTOC3")]
  TOC3 = -22,
  /// <summary>
  /// Specifies Word Built-in style for TOC 2.
  /// </summary>
  [InteropEnumValue("wdStyleTOC2")]
  TOC2 = -21,
  /// <summary>
  /// Specifies Word Built-in style for TOC 1.
  /// </summary>
  [InteropEnumValue("wdStyleTOC1")]
  TOC1 = -20,
  /// <summary>
  /// Specifies Word Built-in style for Index 9.
  /// </summary>
  [InteropEnumValue("wdStyleIndex9")]
  Index9 = -19,
  /// <summary>
  /// Specifies Word Built-in style for Index 8.
  /// </summary>
  [InteropEnumValue("wdStyleIndex8")]
  Index8 = -18,
  /// <summary>
  /// Specifies Word Built-in style for Index 7.
  /// </summary>
  [InteropEnumValue("wdStyleIndex7")]
  Index7 = -17,
  /// <summary>
  /// Specifies Word Built-in style for Index 6.
  /// </summary>
  [InteropEnumValue("wdStyleIndex6")]
  Index6 = -16,
  /// <summary>
  /// Specifies Word Built-in style for Index 5.
  /// </summary>
  [InteropEnumValue("wdStyleIndex5")]
  Index5 = -15,
  /// <summary>
  /// Specifies Word Built-in style for Index 4.
  /// </summary>
  [InteropEnumValue("wdStyleIndex4")]
  Index4 = -14,
  /// <summary>
  /// Specifies Word Built-in style for Index 3.
  /// </summary>
  [InteropEnumValue("wdStyleIndex3")]
  Index3 = -13,
  /// <summary>
  /// Specifies Word Built-in style for Index 2.
  /// </summary>
  [InteropEnumValue("wdStyleIndex2")]
  Index2 = -12,
  /// <summary>
  /// Specifies Word Built-in style for Index 1.
  /// </summary>
  [InteropEnumValue("wdStyleIndex1")]
  Index1 = -11,
  /// <summary>
  /// Specifies Word Built-in style for Heading 9.
  /// </summary>
  [InteropEnumValue("wdStyleHeading9")]
  Heading9 = -10,
  /// <summary>
  /// Specifies Word Built-in style for Heading 8.  
  /// </summary>
  [InteropEnumValue("wdStyleHeading8")]
  Heading8 = -9,
  /// <summary>
  /// Specifies Word Built-in style for Heading 7.
  /// </summary>
  [InteropEnumValue("wdStyleHeading7")]
  Heading7 = -8,
  /// <summary>
  /// Specifies Word Built-in style for Heading 6.
  /// </summary>
  [InteropEnumValue("wdStyleHeading6")]
  Heading6 = -7,
  /// <summary>
  /// Specifies Word Built-in style for Heading 5.
  /// </summary>
  [InteropEnumValue("wdStyleHeading5")]
  Heading5 = -6,
  /// <summary>
  /// Specifies Word Built-in style for Heading 4.
  /// </summary>
  [InteropEnumValue("wdStyleHeading4")]
  Heading4 = -5,
  /// <summary>
  /// Specifies Word Built-in style for Heading 3.
  /// </summary>
  [InteropEnumValue("wdStyleHeading3")]
  Heading3 = -4,
  /// <summary>
  /// Specifies Word Built-in style for Heading 2.
  /// </summary>
  [InteropEnumValue("wdStyleHeading2")]
  Heading2 = -3,
  /// <summary>
  /// Specifies Word Built-in style for Heading 1.
  /// </summary>
  [InteropEnumValue("wdStyleHeading1")]
  Heading1 = -2,
  /// <summary>
  /// Specifies Word Built-in style for Normal text.
  /// </summary>
  [InteropEnumValue("wdStyleNormal")]
  Normal = -1
}
