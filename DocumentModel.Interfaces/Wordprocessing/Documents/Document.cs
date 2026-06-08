using DocumentModel.CustomXml;
using DocumentModel.HTML;
using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object.For information about the COM object, see Document
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document?view=word-pia"/>
public partial interface IDocument : IModelObject
{
  /// <summary>
  /// Returns the name of the active theme plus the theme formatting options for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activetheme?view=word-pia"/>
  public string? ActiveTheme { get; }

  /// <summary>
  /// Returns the display name of the active theme for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activethemedisplayname?view=word-pia"/>
  public string? ActiveThemeDisplayName { get; }

  /// <summary>
  /// Returns a Window object that represents the active window.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activewindow?view=word-pia"/>
  public IWindow? ActiveWindow { get; }

  /// <summary>
  /// Returns a Template object that represents the template attached to the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.attachedtemplate?view=word-pia"/>
  public ITemplate? AttachedTemplate { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether automatic formatting options override formatting restrictions in a document where formatting restrictions are in effect.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autoformatoverride?view=word-pia"/>
  public bool AutoFormatOverride { get; set; }

  /// <summary>
  /// Determines if automatic hyphenation is turned on for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autohyphenation?view=word-pia"/>
  public bool AutoHyphenation { get; set; }

  /// <summary>
  /// Returns a Shape object that represents the background image for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.background?view=word-pia"/>
  public DMD.IShape? Background { get; set; }

  /// <summary>
  /// Returns the bibliography references contained within a document. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.bibliography?view=word-pia"/>
  public IBibliography? Bibliography { get; }

  /// <summary>
  /// Returns a Bookmarks collection that represents all the bookmarks in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.bookmarks?view=word-pia"/>
  public IBookmarks? Bookmarks { get; }

  /// <summary>
  /// Returns a DocumentProperties collection that represents all the built-in document properties for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.builtindocumentproperties?view=word-pia"/>
  public Props.IDocumentProperties? BuiltInDocumentProperties { get; }

  /// <summary>
  /// Returns a Characters collection that represents the characters in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.characters?view=word-pia"/>
  public ICharacters? Characters { get; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether charts in the active document use cell-reference data-point tracking. Read-write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.chartdatapointtrack?view=word-pia"/>
  public bool ChartDataPointTrack { get; set; }

  /// <summary>
  /// Returns or sets the default paragraph style applied to text by the Click and Type feature in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.clickandtypeparagraphstyle?view=word-pia"/>
  public object? ClickAndTypeParagraphStyle { get; set; }

  /// <summary>
  /// Returns a CoAuthoring object that provides an entry point to co-authoring-related object model in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.coauthoring?view=word-pia"/>
  public ICoAuthoring? CoAuthoring { get; }

  /// <summary>
  /// Returns a Comments collection that represents all the comments in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.comments?view=word-pia"/>
  public IComments? Comments { get; }

  /// <summary>
  /// Returns a long that specifies the compatibility mode that Word 2010 uses when opening the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compatibilitymode?view=word-pia"/>
  public int? CompatibilityMode { get; }

  /// <summary>
  /// Returns or sets the maximum number of consecutive lines that can end with hyphens.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.consecutivehyphenslimit?view=word-pia"/>
  public int? ConsecutiveHyphensLimit { get; set; }

  /// <summary>
  /// Returns the object that represents the container application for the specified OLE object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.container?view=word-pia"/>
  public object? Container { get; }

  /// <summary>
  /// Returns a Range object that represents the main document story.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.content?view=word-pia"/>
  public IRange? Content { get; }

  /// <summary>
  /// Returns all of the content controls in a document. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.contentcontrols?view=word-pia"/>
  public IContentControls? ContentControls { get; }

  /// <summary>
  /// Returns the metadata stored in a document, such as author name, subject, and company. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.contenttypeproperties?view=word-pia"/>
  public Props.IMetaProperties? ContentTypeProperties { get; }

  /// <summary>
  /// Returns a random number that Word assigns to changes in a document. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.currentrsid?view=word-pia"/>
  public int? CurrentRsid { get; }

  /// <summary>
  /// Returns a DocumentProperties collection that represents all the custom document properties for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.customdocumentproperties?view=word-pia"/>
  public Props.ICustomProperties? CustomDocumentProperties { get; }

  /// <summary>
  /// Returns a CustomXMLParts#SameCHM collection that represents the custom XML in the XML data store. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.customxmlparts?view=word-pia"/>
  public ICustomXMLParts? CustomXMLParts { get; }

  /// <summary>
  /// Returns a TableStyle that represents the table style that is applied to all newly created tables in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.defaulttablestyle?view=word-pia"/>
  public ITableStyle? DefaultTableStyle { get; }

  /// <summary>
  /// Returns or sets the interval (in points) between the default tab stops in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.defaulttabstop?view=word-pia"/>
  public float? DefaultTabStop { get; set; }

  /// <summary>
  /// Returns or sets a string? indicating the browser frame in which to display a Web page reached through a hyperlink.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.defaulttargetframe?view=word-pia"/>
  public string? DefaultTargetFrame { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.docid?view=word-pia"/>
  public int? DocID { get; }

  /// <summary>
  /// Returns an OfficeTheme object that represents the Microsoft Office theme applied to a document. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.documenttheme?view=word-pia"/>
  public Themes.ITheme? DocumentTheme { get; }

  /// <summary>
  /// Returns an Endnotes collection that represents all the endnotes in a range, selection, or document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.endnotes?view=word-pia"/>
  public IEndnotes? Endnotes { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether formatting restrictions are enforced in a protected document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.enforcestyle?view=word-pia"/>
  public bool EnforceStyle { get; set; }

  /// <summary>
  /// Returns an Envelope object that represents envelope functionality and the envelope in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.envelope?view=word-pia"/>
  public IEnvelope? Envelope { get; }

  /// <summary>
  /// Returns or sets the East Asian language to use when breaking lines of text in the specified document or template.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fareastlinebreaklanguage?view=word-pia"/>
  public FarEastLineBreakLanguageID? FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// Returns or sets the line break control level for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fareastlinebreaklevel?view=word-pia"/>
  public FarEastLineBreakLevel? FarEastLineBreakLevel { get; set; }

  /// <summary>
  /// Returns a read-only Fields collection that represents all the fields in the document, range, or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fields?view=word-pia"/>
  public IFields? Fields { get; }

  /// <summary>
  /// Returns or sets a Boolean that indicates whether a document is final. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.final?view=word-pia"/>
  public bool Final { get; set; }

  /// <summary>
  /// Returns a Footnotes collection that represents all the footnotes in a range, selection, or document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.footnotes?view=word-pia"/>
  public IFootnotes? Footnotes { get; }

  /// <summary>
  /// Determines if Microsoft Word is to show clear formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowclear?view=word-pia"/>
  public bool FormattingShowClear { get; set; }

  /// <summary>
  /// Returns or sets a ShowFilter constant that represents the styles and formatting displayed in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowfilter?view=word-pia"/>
  public ShowFilter? FormattingShowFilter { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays font formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowfont?view=word-pia"/>
  public bool FormattingShowFont { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word shows the next heading level when the previous heading level is used. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshownextlevel?view=word-pia"/>
  public bool FormattingShowNextLevel { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays number formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshownumbering?view=word-pia"/>
  public bool FormattingShowNumbering { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays paragraph formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowparagraph?view=word-pia"/>
  public bool FormattingShowParagraph { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to show user-defined styles. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowuserstylename?view=word-pia"/>
  public bool FormattingShowUserStyleName { get; set; }

  /// <summary>
  /// Returns a FormFields collection that represents all the form fields in the document, range, or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formfields?view=word-pia"/>
  public IFormFields? FormFields { get; }

  /// <summary>
  /// Returns True if the specified document is in form design mode.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formsdesign?view=word-pia"/>
  public bool FormsDesign { get; }

  /// <summary>
  /// Returns a Frames collection that represents all the frames in a document, range, or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.frames?view=word-pia"/>
  public IFrames? Frames { get; }

  /// <summary>
  /// Returns a Frameset object that represents an entire frames page or a single frame on a frames page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.frameset?view=word-pia"/>
  public IFrameset? Frameset { get; }

  /// <summary>
  /// Specifies the name of a document, template, or cascading style sheet, including the drive or Web path.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fullname?view=word-pia"/>
  public string? FullName { get; }

  /// <summary>
  /// Determines if a grammar check has been run on the specified range or document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.grammarchecked?view=word-pia"/>
  public bool GrammarChecked { get; set; }

  /// <summary>
  /// Returns a ProofreadingErrors collection that represents the sentences that failed the grammar check on the specified document or range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.grammaticalerrors?view=word-pia"/>
  public IProofreadingErrors? GrammaticalErrors { get; }

  /// <summary>
  /// Returns or sets the amount of horizontal space between the invisible gridlines that Microsoft Word uses when you draw, move, and resize AutoShapes or East Asian characters in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.griddistancehorizontal?view=word-pia"/>
  public float? GridDistanceHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the amount of vertical space between the invisible gridlines that Microsoft Word uses when you draw, move, and resize AutoShapes or East Asian characters in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.griddistancevertical?view=word-pia"/>
  public float? GridDistanceVertical { get; set; }

  /// <summary>
  /// Determines if Microsoft Word starts the character grid from the upper-left corner of the page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridoriginfrommargin?view=word-pia"/>
  public bool GridOriginFromMargin { get; set; }

  /// <summary>
  /// Returns or sets the point, relative to the left edge of the page, where you want the invisible grid for drawing, moving, and resizing AutoShapes or East Asian characters to begin in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridoriginhorizontal?view=word-pia"/>
  public float? GridOriginHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the point, relative to the top of the page, where you want the invisible grid for drawing, moving, and resizing AutoShapes or East Asian characters to begin in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridoriginvertical?view=word-pia"/>
  public float? GridOriginVertical { get; set; }

  /// <summary>
  /// Returns or sets the interval at which Microsoft Word displays horizontal character gridlines in print layout view.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridspacebetweenhorizontallines?view=word-pia"/>
  public int? GridSpaceBetweenHorizontalLines { get; set; }

  /// <summary>
  /// Returns or sets the interval at which Microsoft Word displays vertical character gridlines in print layout view.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridspacebetweenverticallines?view=word-pia"/>
  public int? GridSpaceBetweenVerticalLines { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hasmailer?view=word-pia"/>
  public bool HasMailer { get; set; }

  /// <summary>
  /// Returns True if a password is required to open the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.haspassword?view=word-pia"/>
  public bool HasPassword { get; }

  /// <summary>
  /// Determines if the specified document has a routing slip attached to it.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hasroutingslip?view=word-pia"/>
  public bool HasRoutingSlip { get; set; }

  /// <summary>
  /// Returns a Boolean that represents whether a document has an attached Microsoft Visual Basic for Applications project. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hasvbproject?view=word-pia"/>
  public bool HasVBProject { get; }

  /// <summary>
  /// Returns an HTMLDivisions object that represents an HTML division in a Web document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.htmldivisions?view=word-pia"/>
  public IHTMLDivisions? HTMLDivisions { get; }

  /// <summary>
  /// Returns an HTMLProject object in the specified document that represents a top-level project branch, as in the Project Explorer of the Microsoft Script Editor.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.htmlproject?view=word-pia"/>
  public IHTMLProject? HTMLProject { get; }

  /// <summary>
  /// Returns a Hyperlinks collection that represents all the hyperlinks in the specified document, range, or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hyperlinks?view=word-pia"/>
  public IHyperlinks? Hyperlinks { get; }

  /// <summary>
  /// Determine if words in all capital letters can be hyphenated.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hyphenatecaps?view=word-pia"/>
  public bool HyphenateCaps { get; set; }

  /// <summary>
  /// Returns or sets the width of the hyphenation zone, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hyphenationzone?view=word-pia"/>
  public int? HyphenationZone { get; set; }

  /// <summary>
  /// Returns an Indexes collection that represents all the indexes in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.indexes?view=word-pia"/>
  public IIndexes? Indexes { get; }

  /// <summary>
  /// Returns an IInlineShapes collection that represents all the InlineShape objects in a document, range, or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.inlineshapes?view=word-pia"/>
  public DMD.IInlineShapes? InlineShapes { get; }

  /// <summary>
  /// True if the most recent firing of the Application.DocumentBeforeSave Event (Word)event was the result of an automatic save, and not a manual save by the user. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.isinautosave?view=word-pia"/>
  public bool IsInAutosave { get; }

  /// <summary>
  /// Determines if the specified document is a master document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.ismasterdocument?view=word-pia"/>
  public bool IsMasterDocument { get; }

  /// <summary>
  /// Determines if the specified document is opened in a separate document window as a subdocument of a master document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.issubdocument?view=word-pia"/>
  public bool IsSubdocument { get; }

  /// <summary>
  /// Returns or sets the character spacing adjustment for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.justificationmode?view=word-pia"/>
  public JustificationMode? JustificationMode { get; set; }

  /// <summary>
  /// Determines if Microsoft Word kerns half-width Latin characters and punctuation marks in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.kerningbyalgorithm?view=word-pia"/>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// Returns or sets the format type that Microsoft Word uses when automatically formatting the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.kind?view=word-pia"/>
  public DocumentKind? Kind { get; set; }

  /// <summary>
  /// Returns or sets a value that specifies whether Microsoft Word has detected the language of the specified text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// Returns a ListParagraphs collection that represents all the numbered paragraphs in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.listparagraphs?view=word-pia"/>
  public IListParagraphs? ListParagraphs { get; }

  /// <summary>
  /// Returns a Lists collection that contains all the formatted lists in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.lists?view=word-pia"/>
  public ILists? Lists { get; }

  /// <summary>
  /// Returns a ListTemplates collection that represents all the list formats for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.listtemplates?view=word-pia"/>
  public IListTemplates? ListTemplates { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether users can change which set of Quick Styles is being used. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.lockquickstyleset?view=word-pia"/>
  public bool LockQuickStyleSet { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether a user can change a document theme. Read/write.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.locktheme?view=word-pia"/>
  public bool LockTheme { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.mailer?view=word-pia"/>
  public IMailer? Mailer { get; }

  /// <summary>
  /// Returns a MailMerge object that represents the mail merge functionality for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.mailmerge?view=word-pia"/>
  public IMailMerge? MailMerge { get; }

  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.name?view=word-pia"/>
  public string? Name { get; }

  /// <summary>
  /// Returns or sets the kinsoku characters after which Microsoft Word will not break a line.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.nolinebreakafter?view=word-pia"/>
  public string? NoLineBreakAfter { get; set; }

  /// <summary>
  /// Returns or sets the kinsoku characters before which Microsoft Word will not break a line.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.nolinebreakbefore?view=word-pia"/>
  public string? NoLineBreakBefore { get; set; }
  /// <summary>
  /// Returns the document title for the original document after running a legal-blackline document compare function. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.originaldocumenttitle?view=word-pia"/>
  public string? OriginalDocumentTitle { get; }

  /// <summary>
  /// Returns a PageSetup object that's associated with the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.pagesetup?view=word-pia"/>
  public IPageSetup? PageSetup { get; set; }

  /// <summary>
  /// Returns a Paragraphs collection that represents all the paragraphs in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.paragraphs?view=word-pia"/>
  public IParagraphs? Paragraphs { get; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.path?view=word-pia"/>
  public string? Path { get; }

  /// <summary>
  /// Determines if changes to the document cannot be saved to the original document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readonly?view=word-pia"/>
  public bool ReadOnly { get; }

  /// <summary>
  /// Returns a Revisions collection that represents the tracked changes in the document or range.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.revisions?view=word-pia"/>
  public IRevisions? Revisions { get; }

  /// <summary>
  /// Determines if the specified document or template hasn't changed since it was last saved.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saved?view=word-pia"/>
  public bool Saved { get; set; }

  /// <summary>
  /// Returns an Integer representing the file format of the specified document or file converter.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveformat?view=word-pia"/>
  public int? SaveFormat { get; }

  /// <summary>
  /// Determines if Microsoft Word saves the data entered in a form as a tab-delimited record for use in a database.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveformsdata?view=word-pia"/>
  public bool SaveFormsData { get; set; }

  /// <summary>
  /// Determines if Microsoft Word saves a subset of the embedded TrueType fonts with the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.savesubsetfonts?view=word-pia"/>
  public bool SaveSubsetFonts { get; set; }

  /// <summary>
  /// Returns a Scripts collection that represents the collection of HTML scripts in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.scripts?view=word-pia"/>
  public IScripts? Scripts { get; }

  /// <summary>
  /// Returns a Sections collection that represents the sections in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sections?view=word-pia"/>
  public ISections? Sections { get; }

  /// <summary>
  /// Returns a Sentences collection that represents all the sentences in the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sentences?view=word-pia"/>
  public ISentences? Sentences { get; }

  /// <summary>
  /// Returns a Shapes collection that represents all the Shape objects in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.shapes?view=word-pia"/>
  public DMD.IShapes? Shapes { get; }

  /// <summary>
  /// Returns a StoryRanges collection that represents all the stories in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.storyranges?view=word-pia"/>
  public IStoryRanges? StoryRanges { get; }

  /// <summary>
  /// Returns a Styles collection for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.styles?view=word-pia"/>
  public IStyles? Styles { get; }

  /// <summary>
  /// Returns a StyleSheets object that represents the Web style sheets attached to a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.stylesheets?view=word-pia"/>
  public IStyleSheets? StyleSheets { get; }

  /// <summary>
  /// Returns a Subdocuments collection that represents all the subdocuments in the specified range or document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.subdocuments?view=word-pia"/>
  public ISubdocuments? Subdocuments { get; }

  /// <summary>
  /// Returns a Tables collection that represents all the tables in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tables?view=word-pia"/>
  public ITables? Tables { get; }

  /// <summary>
  /// Returns a TablesOfAuthorities collection that represents the tables of authorities in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesofauthorities?view=word-pia"/>
  public ITablesOfAuthorities? TablesOfAuthorities { get; }

  /// <summary>
  /// Returns a TablesOfAuthoritiesCategories collection that represents the available tables of authorities categories for the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesofauthoritiescategories?view=word-pia"/>
  public ITablesOfAuthoritiesCategories? TablesOfAuthoritiesCategories { get; }

  /// <summary>
  /// Returns a TablesOfContents collection that represents the tables of contents in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesofcontents?view=word-pia"/>
  public ITablesOfContents? TablesOfContents { get; }

  /// <summary>
  /// Returns a TablesOfFigures collection that represents the tables of figures in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesoffigures?view=word-pia"/>
  public ITablesOfFigures? TablesOfFigures { get; }

  /// <summary>
  /// Returns a Variables collection that represents the variables stored in the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.variables?view=word-pia"/>
  public IVariables? Variables { get; }

  /// <summary>
  /// Returns a Versions collection that represents all the versions of the specified document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.versions?view=word-pia"/>
  public IVersions? Versions { get; }

  /// <summary>
  /// Returns the WebOptions object, which contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.weboptions?view=word-pia"/>
  public IWebOptions? WebOptions { get; }

  /// <summary>
  /// Returns a Windows collection that represents all windows for the specified document (for example, Sales.doc:1 and Sales.doc:2).
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.windows?view=word-pia"/>
  public IWindows? Windows { get; }

  /// <summary>
  /// Returns a Words collection that represents all the words in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.words?view=word-pia"/>
  public IWords? Words { get; }

}
