namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in Microsoft Word style.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBuiltinStyle")]
public enum BuiltinStyle
{
  /// <summary>
  /// Specifies Word Built-in style for Table of Contents Heading.
  /// </summary>
  [WordInteropEnumValue("wdStyleTocHeading")]
  TocHeading = -267,
  /// <summary>
  /// Specifies Word Built-in style for Bibliography.
  /// </summary>
  [WordInteropEnumValue("wdStyleBibliography")]
  Bibliography = -266,
  /// <summary>
  /// Specifies Word Built-in style for Book Title.
  /// </summary>
  [WordInteropEnumValue("wdStyleBookTitle")]
  BookTitle = -265,
  /// <summary>
  /// Specifies Word Built-in style for Intense Reference.
  /// </summary>
  [WordInteropEnumValue("wdStyleIntenseReference")]
  IntenseReference = -264,
  /// <summary>
  /// Specifies Word Built-in style for Subtle Reference.
  /// </summary>
  [WordInteropEnumValue("wdStyleSubtleReference")]
  SubtleReference = -263,
  /// <summary>
  /// Specifies Word Built-in style for Intense Emphasis.
  /// </summary>
  [WordInteropEnumValue("wdStyleIntenseEmphasis")]
  IntenseEmphasis = -262,
  /// <summary>
  /// Specifies Word Built-in style for Subtle Emphasis.
  /// </summary>
  [WordInteropEnumValue("wdStyleSubtleEmphasis")]
  SubtleEmphasis = -261,
  /// <summary>
  /// Specifies Word Built-in style for Intense Quote.
  /// </summary>
  [WordInteropEnumValue("wdStyleIntenseQuote")]
  IntenseQuote = -182,
  /// <summary>
  /// Specifies Word Built-in style for Quote.
  /// </summary>
  [WordInteropEnumValue("wdStyleQuote")]
  Quote = -181,
  /// <summary>
  /// Specifies Word Built-in style for List Paragraph.
  /// </summary>
  [WordInteropEnumValue("wdStyleListParagraph")]
  ListParagraph = -180,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 1 Accent 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumList1Accent1")]
  TableMediumList1Accent1 = -178,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 2 Accent 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumShading2Accent1")]
  TableMediumShading2Accent1 = -177,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 1 Accent 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumShading1Accent1")]
  TableMediumShading1Accent1 = -176,
  /// <summary>
  /// Specifies Word Built-in style for Light Grid Accent 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableLightGridAccent1")]
  TableLightGridAccent1 = -175,
  /// <summary>
  /// Specifies Word Built-in style for Light List Accent 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableLightListAccent1")]
  TableLightListAccent1 = -174,
  /// <summary>
  /// Specifies Word Built-in style for Light Shading Accent 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableLightShadingAccent1")]
  TableLightShadingAccent1 = -173,
  /// <summary>
  /// Specifies Word Built-in style for Colorful Grid.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableColorfulGrid")]
  TableColorfulGrid = -172,
  /// <summary>
  /// Specifies Word Built-in style for Colorful List.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableColorfulList")]
  TableColorfulList = -171,
  /// <summary>
  /// Specifies Word Built-in style for Colorful Shading.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableColorfulShading")]
  TableColorfulShading = -170,
  /// <summary>
  /// Specifies Word Built-in style for Dark List.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableDarkList")]
  TableDarkList = -169,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumGrid3")]
  TableMediumGrid3 = -168,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumGrid2")]
  TableMediumGrid2 = -167,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumGrid1")]
  TableMediumGrid1 = -166,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumList2")]
  TableMediumList2 = -165,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumList1")]
  TableMediumList1 = -164,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumShading2")]
  TableMediumShading2 = -163,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableMediumShading1")]
  TableMediumShading1 = -162,
  /// <summary>
  /// Specifies Word Built-in style for Light Grid.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableLightGrid")]
  TableLightGrid = -161,
  /// <summary>
  /// Specifies Word Built-in style for Light List.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableLightList")]
  TableLightList = -160,
  /// <summary>
  /// Specifies Word Built-in style for Light Shading.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableLightShading")]
  TableLightShading = -159,
  /// <summary>
  /// Specifies Word Built-in style for Normal (applied to an object).
  /// </summary>
  [WordInteropEnumValue("wdStyleNormalObject")]
  NormalObject = -158,
  /// <summary>
  /// Specifies Word Built-in style for Normal (applied within a table).
  /// </summary>
  [WordInteropEnumValue("wdStyleNormalTable")]
  NormalTable = -106,
  /// <summary>
  /// Specifies Word Built-in style for HTML Variable.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlVar")]
  HtmlVar = -105,
  /// <summary>
  /// Specifies Word Built-in style for HTML Typewriter.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlTt")]
  HtmlTt = -104,
  /// <summary>
  /// Specifies Word Built-in style for HTML Sample.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlSamp")]
  HtmlSamp = -103,
  /// <summary>
  /// Specifies Word Built-in style for HTML Preformatted.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlPre")]
  HtmlPre = -102,
  /// <summary>
  /// Specifies Word Built-in style for HTML Keyboard.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlKbd")]
  HtmlKbd = -101,
  /// <summary>
  /// Specifies Word Built-in style for HTML Definition.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlDfn")]
  HtmlDfn = -100,
  /// <summary>
  /// Specifies Word Built-in style for HTML Code.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlCode")]
  HtmlCode = -99,
  /// <summary>
  /// Specifies Word Built-in style for HTML City.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlCite")]
  HtmlCite = -98,
  /// <summary>
  /// Specifies Word Built-in style for HTML Address.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlAddress")]
  HtmlAddress = -97,
  /// <summary>
  /// Specifies Word Built-in style for HTML Acronym.
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlAcronym")]
  HtmlAcronym = -96,
  /// <summary>
  /// Specifies Word Built-in style for Normal (Web).
  /// </summary>
  [WordInteropEnumValue("wdStyleHtmlNormal")]
  HtmlNormal = -95,
  /// <summary>
  /// Specifies Word Built-in style for Plain Text.
  /// </summary>
  [WordInteropEnumValue("wdStylePlainText")]
  PlainText = -91,
  /// <summary>
  /// Specifies Word Built-in style for Document Map.
  /// </summary>
  [WordInteropEnumValue("wdStyleNavPane")]
  NavPane = -90,
  /// <summary>
  /// Specifies Word Built-in style for Emphasis.
  /// </summary>
  [WordInteropEnumValue("wdStyleEmphasis")]
  Emphasis = -89,
  /// <summary>
  /// Specifies Word Built-in style for Strong.
  /// </summary>
  [WordInteropEnumValue("wdStyleStrong")]
  Strong = -88,
  /// <summary>
  /// Specifies Word Built-in style for Followed Hyperlink.
  /// </summary>
  [WordInteropEnumValue("wdStyleHyperlinkFollowed")]
  HyperlinkFollowed = -87,
  /// <summary>
  /// Specifies Word Built-in style for Hyperlink.
  /// </summary>
  [WordInteropEnumValue("wdStyleHyperlink")]
  Hyperlink = -86,
  /// <summary>
  /// Specifies Word Built-in style for Block Quotation.
  /// </summary>
  [WordInteropEnumValue("wdStyleBlockQuotation")]
  BlockQuotation = -85,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyTextIndent3")]
  BodyTextIndent3 = -84,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyTextIndent2")]
  BodyTextIndent2 = -83,
  /// <summary>
  /// Specifies Word Built-in style for Body Text 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyText3")]
  BodyText3 = -82,
  /// <summary>
  /// Specifies Word Built-in style for Body Text 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyText2")]
  BodyText2 = -81,
  /// <summary>
  /// Specifies Word Built-in style for Note Heading.
  /// </summary>
  [WordInteropEnumValue("wdStyleNoteHeading")]
  NoteHeading = -80,
  /// <summary>
  /// Specifies Word Built-in style for Body Text First Indent 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyTextFirstIndent2")]
  BodyTextFirstIndent2 = -79,
  /// <summary>
  /// Specifies Word Built-in style for Body Text First Indent.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyTextFirstIndent")]
  BodyTextFirstIndent = -78,
  /// <summary>
  /// Specifies Word Built-in style for Date.
  /// </summary>
  [WordInteropEnumValue("wdStyleDate")]
  Date = -77,
  /// <summary>
  /// Specifies Word Built-in style for Salutation.
  /// </summary>
  [WordInteropEnumValue("wdStyleSalutation")]
  Salutation = -76,
  /// <summary>
  /// Specifies Word Built-in style for Subtitle.
  /// </summary>
  [WordInteropEnumValue("wdStyleSubtitle")]
  Subtitle = -75,
  /// <summary>
  /// Specifies Word Built-in style for Message Header.
  /// </summary>
  [WordInteropEnumValue("wdStyleMessageHeader")]
  MessageHeader = -74,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleListContinue5")]
  ListContinue5 = -73,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleListContinue4")]
  ListContinue4 = -72,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleListContinue3")]
  ListContinue3 = -71,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleListContinue2")]
  ListContinue2 = -70,
  /// <summary>
  /// Specifies Word Built-in style for List Continue.
  /// </summary>
  [WordInteropEnumValue("wdStyleListContinue")]
  ListContinue = -69,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyTextIndent")]
  BodyTextIndent = -68,
  /// <summary>
  /// Specifies Word Built-in style for Body Text.
  /// </summary>
  [WordInteropEnumValue("wdStyleBodyText")]
  BodyText = -67,
  /// <summary>
  /// Specifies Word Built-in style for Default Paragraph Font.
  /// </summary>
  [WordInteropEnumValue("wdStyleDefaultParagraphFont")]
  DefaultParagraphFont = -66,
  /// <summary>
  /// Specifies Word Built-in style for Signature.
  /// </summary>
  [WordInteropEnumValue("wdStyleSignature")]
  Signature = -65,
  /// <summary>
  /// Specifies Word Built-in style for Closing.
  /// </summary>
  [WordInteropEnumValue("wdStyleClosing")]
  Closing = -64,
  /// <summary>
  /// Specifies Word Built-in style for Title.
  /// </summary>
  [WordInteropEnumValue("wdStyleTitle")]
  Title = -63,
  /// <summary>
  /// Specifies Word Built-in style for List Number 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleListNumber5")]
  ListNumber5 = -62,
  /// <summary>
  /// Specifies Word Built-in style for List Number 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleListNumber4")]
  ListNumber4 = -61,
  /// <summary>
  /// Specifies Word Built-in style for List Number 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleListNumber3")]
  ListNumber3 = -60,
  /// <summary>
  /// Specifies Word Built-in style for List Number 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleListNumber2")]
  ListNumber2 = -59,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleListBullet5")]
  ListBullet5 = -58,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleListBullet4")]
  ListBullet4 = -57,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleListBullet3")]
  ListBullet3 = -56,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleListBullet2")]
  ListBullet2 = -55,
  /// <summary>
  /// Specifies Word Built-in style for List 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleList5")]
  List5 = -54,
  /// <summary>
  /// Specifies Word Built-in style for List 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleList4")]
  List4 = -53,
  /// <summary>
  /// Specifies Word Built-in style for List 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleList3")]
  List3 = -52,
  /// <summary>
  /// Specifies Word Built-in style for List 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleList2")]
  List2 = -51,
  /// <summary>
  /// Specifies Word Built-in style for List Number.
  /// </summary>
  [WordInteropEnumValue("wdStyleListNumber")]
  ListNumber = -50,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet.
  /// </summary>
  [WordInteropEnumValue("wdStyleListBullet")]
  ListBullet = -49,
  /// <summary>
  /// Specifies Word Built-in style for List.
  /// </summary>
  [WordInteropEnumValue("wdStyleList")]
  List = -48,
  /// <summary>
  /// Specifies Word Built-in style for TOA Heading.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOAHeading")]
  TOAHeading = -47,
  /// <summary>
  /// Specifies Word Built-in style for Macro Text.
  /// </summary>
  [WordInteropEnumValue("wdStyleMacroText")]
  MacroText = -46,
  /// <summary>
  /// Specifies Word Built-in style for Table of Authorities.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableOfAuthorities")]
  TableOfAuthorities = -45,
  /// <summary>
  /// Specifies Word Built-in style for Endnote Text.
  /// </summary>
  [WordInteropEnumValue("wdStyleEndnoteText")]
  EndnoteText = -44,
  /// <summary>
  /// Specifies Word Built-in style for Endnote Reference.
  /// </summary>
  [WordInteropEnumValue("wdStyleEndnoteReference")]
  EndnoteReference = -43,
  /// <summary>
  /// Specifies Word Built-in style for Page Number.
  /// </summary>
  [WordInteropEnumValue("wdStylePageNumber")]
  PageNumber = -42,
  /// <summary>
  /// Specifies Word Built-in style for Line Number.
  /// </summary>
  [WordInteropEnumValue("wdStyleLineNumber")]
  LineNumber = -41,
  /// <summary>
  /// Specifies Word Built-in style for Comment Reference.
  /// </summary>
  [WordInteropEnumValue("wdStyleCommentReference")]
  CommentReference = -40,
  /// <summary>
  /// Specifies Word Built-in style for Footnote Reference.
  /// </summary>
  [WordInteropEnumValue("wdStyleFootnoteReference")]
  FootnoteReference = -39,
  /// <summary>
  /// Specifies Word Built-in style for Envelope Return.
  /// </summary>
  [WordInteropEnumValue("wdStyleEnvelopeReturn")]
  EnvelopeReturn = -38,
  /// <summary>
  /// Specifies Word Built-in style for Envelope Address.
  /// </summary>
  [WordInteropEnumValue("wdStyleEnvelopeAddress")]
  EnvelopeAddress = -37,
  /// <summary>
  /// Specifies Word Built-in style for Table of Figures.
  /// </summary>
  [WordInteropEnumValue("wdStyleTableOfFigures")]
  TableOfFigures = -36,
  /// <summary>
  /// Specifies Word Built-in style for Caption.
  /// </summary>
  [WordInteropEnumValue("wdStyleCaption")]
  Caption = -35,
  /// <summary>
  /// Specifies Word Built-in style for Index Heading
  /// </summary>
  [WordInteropEnumValue("wdStyleIndexHeading")]
  IndexHeading = -34,
  /// <summary>
  /// Specifies Word Built-in style for Footer.
  /// </summary>
  [WordInteropEnumValue("wdStyleFooter")]
  Footer = -33,
  /// <summary>
  /// Specifies Word Built-in style for   Header.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeader")]
  Header = -32,
  /// <summary>
  /// Specifies Word Built-in style for Comment Text.
  /// </summary>
  [WordInteropEnumValue("wdStyleCommentText")]
  CommentText = -31,
  /// <summary>
  /// Specifies Word Built-in style for Footnote Text.
  /// </summary>
  [WordInteropEnumValue("wdStyleFootnoteText")]
  FootnoteText = -30,
  /// <summary>
  /// Specifies Word Built-in style for Normal Indent.
  /// </summary>
  [WordInteropEnumValue("wdStyleNormalIndent")]
  NormalIndent = -29,
  /// <summary>
  /// Specifies Word Built-in style for TOC 9.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC9")]
  TOC9 = -28,
  /// <summary>
  /// Specifies Word Built-in style for TOC 8.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC8")]
  TOC8 = -27,
  /// <summary>
  /// Specifies Word Built-in style for TOC 7.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC7")]
  TOC7 = -26,
  /// <summary>
  /// Specifies Word Built-in style for TOC 6.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC6")]
  TOC6 = -25,
  /// <summary>
  /// Specifies Word Built-in style for TOC 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC5")]
  TOC5 = -24,
  /// <summary>
  /// Specifies Word Built-in style for TOC 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC4")]
  TOC4 = -23,
  /// <summary>
  /// Specifies Word Built-in style for TOC 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC3")]
  TOC3 = -22,
  /// <summary>
  /// Specifies Word Built-in style for TOC 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC2")]
  TOC2 = -21,
  /// <summary>
  /// Specifies Word Built-in style for TOC 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleTOC1")]
  TOC1 = -20,
  /// <summary>
  /// Specifies Word Built-in style for Index 9.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex9")]
  Index9 = -19,
  /// <summary>
  /// Specifies Word Built-in style for Index 8.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex8")]
  Index8 = -18,
  /// <summary>
  /// Specifies Word Built-in style for Index 7.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex7")]
  Index7 = -17,
  /// <summary>
  /// Specifies Word Built-in style for Index 6.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex6")]
  Index6 = -16,
  /// <summary>
  /// Specifies Word Built-in style for Index 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex5")]
  Index5 = -15,
  /// <summary>
  /// Specifies Word Built-in style for Index 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex4")]
  Index4 = -14,
  /// <summary>
  /// Specifies Word Built-in style for Index 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex3")]
  Index3 = -13,
  /// <summary>
  /// Specifies Word Built-in style for Index 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex2")]
  Index2 = -12,
  /// <summary>
  /// Specifies Word Built-in style for Index 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleIndex1")]
  Index1 = -11,
  /// <summary>
  /// Specifies Word Built-in style for Heading 9.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading9")]
  Heading9 = -10,
  /// <summary>
  /// Specifies Word Built-in style for Heading 8.  
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading8")]
  Heading8 = -9,
  /// <summary>
  /// Specifies Word Built-in style for Heading 7.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading7")]
  Heading7 = -8,
  /// <summary>
  /// Specifies Word Built-in style for Heading 6.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading6")]
  Heading6 = -7,
  /// <summary>
  /// Specifies Word Built-in style for Heading 5.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading5")]
  Heading5 = -6,
  /// <summary>
  /// Specifies Word Built-in style for Heading 4.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading4")]
  Heading4 = -5,
  /// <summary>
  /// Specifies Word Built-in style for Heading 3.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading3")]
  Heading3 = -4,
  /// <summary>
  /// Specifies Word Built-in style for Heading 2.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading2")]
  Heading2 = -3,
  /// <summary>
  /// Specifies Word Built-in style for Heading 1.
  /// </summary>
  [WordInteropEnumValue("wdStyleHeading1")]
  Heading1 = -2,
  /// <summary>
  /// Specifies Word Built-in style for Normal text.
  /// </summary>
  [WordInteropEnumValue("wdStyleNormal")]
  Normal = -1
}
