namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a built-in Microsoft Word style.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuiltinstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBuiltinStyle))]
public enum BuiltinStyle
{
  /// <summary>
  /// Specifies Word Built-in style for Table of Contents Heading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTocHeading))]
  TocHeading = -267,
  /// <summary>
  /// Specifies Word Built-in style for Bibliography.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBibliography))]
  Bibliography = -266,
  /// <summary>
  /// Specifies Word Built-in style for Book Title.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBookTitle))]
  BookTitle = -265,
  /// <summary>
  /// Specifies Word Built-in style for Intense Reference.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIntenseReference))]
  IntenseReference = -264,
  /// <summary>
  /// Specifies Word Built-in style for Subtle Reference.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleSubtleReference))]
  SubtleReference = -263,
  /// <summary>
  /// Specifies Word Built-in style for Intense Emphasis.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIntenseEmphasis))]
  IntenseEmphasis = -262,
  /// <summary>
  /// Specifies Word Built-in style for Subtle Emphasis.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleSubtleEmphasis))]
  SubtleEmphasis = -261,
  /// <summary>
  /// Specifies Word Built-in style for Intense Quote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIntenseQuote))]
  IntenseQuote = -182,
  /// <summary>
  /// Specifies Word Built-in style for Quote.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleQuote))]
  Quote = -181,
  /// <summary>
  /// Specifies Word Built-in style for List Paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListParagraph))]
  ListParagraph = -180,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 1 Accent 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumList1Accent1))]
  TableMediumList1Accent1 = -178,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 2 Accent 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumShading2Accent1))]
  TableMediumShading2Accent1 = -177,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 1 Accent 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumShading1Accent1))]
  TableMediumShading1Accent1 = -176,
  /// <summary>
  /// Specifies Word Built-in style for Light Grid Accent 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableLightGridAccent1))]
  TableLightGridAccent1 = -175,
  /// <summary>
  /// Specifies Word Built-in style for Light List Accent 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableLightListAccent1))]
  TableLightListAccent1 = -174,
  /// <summary>
  /// Specifies Word Built-in style for Light Shading Accent 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableLightShadingAccent1))]
  TableLightShadingAccent1 = -173,
  /// <summary>
  /// Specifies Word Built-in style for Colorful Grid.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableColorfulGrid))]
  TableColorfulGrid = -172,
  /// <summary>
  /// Specifies Word Built-in style for Colorful List.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableColorfulList))]
  TableColorfulList = -171,
  /// <summary>
  /// Specifies Word Built-in style for Colorful Shading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableColorfulShading))]
  TableColorfulShading = -170,
  /// <summary>
  /// Specifies Word Built-in style for Dark List.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableDarkList))]
  TableDarkList = -169,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumGrid3))]
  TableMediumGrid3 = -168,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumGrid2))]
  TableMediumGrid2 = -167,
  /// <summary>
  /// Specifies Word Built-in style for Medium Grid 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumGrid1))]
  TableMediumGrid1 = -166,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumList2))]
  TableMediumList2 = -165,
  /// <summary>
  /// Specifies Word Built-in style for Medium List 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumList1))]
  TableMediumList1 = -164,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumShading2))]
  TableMediumShading2 = -163,
  /// <summary>
  /// Specifies Word Built-in style for Medium Shading 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableMediumShading1))]
  TableMediumShading1 = -162,
  /// <summary>
  /// Specifies Word Built-in style for Light Grid.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableLightGrid))]
  TableLightGrid = -161,
  /// <summary>
  /// Specifies Word Built-in style for Light List.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableLightList))]
  TableLightList = -160,
  /// <summary>
  /// Specifies Word Built-in style for Light Shading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableLightShading))]
  TableLightShading = -159,
  /// <summary>
  /// Specifies Word Built-in style for Normal (applied to an object).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleNormalObject))]
  NormalObject = -158,
  /// <summary>
  /// Specifies Word Built-in style for Normal (applied within a table).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleNormalTable))]
  NormalTable = -106,
  /// <summary>
  /// Specifies Word Built-in style for HTML Variable.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlVar))]
  HtmlVar = -105,
  /// <summary>
  /// Specifies Word Built-in style for HTML Typewriter.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlTt))]
  HtmlTt = -104,
  /// <summary>
  /// Specifies Word Built-in style for HTML Sample.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlSamp))]
  HtmlSamp = -103,
  /// <summary>
  /// Specifies Word Built-in style for HTML Preformatted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlPre))]
  HtmlPre = -102,
  /// <summary>
  /// Specifies Word Built-in style for HTML Keyboard.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlKbd))]
  HtmlKbd = -101,
  /// <summary>
  /// Specifies Word Built-in style for HTML Definition.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlDfn))]
  HtmlDfn = -100,
  /// <summary>
  /// Specifies Word Built-in style for HTML Code.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlCode))]
  HtmlCode = -99,
  /// <summary>
  /// Specifies Word Built-in style for HTML City.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlCite))]
  HtmlCite = -98,
  /// <summary>
  /// Specifies Word Built-in style for HTML Address.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlAddress))]
  HtmlAddress = -97,
  /// <summary>
  /// Specifies Word Built-in style for HTML Acronym.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlAcronym))]
  HtmlAcronym = -96,
  /// <summary>
  /// Specifies Word Built-in style for Normal (Web).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHtmlNormal))]
  HtmlNormal = -95,
  /// <summary>
  /// Specifies Word Built-in style for Plain Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePlainText))]
  PlainText = -91,
  /// <summary>
  /// Specifies Word Built-in style for Document Map.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleNavPane))]
  NavPane = -90,
  /// <summary>
  /// Specifies Word Built-in style for Emphasis.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleEmphasis))]
  Emphasis = -89,
  /// <summary>
  /// Specifies Word Built-in style for Strong.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleStrong))]
  Strong = -88,
  /// <summary>
  /// Specifies Word Built-in style for Followed Hyperlink.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHyperlinkFollowed))]
  HyperlinkFollowed = -87,
  /// <summary>
  /// Specifies Word Built-in style for Hyperlink.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHyperlink))]
  Hyperlink = -86,
  /// <summary>
  /// Specifies Word Built-in style for Block Quotation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBlockQuotation))]
  BlockQuotation = -85,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyTextIndent3))]
  BodyTextIndent3 = -84,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyTextIndent2))]
  BodyTextIndent2 = -83,
  /// <summary>
  /// Specifies Word Built-in style for Body Text 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyText3))]
  BodyText3 = -82,
  /// <summary>
  /// Specifies Word Built-in style for Body Text 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyText2))]
  BodyText2 = -81,
  /// <summary>
  /// Specifies Word Built-in style for Note Heading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleNoteHeading))]
  NoteHeading = -80,
  /// <summary>
  /// Specifies Word Built-in style for Body Text First Indent 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyTextFirstIndent2))]
  BodyTextFirstIndent2 = -79,
  /// <summary>
  /// Specifies Word Built-in style for Body Text First Indent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyTextFirstIndent))]
  BodyTextFirstIndent = -78,
  /// <summary>
  /// Specifies Word Built-in style for Date.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleDate))]
  Date = -77,
  /// <summary>
  /// Specifies Word Built-in style for Salutation.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleSalutation))]
  Salutation = -76,
  /// <summary>
  /// Specifies Word Built-in style for Subtitle.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleSubtitle))]
  Subtitle = -75,
  /// <summary>
  /// Specifies Word Built-in style for Message Header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleMessageHeader))]
  MessageHeader = -74,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListContinue5))]
  ListContinue5 = -73,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListContinue4))]
  ListContinue4 = -72,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListContinue3))]
  ListContinue3 = -71,
  /// <summary>
  /// Specifies Word Built-in style for List Continue 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListContinue2))]
  ListContinue2 = -70,
  /// <summary>
  /// Specifies Word Built-in style for List Continue.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListContinue))]
  ListContinue = -69,
  /// <summary>
  /// Specifies Word Built-in style for Body Text Indent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyTextIndent))]
  BodyTextIndent = -68,
  /// <summary>
  /// Specifies Word Built-in style for Body Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleBodyText))]
  BodyText = -67,
  /// <summary>
  /// Specifies Word Built-in style for Default Paragraph Font.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleDefaultParagraphFont))]
  DefaultParagraphFont = -66,
  /// <summary>
  /// Specifies Word Built-in style for Signature.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleSignature))]
  Signature = -65,
  /// <summary>
  /// Specifies Word Built-in style for Closing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleClosing))]
  Closing = -64,
  /// <summary>
  /// Specifies Word Built-in style for Title.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTitle))]
  Title = -63,
  /// <summary>
  /// Specifies Word Built-in style for List Number 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListNumber5))]
  ListNumber5 = -62,
  /// <summary>
  /// Specifies Word Built-in style for List Number 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListNumber4))]
  ListNumber4 = -61,
  /// <summary>
  /// Specifies Word Built-in style for List Number 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListNumber3))]
  ListNumber3 = -60,
  /// <summary>
  /// Specifies Word Built-in style for List Number 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListNumber2))]
  ListNumber2 = -59,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListBullet5))]
  ListBullet5 = -58,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListBullet4))]
  ListBullet4 = -57,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListBullet3))]
  ListBullet3 = -56,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListBullet2))]
  ListBullet2 = -55,
  /// <summary>
  /// Specifies Word Built-in style for List 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleList5))]
  List5 = -54,
  /// <summary>
  /// Specifies Word Built-in style for List 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleList4))]
  List4 = -53,
  /// <summary>
  /// Specifies Word Built-in style for List 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleList3))]
  List3 = -52,
  /// <summary>
  /// Specifies Word Built-in style for List 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleList2))]
  List2 = -51,
  /// <summary>
  /// Specifies Word Built-in style for List Number.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListNumber))]
  ListNumber = -50,
  /// <summary>
  /// Specifies Word Built-in style for List Bullet.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleListBullet))]
  ListBullet = -49,
  /// <summary>
  /// Specifies Word Built-in style for List.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleList))]
  List = -48,
  /// <summary>
  /// Specifies Word Built-in style for TOA Heading.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOAHeading))]
  TOAHeading = -47,
  /// <summary>
  /// Specifies Word Built-in style for Macro Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleMacroText))]
  MacroText = -46,
  /// <summary>
  /// Specifies Word Built-in style for Table of Authorities.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableOfAuthorities))]
  TableOfAuthorities = -45,
  /// <summary>
  /// Specifies Word Built-in style for Endnote Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleEndnoteText))]
  EndnoteText = -44,
  /// <summary>
  /// Specifies Word Built-in style for Endnote Reference.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleEndnoteReference))]
  EndnoteReference = -43,
  /// <summary>
  /// Specifies Word Built-in style for Page Number.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePageNumber))]
  PageNumber = -42,
  /// <summary>
  /// Specifies Word Built-in style for Line Number.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleLineNumber))]
  LineNumber = -41,
  /// <summary>
  /// Specifies Word Built-in style for Comment Reference.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleCommentReference))]
  CommentReference = -40,
  /// <summary>
  /// Specifies Word Built-in style for Footnote Reference.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleFootnoteReference))]
  FootnoteReference = -39,
  /// <summary>
  /// Specifies Word Built-in style for Envelope Return.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleEnvelopeReturn))]
  EnvelopeReturn = -38,
  /// <summary>
  /// Specifies Word Built-in style for Envelope Address.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleEnvelopeAddress))]
  EnvelopeAddress = -37,
  /// <summary>
  /// Specifies Word Built-in style for Table of Figures.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTableOfFigures))]
  TableOfFigures = -36,
  /// <summary>
  /// Specifies Word Built-in style for Caption.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleCaption))]
  Caption = -35,
  /// <summary>
  /// Specifies Word Built-in style for Index Heading
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndexHeading))]
  IndexHeading = -34,
  /// <summary>
  /// Specifies Word Built-in style for Footer.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleFooter))]
  Footer = -33,
  /// <summary>
  /// Specifies Word Built-in style for   Header.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeader))]
  Header = -32,
  /// <summary>
  /// Specifies Word Built-in style for Comment Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleCommentText))]
  CommentText = -31,
  /// <summary>
  /// Specifies Word Built-in style for Footnote Text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleFootnoteText))]
  FootnoteText = -30,
  /// <summary>
  /// Specifies Word Built-in style for Normal Indent.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleNormalIndent))]
  NormalIndent = -29,
  /// <summary>
  /// Specifies Word Built-in style for TOC 9.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC9))]
  TOC9 = -28,
  /// <summary>
  /// Specifies Word Built-in style for TOC 8.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC8))]
  TOC8 = -27,
  /// <summary>
  /// Specifies Word Built-in style for TOC 7.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC7))]
  TOC7 = -26,
  /// <summary>
  /// Specifies Word Built-in style for TOC 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC6))]
  TOC6 = -25,
  /// <summary>
  /// Specifies Word Built-in style for TOC 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC5))]
  TOC5 = -24,
  /// <summary>
  /// Specifies Word Built-in style for TOC 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC4))]
  TOC4 = -23,
  /// <summary>
  /// Specifies Word Built-in style for TOC 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC3))]
  TOC3 = -22,
  /// <summary>
  /// Specifies Word Built-in style for TOC 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC2))]
  TOC2 = -21,
  /// <summary>
  /// Specifies Word Built-in style for TOC 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleTOC1))]
  TOC1 = -20,
  /// <summary>
  /// Specifies Word Built-in style for Index 9.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex9))]
  Index9 = -19,
  /// <summary>
  /// Specifies Word Built-in style for Index 8.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex8))]
  Index8 = -18,
  /// <summary>
  /// Specifies Word Built-in style for Index 7.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex7))]
  Index7 = -17,
  /// <summary>
  /// Specifies Word Built-in style for Index 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex6))]
  Index6 = -16,
  /// <summary>
  /// Specifies Word Built-in style for Index 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex5))]
  Index5 = -15,
  /// <summary>
  /// Specifies Word Built-in style for Index 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex4))]
  Index4 = -14,
  /// <summary>
  /// Specifies Word Built-in style for Index 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex3))]
  Index3 = -13,
  /// <summary>
  /// Specifies Word Built-in style for Index 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex2))]
  Index2 = -12,
  /// <summary>
  /// Specifies Word Built-in style for Index 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleIndex1))]
  Index1 = -11,
  /// <summary>
  /// Specifies Word Built-in style for Heading 9.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading9))]
  Heading9 = -10,
  /// <summary>
  /// Specifies Word Built-in style for Heading 8.  
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading8))]
  Heading8 = -9,
  /// <summary>
  /// Specifies Word Built-in style for Heading 7.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading7))]
  Heading7 = -8,
  /// <summary>
  /// Specifies Word Built-in style for Heading 6.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading6))]
  Heading6 = -7,
  /// <summary>
  /// Specifies Word Built-in style for Heading 5.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading5))]
  Heading5 = -6,
  /// <summary>
  /// Specifies Word Built-in style for Heading 4.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading4))]
  Heading4 = -5,
  /// <summary>
  /// Specifies Word Built-in style for Heading 3.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading3))]
  Heading3 = -4,
  /// <summary>
  /// Specifies Word Built-in style for Heading 2.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading2))]
  Heading2 = -3,
  /// <summary>
  /// Specifies Word Built-in style for Heading 1.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleHeading1))]
  Heading1 = -2,
  /// <summary>
  /// Specifies Word Built-in style for Normal text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStyleNormal))]
  Normal = -1
}
