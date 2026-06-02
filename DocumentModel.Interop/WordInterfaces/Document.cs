namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object.For information about the COM object, see Document
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document?view=word-pia"/>
public partial interface IDocument : IInteropObject
{

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document._codename?view=word-pia"/>
  public string _CodeName { get; set; }

  /// <summary>
  /// Returns the name of the active theme plus the theme formatting options for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activetheme?view=word-pia"/>
  public string ActiveTheme { get; }

  /// <summary>
  /// Returns the display name of the active theme for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activethemedisplayname?view=word-pia"/>
  public string ActiveThemeDisplayName { get; }

  /// <summary>
  /// Returns a Window object that represents the active window.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activewindow?view=word-pia"/>
  public Window ActiveWindow { get; }

  /// <summary>
  /// Returns a Template object that represents the template attached to the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.attachedtemplate?view=word-pia"/>
  public Template AttachedTemplate { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether automatic formatting options override formatting restrictions in a document where formatting restrictions are in effect.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autoformatoverride?view=word-pia"/>
  public bool AutoFormatOverride { get; set; }

  /// <summary>
  /// Determines if automatic hyphenation is turned on for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autohyphenation?view=word-pia"/>
  public bool AutoHyphenation { get; set; }

  /// <summary>
  /// Returns a Shape object that represents the background image for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.background?view=word-pia"/>
  public Shape Background { get; set; }

  /// <summary>
  /// Returns the bibliography references contained within a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.bibliography?view=word-pia"/>
  public Bibliography Bibliography { get; }

  /// <summary>
  /// Returns a Bookmarks collection that represents all the bookmarks in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.bookmarks?view=word-pia"/>
  public Bookmarks Bookmarks { get; }

  /// <summary>
  /// Returns a Broadcast object that represents a broadcast session, in which presenters can present Word documents to remote participants over the web without the participants needing to have rich clients installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.broadcast?view=word-pia"/>
  public Broadcast Broadcast { get; }

  /// <summary>
  /// Returns a DocumentProperties collection that represents all the built-in document properties for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.builtindocumentproperties?view=word-pia"/>
  public Core.DocumentProperties BuiltInDocumentProperties { get; }

  /// <summary>
  /// Returns a Characters collection that represents the characters in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.characters?view=word-pia"/>
  public Characters Characters { get; }

  /// <summary>
  /// Returns or sets a Boolean (bool in C#) that specifies whether charts in the active document use cell-reference data-point tracking. Read-write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.chartdatapointtrack?view=word-pia"/>
  public bool ChartDataPointTrack { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.childnodesuggestions?view=word-pia"/>
  public XMLChildNodeSuggestions ChildNodeSuggestions { get; }

  /// <summary>
  /// Returns or sets the default paragraph style applied to text by the Click and Type feature in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.clickandtypeparagraphstyle?view=word-pia"/>
  public object ClickAndTypeParagraphStyle { get; set; }

  /// <summary>
  /// Returns a CoAuthoring object that provides an entry point to co-authoring-related object model in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.coauthoring?view=word-pia"/>
  public CoAuthoring CoAuthoring { get; }

  /// <summary>
  /// Returns the code name for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.codename?view=word-pia"/>
  public string CodeName { get; }

  /// <summary>
  /// Returns a CommandBars collection that represents the menu bar and all the toolbars in Microsoft Word.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.commandbars?view=word-pia"/>
  public Core.CommandBars CommandBars { get; }

  /// <summary>
  /// Returns a Comments collection that represents all the comments in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.comments?view=word-pia"/>
  public Comments Comments { get; }

  /// <summary>
  /// Returns a long that specifies the compatibility mode that Word 2010 uses when opening the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compatibilitymode?view=word-pia"/>
  public int CompatibilityMode { get; }

  /// <summary>
  /// Returns or sets the maximum number of consecutive lines that can end with hyphens.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.consecutivehyphenslimit?view=word-pia"/>
  public int ConsecutiveHyphensLimit { get; set; }

  /// <summary>
  /// Returns the object that represents the container application for the specified OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.container?view=word-pia"/>
  public object Container { get; }

  /// <summary>
  /// Returns a Range object that represents the main document story.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.content?view=word-pia"/>
  public Range Content { get; }

  /// <summary>
  /// Returns all of the content controls in a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.contentcontrols?view=word-pia"/>
  public ContentControls ContentControls { get; }

  /// <summary>
  /// Returns the metadata stored in a document, such as author name, subject, and company. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.contenttypeproperties?view=word-pia"/>
  public Core.MetaProperties ContentTypeProperties { get; }

  /// <summary>
  /// Returns a random number that Word assigns to changes in a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.currentrsid?view=word-pia"/>
  public int CurrentRsid { get; }

  /// <summary>
  /// Returns a DocumentProperties collection that represents all the custom document properties for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.customdocumentproperties?view=word-pia"/>
  public Core.DocumentProperties CustomDocumentProperties { get; }

  /// <summary>
  /// Returns a CustomXMLParts#SameCHM collection that represents the custom XML in the XML data store. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.customxmlparts?view=word-pia"/>
  public Core.CustomXMLParts CustomXMLParts { get; }

  /// <summary>
  /// Returns a TableStyle that represents the table style that is applied to all newly created tables in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.defaulttablestyle?view=word-pia"/>
  public TableStyle DefaultTableStyle { get; }

  /// <summary>
  /// Returns or sets the interval (in points) between the default tab stops in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.defaulttabstop?view=word-pia"/>
  public float DefaultTabStop { get; set; }

  /// <summary>
  /// Returns or sets a String indicating the browser frame in which to display a Web page reached through a hyperlink.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.defaulttargetframe?view=word-pia"/>
  public string DefaultTargetFrame { get; set; }

  /// <summary>
  /// Determines if all features introduced after the version specified in the DisableFeaturesIntroducedAfter property are disabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.disablefeatures?view=word-pia"/>
  public bool DisableFeatures { get; set; }

  /// <summary>
  /// Disables all features introduced after a specified version of Microsoft Word in the document only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.disablefeaturesintroducedafter?view=word-pia"/>
  public DisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfter { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.docid?view=word-pia"/>
  public int DocID { get; }

  /// <summary>
  /// Returns a DocumentInspectors collection that enables you to locate hidden personal information, such as author name, company name, and revision date. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.documentinspectors?view=word-pia"/>
  public Core.DocumentInspectors DocumentInspectors { get; }

  /// <summary>
  /// Returns a DocumentLibraryVersions collection that represents the collection of versions of a shared document that has versioning enabled and that is stored in a document library on a server.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.documentlibraryversions?view=word-pia"/>
  public Core.DocumentLibraryVersions DocumentLibraryVersions { get; }

  /// <summary>
  /// Returns an OfficeTheme object that represents the Microsoft Office theme applied to a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.documenttheme?view=word-pia"/>
  public Core.OfficeTheme DocumentTheme { get; }

  /// <summary>
  /// Determines if Microsoft Word embeds common system fonts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.donotembedsystemfonts?view=word-pia"/>
  public bool DoNotEmbedSystemFonts { get; set; }

  /// <summary>
  /// Returns an Email object that contains all the e-mail � related properties of the current document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.email?view=word-pia"/>
  public Email Email { get; }

  /// <summary>
  /// Determines if Microsoft Word embeds speech and handwriting, stores East Asian IME keystrokes, and controls text service data received from devices.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.embedlinguisticdata?view=word-pia"/>
  public bool EmbedLinguisticData { get; set; }

  /// <summary>
  /// Determines if Microsoft Word saves the smart tag information in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.embedsmarttags?view=word-pia"/>
  public bool EmbedSmartTags { get; set; }

  /// <summary>
  /// ReturnsTrue if Microsoft Word embeds TrueType fonts in a document when it's saved.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.embedtruetypefonts?view=word-pia"/>
  public bool EmbedTrueTypeFonts { get; set; }

  /// <summary>
  /// Returns a String specifying the name of the algorithm encryption provider that Microsoft Office Word uses when encrypting documents. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.encryptionprovider?view=word-pia"/>
  public string EncryptionProvider { get; set; }

  /// <summary>
  /// Returns an Endnotes collection that represents all the endnotes in a range, selection, or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.endnotes?view=word-pia"/>
  public Endnotes Endnotes { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether formatting restrictions are enforced in a protected document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.enforcestyle?view=word-pia"/>
  public bool EnforceStyle { get; set; }

  /// <summary>
  /// Returns an Envelope object that represents envelope functionality and the envelope in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.envelope?view=word-pia"/>
  public Envelope Envelope { get; }

  /// <summary>
  /// Returns or sets the East Asian language to use when breaking lines of text in the specified document or template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fareastlinebreaklanguage?view=word-pia"/>
  public FarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// Returns or sets the line break control level for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fareastlinebreaklevel?view=word-pia"/>
  public FarEastLineBreakLevel FarEastLineBreakLevel { get; set; }

  /// <summary>
  /// Returns a read-only Fields collection that represents all the fields in the document, range, or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fields?view=word-pia"/>
  public Fields Fields { get; }

  /// <summary>
  /// Returns or sets a Boolean that indicates whether a document is final. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.final?view=word-pia"/>
  public bool Final { get; set; }

  /// <summary>
  /// Returns a Footnotes collection that represents all the footnotes in a range, selection, or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.footnotes?view=word-pia"/>
  public Footnotes Footnotes { get; }

  /// <summary>
  /// Determines if Microsoft Word is to show clear formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowclear?view=word-pia"/>
  public bool FormattingShowClear { get; set; }

  /// <summary>
  /// Returns or sets a ShowFilter constant that represents the styles and formatting displayed in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowfilter?view=word-pia"/>
  public ShowFilter FormattingShowFilter { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays font formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowfont?view=word-pia"/>
  public bool FormattingShowFont { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether Microsoft Office Word shows the next heading level when the previous heading level is used. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshownextlevel?view=word-pia"/>
  public bool FormattingShowNextLevel { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays number formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshownumbering?view=word-pia"/>
  public bool FormattingShowNumbering { get; set; }

  /// <summary>
  /// Determines if Microsoft Word displays paragraph formatting in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowparagraph?view=word-pia"/>
  public bool FormattingShowParagraph { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to show user-defined styles. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowuserstylename?view=word-pia"/>
  public bool FormattingShowUserStyleName { get; set; }

  /// <summary>
  /// Returns a FormFields collection that represents all the form fields in the document, range, or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formfields?view=word-pia"/>
  public FormFields FormFields { get; }

  /// <summary>
  /// Returns True if the specified document is in form design mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formsdesign?view=word-pia"/>
  public bool FormsDesign { get; }

  /// <summary>
  /// Returns a Frames collection that represents all the frames in a document, range, or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.frames?view=word-pia"/>
  public Frames Frames { get; }

  /// <summary>
  /// Returns a Frameset object that represents an entire frames page or a single frame on a frames page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.frameset?view=word-pia"/>
  public Frameset Frameset { get; }

  /// <summary>
  /// Specifies the name of a document, template, or cascading style sheet, including the drive or Web path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fullname?view=word-pia"/>
  public string FullName { get; }

  /// <summary>
  /// Determines if a grammar check has been run on the specified range or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.grammarchecked?view=word-pia"/>
  public bool GrammarChecked { get; set; }

  /// <summary>
  /// Returns a ProofreadingErrors collection that represents the sentences that failed the grammar check on the specified document or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.grammaticalerrors?view=word-pia"/>
  public ProofreadingErrors GrammaticalErrors { get; }

  /// <summary>
  /// Returns or sets the amount of horizontal space between the invisible gridlines that Microsoft Word uses when you draw, move, and resize AutoShapes or East Asian characters in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.griddistancehorizontal?view=word-pia"/>
  public float GridDistanceHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the amount of vertical space between the invisible gridlines that Microsoft Word uses when you draw, move, and resize AutoShapes or East Asian characters in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.griddistancevertical?view=word-pia"/>
  public float GridDistanceVertical { get; set; }

  /// <summary>
  /// Determines if Microsoft Word starts the character grid from the upper-left corner of the page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridoriginfrommargin?view=word-pia"/>
  public bool GridOriginFromMargin { get; set; }

  /// <summary>
  /// Returns or sets the point, relative to the left edge of the page, where you want the invisible grid for drawing, moving, and resizing AutoShapes or East Asian characters to begin in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridoriginhorizontal?view=word-pia"/>
  public float GridOriginHorizontal { get; set; }

  /// <summary>
  /// Returns or sets the point, relative to the top of the page, where you want the invisible grid for drawing, moving, and resizing AutoShapes or East Asian characters to begin in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridoriginvertical?view=word-pia"/>
  public float GridOriginVertical { get; set; }

  /// <summary>
  /// Returns or sets the interval at which Microsoft Word displays horizontal character gridlines in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridspacebetweenhorizontallines?view=word-pia"/>
  public int GridSpaceBetweenHorizontalLines { get; set; }

  /// <summary>
  /// Returns or sets the interval at which Microsoft Word displays vertical character gridlines in print layout view.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.gridspacebetweenverticallines?view=word-pia"/>
  public int GridSpaceBetweenVerticalLines { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hasmailer?view=word-pia"/>
  public bool HasMailer { get; set; }

  /// <summary>
  /// Returns True if a password is required to open the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.haspassword?view=word-pia"/>
  public bool HasPassword { get; }

  /// <summary>
  /// Determines if the specified document has a routing slip attached to it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hasroutingslip?view=word-pia"/>
  public bool HasRoutingSlip { get; set; }

  /// <summary>
  /// Returns a Boolean that represents whether a document has an attached Microsoft Visual Basic for Applications project. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hasvbproject?view=word-pia"/>
  public bool HasVBProject { get; }

  /// <summary>
  /// Returns an HTMLDivisions object that represents an HTML division in a Web document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.htmldivisions?view=word-pia"/>
  public HTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// Returns an HTMLProject object in the specified document that represents a top-level project branch, as in the Project Explorer of the Microsoft Script Editor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.htmlproject?view=word-pia"/>
  public Core.HTMLProject HTMLProject { get; }

  /// <summary>
  /// Returns a Hyperlinks collection that represents all the hyperlinks in the specified document, range, or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hyperlinks?view=word-pia"/>
  public Hyperlinks Hyperlinks { get; }

  /// <summary>
  /// Determine if words in all capital letters can be hyphenated.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hyphenatecaps?view=word-pia"/>
  public bool HyphenateCaps { get; set; }

  /// <summary>
  /// Returns or sets the width of the hyphenation zone, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.hyphenationzone?view=word-pia"/>
  public int HyphenationZone { get; set; }

  /// <summary>
  /// Returns an Indexes collection that represents all the indexes in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.indexes?view=word-pia"/>
  public Indexes Indexes { get; }

  /// <summary>
  /// Returns an InlineShapes collection that represents all the InlineShape objects in a document, range, or selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.inlineshapes?view=word-pia"/>
  public InlineShapes InlineShapes { get; }

  /// <summary>
  /// True if the most recent firing of the Application.DocumentBeforeSave Event (Word)event was the result of an automatic save, and not a manual save by the user. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.isinautosave?view=word-pia"/>
  public bool IsInAutosave { get; }

  /// <summary>
  /// Determines if the specified document is a master document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.ismasterdocument?view=word-pia"/>
  public bool IsMasterDocument { get; }

  /// <summary>
  /// Determines if the specified document is opened in a separate document window as a subdocument of a master document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.issubdocument?view=word-pia"/>
  public bool IsSubdocument { get; }

  /// <summary>
  /// Returns or sets the character spacing adjustment for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.justificationmode?view=word-pia"/>
  public JustificationMode JustificationMode { get; set; }

  /// <summary>
  /// Determines if Microsoft Word kerns half-width Latin characters and punctuation marks in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.kerningbyalgorithm?view=word-pia"/>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// Returns or sets the format type that Microsoft Word uses when automatically formatting the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.kind?view=word-pia"/>
  public DocumentKind Kind { get; set; }

  /// <summary>
  /// Returns or sets a value that specifies whether Microsoft Word has detected the language of the specified text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// Returns a ListParagraphs collection that represents all the numbered paragraphs in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.listparagraphs?view=word-pia"/>
  public ListParagraphs ListParagraphs { get; }

  /// <summary>
  /// Returns a Lists collection that contains all the formatted lists in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.lists?view=word-pia"/>
  public Lists Lists { get; }

  /// <summary>
  /// Returns a ListTemplates collection that represents all the list formats for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.listtemplates?view=word-pia"/>
  public ListTemplates ListTemplates { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether users can change which set of Quick Styles is being used. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.lockquickstyleset?view=word-pia"/>
  public bool LockQuickStyleSet { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether a user can change a document theme. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.locktheme?view=word-pia"/>
  public bool LockTheme { get; set; }

  /// <summary>
  /// Returns an MsoEnvelope object that represents an e-mail header for a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.mailenvelope?view=word-pia"/>
  public Core.MsoEnvelope MailEnvelope { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.mailer?view=word-pia"/>
  public Mailer Mailer { get; }

  /// <summary>
  /// Returns a MailMerge object that represents the mail merge functionality for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.mailmerge?view=word-pia"/>
  public MailMerge MailMerge { get; }

  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns or sets the kinsoku characters after which Microsoft Word will not break a line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.nolinebreakafter?view=word-pia"/>
  public string NoLineBreakAfter { get; set; }

  /// <summary>
  /// Returns or sets the kinsoku characters before which Microsoft Word will not break a line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.nolinebreakbefore?view=word-pia"/>
  public string NoLineBreakBefore { get; set; }

  /// <summary>
  /// Returns or sets a OMathBreakBin enumeration value that represents where Microsoft Office Word places binary operators when equations span two or more lines. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathbreakbin?view=word-pia"/>
  public OMathBreakBin OMathBreakBin { get; set; }

  /// <summary>
  /// Returns or sets a OMathBreakSub enumeration value that represents how Microsoft Office Word handles a subtraction operator that falls before a line break. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathbreaksub?view=word-pia"/>
  public OMathBreakSub OMathBreakSub { get; set; }

  /// <summary>
  /// Returns the name of the font used in a document to display equations. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathfontname?view=word-pia"/>
  public string OMathFontName { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents the default location of limits for integrals. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathintsubsuplim?view=word-pia"/>
  public bool OMathIntSubSupLim { get; set; }

  /// <summary>
  /// Returns or sets the default justification�left, right, centered, or centered as a group�of a group of equations. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathjc?view=word-pia"/>
  public OMathJc OMathJc { get; set; }

  /// <summary>
  /// Returns or sets the left margin for equations. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathleftmargin?view=word-pia"/>
  public float OMathLeftMargin { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents the default location of limits for n-ary objects other than integrals. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathnarysupsublim?view=word-pia"/>
  public bool OMathNarySupSubLim { get; set; }

  /// <summary>
  /// Returns or sets the right margin for equations. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathrightmargin?view=word-pia"/>
  public float OMathRightMargin { get; set; }

  /// <summary>
  /// Returns the OMath objects within the specified range. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omaths?view=word-pia"/>
  public OMaths OMaths { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to use small fractions in equations contained within the document. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathsmallfrac?view=word-pia"/>
  public bool OMathSmallFrac { get; set; }

  /// <summary>
  /// Returns the placement of the second line of an equation that wraps to a new line. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathwrap?view=word-pia"/>
  public float OMathWrap { get; set; }

  /// <summary>
  /// Returns the encoding used to open the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.openencoding?view=word-pia"/>
  public Core.Encoding OpenEncoding { get; }

  /// <summary>
  /// Determines if Microsoft Word optimizes the current document for viewing in Word 97.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.optimizeforword97?view=word-pia"/>
  public bool OptimizeForWord97 { get; set; }

  /// <summary>
  /// Returns the document title for the original document after running a legal-blackline document compare function. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.originaldocumenttitle?view=word-pia"/>
  public string OriginalDocumentTitle { get; }

  /// <summary>
  /// Returns a PageSetup object that's associated with the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.pagesetup?view=word-pia"/>
  public PageSetup PageSetup { get; set; }

  /// <summary>
  /// Returns a Paragraphs collection that represents all the paragraphs in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.paragraphs?view=word-pia"/>
  public Paragraphs Paragraphs { get; }

  /// <summary>
  /// Sets a password that must be supplied to open the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.password?view=word-pia"/>
  public string Password { set; }

  /// <summary>
  /// Returns a String indicating the algorithm Microsoft Word uses for encrypting documents with passwords.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.passwordencryptionalgorithm?view=word-pia"/>
  public string PasswordEncryptionAlgorithm { get; }

  /// <summary>
  /// Returns True if Microsoft Word encrypts file properties for password-protected documents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.passwordencryptionfileproperties?view=word-pia"/>
  public bool PasswordEncryptionFileProperties { get; }

  /// <summary>
  /// Returns an Integer indicating the key length of the algorithm Microsoft Word uses when encrypting documents with passwords.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.passwordencryptionkeylength?view=word-pia"/>
  public int PasswordEncryptionKeyLength { get; }

  /// <summary>
  /// Returns the name of the algorithm encryption provider that Microsoft Word uses when encrypting documents with passwords.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.passwordencryptionprovider?view=word-pia"/>
  public string PasswordEncryptionProvider { get; }

  /// <summary>
  /// Returns the disk or Web path to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Returns a Permission object that represents the permission settings in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.permission?view=word-pia"/>
  public Core.Permission Permission { get; }

  /// <summary>
  /// Determines if Microsoft Word prints onto a preprinted form only the data entered in the corresponding online form.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printformsdata?view=word-pia"/>
  public bool PrintFormsData { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printfractionalwidths?view=word-pia"/>
  public bool PrintFractionalWidths { get; set; }

  /// <summary>
  /// Determines if PRINT field instructions (such as PostScript commands) in a document are to be printed on top of text and graphics when a PostScript printer is used.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printpostscriptovertext?view=word-pia"/>
  public bool PrintPostScriptOverText { get; set; }

  /// <summary>
  /// Determines if revision marks are printed with the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printrevisions?view=word-pia"/>
  public bool PrintRevisions { get; set; }

  /// <summary>
  /// Returns the protection type for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.protectiontype?view=word-pia"/>
  public ProtectionType ProtectionType { get; }

  /// <summary>
  /// Returns a ReadabilityStatistics collection that represents the readability statistics for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readabilitystatistics?view=word-pia"/>
  public ReadabilityStatistics ReadabilityStatistics { get; }

  /// <summary>
  /// Returns or sets an Integer that represents the width of pages in a document when it is displayed in reading layout view and is frozen for entering handwritten markup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readinglayoutsizex?view=word-pia"/>
  public int ReadingLayoutSizeX { get; set; }

  /// <summary>
  /// Returns or sets an Integer that represents the height of pages in a document when it is displayed in reading layout view and is frozen for entering handwritten markup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readinglayoutsizey?view=word-pia"/>
  public int ReadingLayoutSizeY { get; set; }

  /// <summary>
  /// Sets or returns a Boolean that represents whether pages displayed in reading layout view are frozen to a specified size for inserting handwritten markup into a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readingmodelayoutfrozen?view=word-pia"/>
  public bool ReadingModeLayoutFrozen { get; set; }

  /// <summary>
  /// Determines if changes to the document cannot be saved to the original document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readonly?view=word-pia"/>
  public bool ReadOnly { get; }

  /// <summary>
  /// Determines if Word displays a message box whenever a user opens the document, suggesting that it be opened as read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.readonlyrecommended?view=word-pia"/>
  public bool ReadOnlyRecommended { get; set; }

  /// <summary>
  /// Returns or sets a Boolean indicating whether a document stores the date and time metadata for tracked changes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removedateandtime?view=word-pia"/>
  public bool RemoveDateAndTime { get; set; }

  /// <summary>
  /// Determines if Microsoft Word removes all user information from comments, revisions, and the Properties dialog box upon saving a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removepersonalinformation?view=word-pia"/>
  public bool RemovePersonalInformation { get; set; }

  /// <summary>
  /// Returns the research service for a document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.research?view=word-pia"/>
  public Research Research { get; }

  /// <summary>
  /// Returns the document title for a revised document after running a legal-blackline document compare function. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reviseddocumenttitle?view=word-pia"/>
  public string RevisedDocumentTitle { get; }

  /// <summary>
  /// Returns a Revisions collection that represents the tracked changes in the document or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.revisions?view=word-pia"/>
  public Revisions Revisions { get; }

  /// <summary>
  /// Determines if the specified document has been routed to the next recipient.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.routed?view=word-pia"/>
  public bool Routed { get; }

  /// <summary>
  /// Returns a RoutingSlip object that represents the routing slip information for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.routingslip?view=word-pia"/>
  public RoutingSlip RoutingSlip { get; }

  /// <summary>
  /// Determines if the specified document or template hasn't changed since it was last saved.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saved?view=word-pia"/>
  public bool Saved { get; set; }

  /// <summary>
  /// Returns or sets the encoding to use when saving a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveencoding?view=word-pia"/>
  public Core.Encoding SaveEncoding { get; set; }

  /// <summary>
  /// Returns an Integer representing the file format of the specified document or file converter.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveformat?view=word-pia"/>
  public int SaveFormat { get; }

  /// <summary>
  /// Determines if Microsoft Word saves the data entered in a form as a tab-delimited record for use in a database.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveformsdata?view=word-pia"/>
  public bool SaveFormsData { get; set; }

  /// <summary>
  /// Determines if Microsoft Word saves a subset of the embedded TrueType fonts with the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.savesubsetfonts?view=word-pia"/>
  public bool SaveSubsetFonts { get; set; }

  /// <summary>
  /// Returns a Scripts collection that represents the collection of HTML scripts in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.scripts?view=word-pia"/>
  public Core.Scripts Scripts { get; }

  /// <summary>
  /// Returns a Sections collection that represents the sections in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sections?view=word-pia"/>
  public Sections Sections { get; }

  /// <summary>
  /// Returns a Sentences collection that represents all the sentences in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sentences?view=word-pia"/>
  public Sentences Sentences { get; }

  /// <summary>
  /// Returns the policy specified for a document stored on a server running Microsoft Office SharePoint Server 2007. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.serverpolicy?view=word-pia"/>
  public Core.ServerPolicy ServerPolicy { get; }

  /// <summary>
  /// Returns a Shapes collection that represents all the Shape objects in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.shapes?view=word-pia"/>
  public Shapes Shapes { get; }

  /// <summary>
  /// Returns a SharedWorkspace object that represents the Document Workspace in which a specified document is located.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sharedworkspace?view=word-pia"/>
  public Core.SharedWorkspace SharedWorkspace { get; }

  /// <summary>
  /// Determines if grammatical errors are marked by a wavy green line in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.showgrammaticalerrors?view=word-pia"/>
  public bool ShowGrammaticalErrors { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.showrevisions?view=word-pia"/>
  public bool ShowRevisions { get; set; }

  /// <summary>
  /// Determines if Microsoft Word underlines spelling errors in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.showspellingerrors?view=word-pia"/>
  public bool ShowSpellingErrors { get; set; }

  /// <summary>
  /// Determines if an automatic summary is displayed for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.showsummary?view=word-pia"/>
  public bool ShowSummary { get; set; }

  /// <summary>
  /// Returns a SignatureSet object that represents the digital signatures for a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.signatures?view=word-pia"/>
  public Core.SignatureSet Signatures { get; }

  /// <summary>
  /// Returns a SmartDocument object that represents the settings for a smart document solution.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.smartdocument?view=word-pia"/>
  public Core.SmartDocument SmartDocument { get; }

  /// <summary>
  /// Returns a SmartTags object that represents a smart tag in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.smarttags?view=word-pia"/>
  public SmartTags SmartTags { get; }

  /// <summary>
  /// Determines whether Microsoft Word creates an XML header containing smart tag information when a document containing smart tags is saved as HTML.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.smarttagsasxmlprops?view=word-pia"/>
  public bool SmartTagsAsXMLProps { get; set; }

  /// <summary>
  /// Determines if AutoShapes or East Asian characters are automatically aligned with an invisible grid when they are drawn, moved, or resized in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.snaptogrid?view=word-pia"/>
  public bool SnapToGrid { get; set; }

  /// <summary>
  /// Determines if Microsoft Word automatically aligns AutoShapes or East Asian characters with invisible gridlines that go through the vertical and horizontal edges of other AutoShapes or East Asian characters in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.snaptoshapes?view=word-pia"/>
  public bool SnapToShapes { get; set; }

  /// <summary>
  /// Determines if spelling has been checked throughout the specified range or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.spellingchecked?view=word-pia"/>
  public bool SpellingChecked { get; set; }

  /// <summary>
  /// Returns a ProofreadingErrors collection that represents the words identified as spelling errors in the specified document or range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.spellingerrors?view=word-pia"/>
  public ProofreadingErrors SpellingErrors { get; }

  /// <summary>
  /// Returns a StoryRanges collection that represents all the stories in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.storyranges?view=word-pia"/>
  public StoryRanges StoryRanges { get; }

  /// <summary>
  /// Returns a Styles collection for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.styles?view=word-pia"/>
  public Styles Styles { get; }

  /// <summary>
  /// Returns a StyleSheets object that represents the Web style sheets attached to a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.stylesheets?view=word-pia"/>
  public StyleSheets StyleSheets { get; }

  /// <summary>
  /// Returns or sets the sort method to use when sorting styles in the Styles task pane. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.stylesortmethod?view=word-pia"/>
  public StyleSort StyleSortMethod { get; set; }

  /// <summary>
  /// Returns a Subdocuments collection that represents all the subdocuments in the specified range or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.subdocuments?view=word-pia"/>
  public Subdocuments Subdocuments { get; }

  /// <summary>
  /// Returns or sets the length of the summary as a percentage of the document length.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.summarylength?view=word-pia"/>
  public int SummaryLength { get; set; }

  /// <summary>
  /// Returns or sets the way a summary is displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.summaryviewmode?view=word-pia"/>
  public SummaryMode SummaryViewMode { get; set; }

  /// <summary>
  /// Returns a Sync object that provides access to the methods and properties for documents that are part of a Document Workspace.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sync?view=word-pia"/>
  public Core.Sync Sync { get; }

  /// <summary>
  /// Returns a Tables collection that represents all the tables in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tables?view=word-pia"/>
  public Tables Tables { get; }

  /// <summary>
  /// Returns a TablesOfAuthorities collection that represents the tables of authorities in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesofauthorities?view=word-pia"/>
  public TablesOfAuthorities TablesOfAuthorities { get; }

  /// <summary>
  /// Returns a TablesOfAuthoritiesCategories collection that represents the available tables of authorities categories for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesofauthoritiescategories?view=word-pia"/>
  public TablesOfAuthoritiesCategories TablesOfAuthoritiesCategories { get; }

  /// <summary>
  /// Returns a TablesOfContents collection that represents the tables of contents in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesofcontents?view=word-pia"/>
  public TablesOfContents TablesOfContents { get; }

  /// <summary>
  /// Returns a TablesOfFigures collection that represents the tables of figures in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.tablesoffigures?view=word-pia"/>
  public TablesOfFigures TablesOfFigures { get; }

  /// <summary>
  /// Returns or sets the code page, or character set, that Microsoft Word uses for a document saved as an encoded text file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.textencoding?view=word-pia"/>
  public Core.Encoding TextEncoding { get; set; }

  /// <summary>
  /// Returns or sets a LineEndingType constant indicating how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.textlineending?view=word-pia"/>
  public LineEndingType TextLineEnding { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to track formatting changes when change tracking is turned on. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.trackformatting?view=word-pia"/>
  public bool TrackFormatting { get; set; }

  /// <summary>
  /// Returns or sets aBoolean that represents whether to mark moved text when Track Changes is turned on. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.trackmoves?view=word-pia"/>
  public bool TrackMoves { get; set; }

  /// <summary>
  /// Determines if changes are tracked in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.trackrevisions?view=word-pia"/>
  public bool TrackRevisions { get; set; }

  /// <summary>
  /// Returns the document type (template or document).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.type?view=word-pia"/>
  public DocumentType Type { get; }

  /// <summary>
  /// Determines if the styles in the specified document are updated to match the styles in the attached template each time the document is opened.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.updatestylesonopen?view=word-pia"/>
  public bool UpdateStylesOnOpen { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether to use the default math settings when creating new equations. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.usemathdefaults?view=word-pia"/>
  public bool UseMathDefaults { get; set; }

  /// <summary>
  /// Determines if the document or application was created or opened by the user.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.usercontrol?view=word-pia"/>
  public bool UserControl { get; set; }

  /// <summary>
  /// Returns a Variables collection that represents the variables stored in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.variables?view=word-pia"/>
  public Variables Variables { get; }

  /// <summary>
  /// Determines if the Visual Basic for Applications (VBA) project for the specified document has been digitally signed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.vbasigned?view=word-pia"/>
  public bool VBASigned { get; }

  /// <summary>
  /// Returns the VBProject object for the specified template or document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.vbproject?view=word-pia"/>
  public object VBProject { get; }

  /// <summary>
  /// Returns a Versions collection that represents all the versions of the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.versions?view=word-pia"/>
  public Versions Versions { get; }

  /// <summary>
  /// Returns the WebOptions object, which contains document-level attributes used by Microsoft Word when you save a document as a Web page or open a Web page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.weboptions?view=word-pia"/>
  public WebOptions WebOptions { get; }

  /// <summary>
  /// Returns a Windows collection that represents all windows for the specified document (for example, Sales.doc:1 and Sales.doc:2).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.windows?view=word-pia"/>
  public Windows Windows { get; }

  /// <summary>
  /// Returns the flat XML format for the Word Open XML contents of the document. Read-only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// Returns a Words collection that represents all the words in a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.words?view=word-pia"/>
  public Words Words { get; }

  /// <summary>
  /// Sets a password for saving changes to the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.writepassword?view=word-pia"/>
  public string WritePassword { set; }

  /// <summary>
  /// Determines if the specified document is protected with a write password.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.writereserved?view=word-pia"/>
  public bool WriteReserved { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlhidenamespaces?view=word-pia"/>
  public bool XMLHideNamespaces { get; set; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlnodes?view=word-pia"/>
  public XMLNodes XMLNodes { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlsavedataonly?view=word-pia"/>
  public bool XMLSaveDataOnly { get; set; }

  /// <summary>
  /// Returns or sets a String that specifies the path and file name for the Extensible Stylesheet Language Transformation (XSLT) to apply when a user saves a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlsavethroughxslt?view=word-pia"/>
  public string XMLSaveThroughXSLT { get; set; }

  /// <summary>
  /// Returns an XMLSchemaReferences collection that represents the schemas attached to a document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlschemareferences?view=word-pia"/>
  public XMLSchemaReferences XMLSchemaReferences { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlschemaviolations?view=word-pia"/>
  public XMLNodes XMLSchemaViolations { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether error message text is generated from the built-in Microsoft Word error messages or from the Microsoft XML Core Services (MSXML) 5.0 component included with Office.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlshowadvancederrors?view=word-pia"/>
  public bool XMLShowAdvancedErrors { get; set; }

  /// <summary>
  /// Returns a Boolean that represents whether to save a document through an Extensible Stylesheet Language Transformation (XSLT).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.xmlusexsltwhensaving?view=word-pia"/>
  public bool XMLUseXSLTWhenSaving { get; set; }



  #region methods

/// <summary>
  /// Returns the writing style for a specified language in the specified document.
  /// </summary>
  /// <param name="languageID">The language ID for which to return the writing style.</param>
  /// <returns>The writing style for the specified language.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activewritingstyle?view=word-pia"/>
  public string ActiveWritingStyle(object languageID);

  /// <summary>
  /// Sets the writing style for a specified language in the specified document.
  /// </summary>
  /// <param name="languageID">The language ID for which to set the writing style.</param>
  /// <param name="style">The writing style to set for the specified language.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activewritingstyle?view=word-pia"/>
  public void ActiveWritingStyle(object languageID, string style);

  /// <summary>
  /// Determines whether the specified compatibility option is enabled.
  /// </summary>
  /// <param name="type">A value that specifies the compatibility option to check.</param>
  /// <returns>true if the specified compatibility option is enabled; otherwise, false.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compatibility?view=word-pia"/>
  public bool Compatibility(Compatibility type);

  /// <summary>
  /// Sets the active writing style compatibility option for the specified type.
  /// </summary>
  /// <param name="type">The compatibility option to set, indicating the type of writing style to apply.</param>
  /// <param name="compatibility">A value indicating whether the specified compatibility option is enabled. Set to <see langword="true"/> to enable
  /// the option; otherwise, <see langword="false"/>.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setcompatibility?view=word-pia"/>
  public void SetCompatibility(Compatibility type, bool compatibility);

  /// <summary>
  /// Accepts all tracked changes in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.acceptallrevisions?view=word-pia"/>
  public void AcceptAllRevisions();

  /// <summary>
  /// Accepts all revisions in the specified document that are displayed on the screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.acceptallrevisionsshown?view=word-pia"/>
  public void AcceptAllRevisionsShown();

  /// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.activate?view=word-pia"/>
  public void Activate();

  /// <summary>
  /// Activates the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.adddocumentworkspaceheader?view=word-pia"/>
  public void AddDocumentWorkspaceHeader(bool RichFormat, string Url, string Title, string Description, string ID);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.addmeetingworkspaceheader?view=word-pia"/>
  public void AddMeetingWorkspaceHeader(bool SkipIfAbsent, string Url, string Title, string Description, string ID);

  /// <summary>
  /// Creates a shortcut to the document or hyperlink and adds it to the Favorites folder.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.addtofavorites?view=word-pia"/>
  public void AddToFavorites();

  /// <summary>
  /// Applies a document theme to a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applydocumenttheme?view=word-pia"/>
  public void ApplyDocumentTheme(string FileName);

  /// <summary>
  /// Changes the set of quick styles listed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applyquickstyleset?view=word-pia"/>
  public void ApplyQuickStyleSet(string Name);

  /// <summary>
  /// Applies the specified Quick Style set to the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applyquickstyleset2?view=word-pia"/>
  public void ApplyQuickStyleSet2(object Style);

  /// <summary>
  /// Applies a theme to an open document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.applytheme?view=word-pia"/>
  public void ApplyTheme(string Name);

  /// <summary>
  /// Automatically formats a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autoformat?view=word-pia"/>
  public void AutoFormat();

  /// <summary>
  /// Creates an automatic summary of the specified document, and returns a Range object.
  /// </summary>
  /// <param name="length">The length of the summary as a percentage of the total document length
  /// (the larger the number, the more detail that's included in the summary).</param>
  /// <param name="mode">Specifies the way the summary is displayed. Can be one of the SummaryMode constants.</param>
  /// <param name="updateProperties">True to update the Keyword and Comments boxes in the Properties dialog box
  /// to reflect the content of the summary for the specified document.</param>
  /// <returns>A Range object representing the summary.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.autosummarize?view=word-pia"/>
  public Range AutoSummarize(SummaryLength length, SummaryMode mode, object updateProperties);

  /// <summary>
  /// Determines if Microsoft Word can check in a specified document to a server.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.cancheckin?view=word-pia"/>
  public bool CanCheckin();

  /// <summary>
  /// Searches all text in a Japanese language document and displays instances where character usage is inconsistent
  /// for the same words.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkconsistency?view=word-pia"/>
  public void CheckConsistency();

  /// <summary>
  /// Begins a spelling and grammar check for the specified document or range.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkgrammar?view=word-pia"/>
  public void CheckGrammar();

  /// <summary>
  /// Returns a document from a local computer to a server, and sets the local document to read-only so that it cannot be edited locally.
  /// </summary>
  /// <param name="SaveChanges">True saves the document to the server location. The default is True</param>
  /// <param name="Comments">Comments for the revision of the document being checked in (only applies if SaveChanges equals True).</param>
  /// <param name="MakePublic">True allows the user to publish on the document after being checked in.
  /// This submits the document for the approval process, which can eventually result in a version of the document
  /// being published to users with read-only rights to the document (only applies if SaveChanges equals True).</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkin?view=word-pia"/>
  public void CheckIn(bool SaveChanges, object Comments, bool MakePublic);

  /// <summary>
  /// Puts a document on a server from a local computer, and sets the local document to read-only so that it cannot be edited locally.
  /// </summary>
  /// <param name="SaveChanges">True saves the document to the server location. The default is True</param>
  /// <param name="Comments">Comments for the revision of the document being checked in (only applies if SaveChanges equals True).</param>
  /// <param name="MakePublic">True allows the user to publish on the document after being checked in.
  /// This submits the document for the approval process, which can eventually result in a version of the document
  /// being published to users with read-only rights to the document (only applies if SaveChanges equals True).</param>
  /// <param name="VersionType">The version type to assign to the document being checked in. Can be one of the CheckInVersionType constants (only applies if SaveChanges equals True).</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkinwithversion?view=word-pia"/>
  public void CheckInWithVersion(bool SaveChanges, object Comments, bool MakePublic, CheckInVersionType VersionType);

  /// <summary>
  /// Accesses the Microsoft Office Web site for available smart tag recognizer and action files.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checknewsmarttags?view=word-pia"/>
  public void CheckNewSmartTags();

  /// <summary>
  /// Begins a spelling check for the specified document or range.
  /// </summary>
  /// <param name="CustomDictionary">Either an expression that returns a Dictionary object or the file name of the custom dictionary.</param>
  /// <param name="IgnoreUppercase">True if capitalization is ignored. If this argument is omitted, the current value of the IgnoreUppercase property is used.</param>
  /// <param name="AlwaysSuggest">True for Microsoft Word to always suggest alternative spellings. If this argument is omitted, the current value of the SuggestSpellingCorrections property is used.</param>
  /// <param name="CustomDictionary2">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary3">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary4">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary5">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary6">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary7">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary8">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary9">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <param name="CustomDictionary10">Either an expression that returns a Dictionary object or the file name of an additional custom dictionary. You can specify as many as nine additional dictionaries.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.checkspelling?view=word-pia"/>
  public void CheckSpelling
  (object CustomDictionary, bool IgnoreUppercase, bool AlwaysSuggest, object CustomDictionary2,
    object CustomDictionary3, object CustomDictionary4, object CustomDictionary5, object CustomDictionary6,
    object CustomDictionary7, object CustomDictionary8, object CustomDictionary9, object CustomDictionary10);

  /// <summary>
  /// Closes the specified document or documents.
  /// </summary>
  /// <param name="SaveChanges">Specifies whether to save changes to the document. Can be one of the SaveOptions constants.</param>
  /// <param name="OriginalFormat">Specifies the format in which to save the document. Can be one of the OriginalFormat constants.</param>
  /// <param name="RouteDocument">Specifies whether to route the document. Can be True or False.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.close?view=word-pia"/>
  public void Close(SaveOptions SaveChanges, OriginalFormat OriginalFormat, bool RouteDocument);

  /// <summary>
  /// Switches the specified document from print preview to the previous view. If the specified document isn't in
  /// print preview, an error occurs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.closeprintpreview?view=word-pia"/>
  public void ClosePrintPreview();

  /// <summary>
  /// Displays revision marks that indicate where the specified document differs from another document.
  /// </summary>
  /// <param name="Name">The name of the document to compare with the specified document.</param>
  /// <param name="AuthorName">The name of the author to use for the comparison.</param>
  /// <param name="CompareTarget">Specifies the target for the comparison. Can be one of the CompareTarget constants.</param>
  /// <param name="DetectFormatChanges">Specifies whether to detect format changes. Can be True or False.</param>
  /// <param name="IgnoreAllComparisonWarnings">Specifies whether to ignore all comparison warnings. Can be True or False.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the recent files list. Can be True or False.</param>
  /// <param name="RemovePersonalInformation">Specifies whether to remove personal information. Can be True or False.</param>
  /// <param name="RemoveDateAndTime">Specifies whether to remove date and time information. Can be True or False.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compare?view=word-pia"/>
  public void Compare
  (string Name, string AuthorName, CompareTarget CompareTarget, bool DetectFormatChanges, bool IgnoreAllComparisonWarnings,
    bool AddToRecentFiles, bool RemovePersonalInformation, bool RemoveDateAndTime);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Name">The name of the document to compare with the specified document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compare2000?view=word-pia"/>
  public void Compare2000(string Name);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Name">The name of the document to compare with the specified document.</param>
  /// <param name="AuthorName">The name of the author to use for the comparison.</param>
  /// <param name="CompareTarget">Specifies the target for the comparison. Can be one of the CompareTarget constants.</param>
  /// <param name="DetectFormatChanges">Specifies whether to detect format changes. Can be True or False.</param>
  /// <param name="IgnoreAllComparisonWarnings">Specifies whether to ignore all comparison warnings. Can be True or False.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the recent files list. Can be True or False.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.compare2002?view=word-pia"/>
  public void Compare2002
  (string Name, string AuthorName, CompareTarget CompareTarget, bool DetectFormatChanges, bool IgnoreAllComparisonWarnings,
    bool AddToRecentFiles);

  /// <summary>
  /// Returns a statistic based on the contents of the specified document.
  /// </summary>
  /// <param name="Statistic">The statistic to return. Can be one of the Statistic constants.</param>
  /// <param name="IncludeFootnotesAndEndnotes">Specifies whether to include footnotes and endnotes. Can be True or False.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.computestatistics?view=word-pia"/>
  public int ComputeStatistics(Statistic Statistic, bool IncludeFootnotesAndEndnotes);

  /// <summary>
  /// Converts file to the newest file format and enables all new features.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convert?view=word-pia"/>
  public void Convert();

  /// <summary>
  /// Converts hyphens created by automatic hyphenation to manual hyphens.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convertautohyphens?view=word-pia"/>
  public void ConvertAutoHyphens();

  /// <summary>
  /// Changes the list numbers and LISTNUM fields in the specified object to text.
  /// </summary>
  /// <param name="NumberType">The type of numbers to convert. Can be one of the NumberType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convertnumberstotext?view=word-pia"/>
  public void ConvertNumbersToText(NumberType NumberType);

  /// <summary>
  /// Reconverts a Vietnamese document to Unicode using a code page other than the default.
  /// </summary>
  /// <param name="CodePageOrigin">The code page to use for the conversion.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.convertvietdoc?view=word-pia"/>
  public void ConvertVietDoc(int CodePageOrigin);

  /// <summary>
  /// Copies styles from the specified template to a document.
  /// </summary>
  /// <param name="Template">The name of the template from which to copy styles.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.copystylesfromtemplate?view=word-pia"/>
  public void CopyStylesFromTemplate(string Template);

  /// <summary>
  /// Returns the number of bulleted or numbered items and LISTNUM fields in the specified object.
  /// </summary>
  /// <param name="NumberType">The type of numbers to count. Can be one of the NumberType constants.</param>
  /// <param name="Level">The level of the numbers to count. Can be one of the WdListLevel constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.countnumbereditems?view=word-pia"/>
  public int CountNumberedItems(NumberType NumberType, int Level);

  /// <summary>
  /// Creates and returns a LetterContent object based on the specified letter elements.
  /// </summary>
  /// <param name="DateFormat">The format of the date.</param>
  /// <param name="IncludeHeaderFooter">Specifies whether to include the header and footer. Can be True or False.</param>
  /// <param name="PageDesign">The design of the page.</param>
  /// <param name="LetterStyle">The style of the letter.</param>
  /// <param name="Letterhead">Specifies whether to include the letterhead. Can be True or False.</param>
  /// <param name="LetterheadLocation">The location of the letterhead. Can be one of the LetterheadLocation constants.</param>
  /// <param name="LetterheadSize">The size of the letterhead.</param>
  /// <param name="RecipientName">The name of the recipient.</param>
  /// <param name="RecipientAddress">The address of the recipient.</param>
  /// <param name="Salutation">The salutation to use in the letter.</param>
  /// <param name="SalutationType">The type of salutation to use in the letter. Can be one of the SalutationType constants.</param>
  /// <param name="RecipientReference">The reference for the recipient.</param>
  /// <param name="MailingInstructions">The mailing instructions for the letter.</param>
  /// <param name="AttentionLine">The attention line for the letter.</param>
  /// <param name="Subject">The subject of the letter.</param>
  /// <param name="CCList">The list of recipients to receive a copy of the letter.</param>
  /// <param name="ReturnAddress">The return address for the letter.</param>
  /// <param name="SenderName">The name of the sender.</param>
  /// <param name="Closing">The closing to use in the letter.</param>
  /// <param name="SenderCompany">The company of the sender.</param>
  /// <param name="SenderJobTitle">The job title of the sender.</param>
  /// <param name="SenderInitials">The initials of the sender.</param>
  /// <param name="EnclosureNumber">The number of enclosures to include with the letter.</param>
  /// <param name="InfoBlock">The information block to include in the letter.</param>
  /// <param name="RecipientCode">The code for the recipient.</param>
  /// <param name="RecipientGender">The gender of the recipient.</param>
  /// <param name="ReturnAddressShortForm">The short form of the return address.</param>
  /// <param name="SenderCity">The city of the sender.</param>
  /// <param name="SenderCode">The code of the sender.</param>
  /// <param name="SenderGender">The gender of the sender.</param>
  /// <param name="SenderReference">The reference for the sender.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.createlettercontent?view=word-pia"/>
  public LetterContent CreateLetterContent
  (string DateFormat, bool IncludeHeaderFooter, string PageDesign, LetterStyle LetterStyle, bool Letterhead,
    LetterheadLocation LetterheadLocation, float LetterheadSize, string RecipientName, string RecipientAddress,
    string Salutation, SalutationType SalutationType, string RecipientReference, string MailingInstructions,
    string AttentionLine, string Subject, string CCList, string ReturnAddress, string SenderName, string Closing,
    string SenderCompany, string SenderJobTitle, string SenderInitials, int EnclosureNumber, object InfoBlock,
    object RecipientCode, object RecipientGender, object ReturnAddressShortForm, object SenderCity, object SenderCode,
    object SenderGender, object SenderReference);

  /// <summary>
  /// Displays the Data Form dialog box, in which you can add, delete, or modify data records.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dataform?view=word-pia"/>
  public void DataForm();

  /// <summary>
  /// Deletes all comments from the Comments collection in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deleteallcomments?view=word-pia"/>
  public void DeleteAllComments();

  /// <summary>
  /// Deletes all revisions in a specified document that are displayed on the screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deleteallcommentsshown?view=word-pia"/>
  public void DeleteAllCommentsShown();

  /// <summary>
  /// Deletes permissions in all ranges for which the specified user or group of users has permission to modify.
  /// </summary>
  /// <param name="EditorID">The user or group of users for which to delete permissions. Can be a user name, group name, or a combination of user and group names.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deletealleditableranges?view=word-pia"/>
  public void DeleteAllEditableRanges(object EditorID);

  /// <summary>
  /// Deletes all handwritten ink annotations in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.deleteallinkannotations?view=word-pia"/>
  public void DeleteAllInkAnnotations();

  /// <summary>
  /// Analyzes the specified text to determine the language that it is written in.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.detectlanguage?view=word-pia"/>
  public void DetectLanguage();

  /// <summary>
  /// Downgrades a document to the Word 97-2003 document format so that it can be edited in a previous version of
  /// Microsoft Office Word.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.downgradedocument?view=word-pia"/>
  public void DowngradeDocument();

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy1?view=word-pia"/>
  public void Dummy1();

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy2?view=word-pia"/>
  public void Dummy2();

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy3?view=word-pia"/>
  public void Dummy3();

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.dummy4?view=word-pia"/>
  public void Dummy4();

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <param name="Type">The type of edition.</param>
  /// <param name="Option">The edition option.</param>
  /// <param name="Name">The name of the edition.</param>
  /// <param name="Format">The format of the edition.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.editionoptions?view=word-pia"/>
  public void EditionOptions(EditionType Type, EditionOption Option, string Name, object Format);

  /// <summary>
  /// Terminates a review of a file that has been sent for review using the SendForReview(Object, Object, Object,
  /// Object) method or that has been automatically placed in a review cycle by sending a document to another user
  /// in an e-mail message.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.endreview?view=word-pia"/>
  public void EndReview();

  /// <summary>
  /// Saves a document as PDF or XPS format.
  /// </summary>
  /// <param name="OutputFileName">The name of the output file.</param>
  /// <param name="ExportFormat">The format to export the document to.</param>
  /// <param name="OpenAfterExport">Whether to open the document after export.</param>
  /// <param name="OptimizeFor">The optimization setting for the export.</param>
  /// <param name="Range">The range of pages to export.</param>
  /// <param name="From">The starting page number for the export.</param>
  /// <param name="To">The ending page number for the export.</param>
  /// <param name="Item">The item to export.</param>
  /// <param name="IncludeDocProps">Whether to include document properties.</param>
  /// <param name="KeepIRM">Whether to keep IRM settings.</param>
  /// <param name="CreateBookmarks">The bookmark creation setting.</param>
  /// <param name="DocStructureTags">Whether to include document structure tags.</param>
  /// <param name="BitmapMissingFonts">Whether to bitmap missing fonts.</param>
  /// <param name="UseISO19005_1">Whether to use ISO 19005-1 standard.</param>
  /// <param name="FixedFormatExtClassPtr">Specifies a pointer to an add-in that allows calls to an alternate
  /// implementation of code.The alternate implementation of code interprets the EMF and EMF+ page descriptions
  /// that are generated by the applications to make their own PDF or XPS. For more information,
  /// see "Extending the Office (2007) Fixed-Format Export Feature" on MSDN.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.exportasfixedformat?view=word-pia"/>
  public void ExportAsFixedFormat
  (string OutputFileName, ExportFormat ExportFormat, bool OpenAfterExport, ExportOptimizeFor OptimizeFor,
    ExportRange Range, int From, int To, ExportItem Item, bool IncludeDocProps, bool KeepIRM,
    ExportCreateBookmarks CreateBookmarks, bool DocStructureTags, bool BitmapMissingFonts, bool UseISO19005_1,
    object FixedFormatExtClassPtr);

  /// <summary>
  /// Decreases the font size of text just enough so that the document will fit on one fewer pages.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fittopages?view=word-pia"/>
  public void FitToPages();

  /// <summary>
  /// Displays a cached document if it's already been downloaded. Otherwise, this method resolves the hyperlink, downloads the target document, and displays the document in the appropriate application.
  /// </summary>
  /// <param name="Address">The URL of the target document.</param>
  /// <param name="SubAddress">The location within the target document.</param>
  /// <param name="NewWindow">Whether to open the target document in a new window.</param>
  /// <param name="AddHistory">Whether to add the target document to the history list.</param>
  /// <param name="ExtraInfo">Additional information for the hyperlink.</param>
  /// <param name="Method">The method to use for the hyperlink.</param>
  /// <param name="HeaderInfo">Header information for the hyperlink.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.followhyperlink?view=word-pia"/>
  public void FollowHyperlink
  (string Address, string SubAddress, bool NewWindow, bool AddHistory, object ExtraInfo, object Method,
    object HeaderInfo);

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.forwardmailer?view=word-pia"/>
  public void ForwardMailer();

  /// <summary>
  /// In Web view, fixes the layout of the document as it currently appears so that line breaks remain fixed and ink
  /// annotations do not move when you resize the window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.freezelayout?view=word-pia"/>
  public void FreezeLayout();

  /// <summary>
  /// Returns an array of items that can be cross-referenced based on the specified cross-reference type.
  /// </summary>
  /// <param name="ReferenceType">The type of items to return. Can be one of the ReferenceType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getcrossreferenceitems?view=word-pia"/>
  public object GetCrossReferenceItems(ReferenceType ReferenceType);

  /// <summary>
  /// Retrieves letter elements from the specified document and returns a LetterContent object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getlettercontent?view=word-pia"/>
  public LetterContent GetLetterContent();

  /// <summary>
  /// Returns the workflow tasks assigned to a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getworkflowtasks?view=word-pia"/>
  public Core.WorkflowTasks GetWorkflowTasks();

  /// <summary>
  /// Returns the workflow templates attached to a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.getworkflowtemplates?view=word-pia"/>
  public Core.WorkflowTemplates GetWorkflowTemplates();

  /// <summary>
  /// Returns a Range object that represents the start position of the specified item.
  /// </summary>
  /// <param name="What">The item to return. Can be one of the GoToItem constants.</param>
  /// <param name="Which">Specifies which instance of the item to return. Can be one of the GoToDirection constants.</param>
  /// <param name="Count">Specifies the number of items to return.</param>
  /// <param name="Name">Specifies the name of the item to return.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.goto?view=word-pia"/>
  public Range GoTo(GoToItem What, GoToDirection Which, int Count, string Name);

  /// <summary>
  /// Locks the file on the server preventing anyone else from editing it.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.lockserverfile?view=word-pia"/>
  public void LockServerFile();

  /// <summary>
  /// Sets the compatibility options on the Compatibility tab in the Options dialog box (Tools menu) as the default
  /// settings for new documents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.makecompatibilitydefault?view=word-pia"/>
  public void MakeCompatibilityDefault();

  /// <summary>
  /// Initiates manual hyphenation of a document, one line at a time. The user is prompted to accept or decline
  /// suggested hyphenations.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.manualhyphenation?view=word-pia"/>
  public void ManualHyphenation();

  /// <summary>
  /// Merges the changes marked with revision marks from one document to another.
  /// </summary>
  /// <param name="FileName">The name of the document to merge with the specified document.</param>
  /// <param name="MergeTarget">Specifies the target for the merge. Can be one of the MergeTarget constants.</param>
  /// <param name="DetectFormatChanges">Specifies whether to detect format changes. Can be one of the MergeFormatFrom constants.</param>
  /// <param name="UseFormattingFrom">Specifies which document's formatting to use. Can be one of the WdMergeFormattingFrom constants.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the merged document to the recent files list.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.merge?view=word-pia"/>
  public void Merge
  (string FileName, MergeTarget MergeTarget, MergeFormatFrom DetectFormatChanges, object UseFormattingFrom,
    bool AddToRecentFiles);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.merge2000?view=word-pia"/>
  public void Merge2000(string FileName);

  /// <summary>
  /// Posts the specified document to a public folder in Microsoft Exchange. This method displays the Send to
  /// Exchange Folder dialog box so that a folder can be selected.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.post?view=word-pia"/>
  public void Post();

  /// <summary>
  /// Opens PowerPoint with the specified Word document loaded.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.presentit?view=word-pia"/>
  public void PresentIt();

  /// <summary>
  /// Prints all or part of the specified document.
  /// </summary>
  /// <param name="Background">Whether to print in the background. Can be True or False.</param>
  /// <param name="Append">Whether to append the document to the printer queue. Can be True or False.</param>
  /// <param name="Range">The range of the document to print. Can be one of the PrintOutRange constants.</param>
  /// <param name="OutputFileName">The name of the file to print to when printing to a file.</param>
  /// <param name="From">The starting page number to print.</param>
  /// <param name="To">The ending page number to print.</param>
  /// <param name="Item">Specifies the item to print. Can be one of the PrintOutItem constants.</param>
  /// <param name="Copies">The number of copies to print.</param>
  /// <param name="Pages">The pages to print. Can be a string specifying page ranges.</param>
  /// <param name="PageType">Specifies the type of pages to print. Can be one of the PrintOutPages constants.</param>
  /// <param name="PrintToFile">Whether to print to a file. Can be True or False.</param>
  /// <param name="Collate">Whether to collate multiple copies. Can be True or False.</param>
  /// <param name="ActivePrinterMacGX">The name of the printer to use when printing from a Macintosh running Mac OS X.</param>
  /// <param name="ManualDuplexPrint">Whether to print manually on both sides of the paper. Can be True or False.</param>
  /// <param name="PrintZoomColumn">The number of columns to use when printing in zoom mode.</param>
  /// <param name="PrintZoomRow">The number of rows to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperWidth">The width of the paper to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperHeight">The height of the paper to use when printing in zoom mode.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printout?view=word-pia"/>
  public void PrintOut
  (bool Background, bool Append, PrintOutRange Range, string OutputFileName, int From, int To, PrintOutItem Item,
    int Copies, string Pages, PrintOutPages PageType, bool PrintToFile, bool Collate, string ActivePrinterMacGX,
    bool ManualDuplexPrint, int PrintZoomColumn, int PrintZoomRow, int PrintZoomPaperWidth,
    int PrintZoomPaperHeight);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Background">Whether to print in the background. Can be True or False.</param>
  /// <param name="Append">Whether to append the document to the printer queue. Can be True or False.</param>
  /// <param name="Range">The range of the document to print. Can be one of the PrintOutRange constants.</param>
  /// <param name="OutputFileName">The name of the file to print to when printing to a file.</param>
  /// <param name="From">The starting page number to print.</param>
  /// <param name="To">The ending page number to print.</param>
  /// <param name="Item">Specifies the item to print. Can be one of the PrintOutItem constants.</param>
  /// <param name="Copies">The number of copies to print.</param>
  /// <param name="Pages">The pages to print. Can be a string specifying page ranges.</param>
  /// <param name="PageType">Specifies the type of pages to print. Can be one of the PrintOutPages constants.</param>
  /// <param name="PrintToFile">Whether to print to a file. Can be True or False.</param>
  /// <param name="Collate">Whether to collate multiple copies. Can be True or False.</param>
  /// <param name="ActivePrinterMacGX">The name of the printer to use when printing from a Macintosh running Mac OS X.</param>
  /// <param name="ManualDuplexPrint">Whether to print manually on both sides of the paper. Can be True or False.</param>
  /// <param name="PrintZoomColumn">The number of columns to use when printing in zoom mode.</param>
  /// <param name="PrintZoomRow">The number of rows to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperWidth">The width of the paper to use when printing in zoom mode.</param>
  /// <param name="PrintZoomPaperHeight">The height of the paper to use when printing in zoom mode.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printout2000?view=word-pia"/>
  public void PrintOut2000
  (bool Background, bool Append, PrintOutRange Range, string OutputFileName, int From, int To, PrintOutItem Item,
    int Copies, string Pages, PrintOutPages PageType, bool PrintToFile, bool Collate, string ActivePrinterMacGX,
    bool ManualDuplexPrint, int PrintZoomColumn, int PrintZoomRow, int PrintZoomPaperWidth,
    int PrintZoomPaperHeight);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Background">Whether to print in the background. Can be True or False.</param>
  /// <param name="Append">Whether to append the document to the printer queue. Can be True or False.</param>
  /// <param name="Range">The range of the document to print. Can be one of the PrintOutRange constants.</param>
  /// <param name="OutputFileName">The name of the file to print to when printing to a file.</param>
  /// <param name="From">The starting page number to print.</param>
  /// <param name="To">The ending page number to print.</param>
  /// <param name="Item">Specifies the item to print. Can be one of the PrintOutItem constants.</param>
  /// <param name="Copies">The number of copies to print.</param>
  /// <param name="Pages">The pages to print. Can be a string specifying page ranges.</param>
  /// <param name="PageType">Specifies the type of pages to print. Can be one of the PrintOutPages constants.</param>
  /// <param name="PrintToFile">Whether to print to a file. Can be True or False.</param>
  /// <param name="Collate">Whether to collate multiple copies. Can be True or False.</param>
  /// <param name="ActivePrinterMacGX">The name of the printer to use when printing from a Macintosh running Mac OS X.</param>
  /// <param name="ManualDuplexPrint">Whether to print manually on both sides of the paper. Can be True or False.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printoutold?view=word-pia"/>
  public void PrintOutOld
  (object Background, object Append, object Range, object OutputFileName, object From, object To, object Item,
    object Copies, object Pages, object PageType, object PrintToFile, object Collate, object ActivePrinterMacGX,
    object ManualDuplexPrint);

  /// <summary>
  /// Switches the view to print preview.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.printpreview?view=word-pia"/>
  public void PrintPreview();

  /// <summary>
  /// Helps to protect the specified document from changes. When a document is protected, users can make only limited changes, such as adding annotations, making revisions, or completing a form.
  /// </summary>
  /// <param name="Type">The type of protection to apply. Can be one of the ProtectionType constants.</param>
  /// <param name="NoReset">Whether to reset the protection settings. Can be True or False.</param>
  /// <param name="Password">The password to use for protection.</param>
  /// <param name="UseIRM">Whether to use Information Rights Management (IRM) for protection. Can be True or False.</param>
  /// <param name="EnforceStyleLock">Whether to enforce style lock. Can be True or False.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.protect?view=word-pia"/>
  public void Protect(ProtectionType Type, bool NoReset, string Password, bool UseIRM, bool EnforceStyleLock);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="Type">The type of protection to apply. Can be one of the ProtectionType constants.</param>
  /// <param name="NoReset">Whether to reset the protection settings. Can be True or False.</param>
  /// <param name="Password">The password to use for protection.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.protect2002?view=word-pia"/>
  public void Protect2002(ProtectionType Type, bool NoReset, string Password);

  /// <summary>
  /// Returns a Range object by using the specified starting and ending character positions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.range?view=word-pia"/>
  public Range Range(object Start, object End);

  /// <summary>
  /// Removes smart tags recognized by the grammar checker and rechecks the document content against all smart tag
  /// recognizers.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.rechecksmarttags?view=word-pia"/>
  public void RecheckSmartTags();

  /// <summary>
  /// Redoes the last action that was undone (reverses the Undo(Object) method). Returns True if the actions were redone successfully.
  /// </summary>
  /// <param name="Times">The number of times to redo the last action. If this argument is omitted, the default value is 1.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.redo?view=word-pia"/>
  public bool Redo(int Times);

  /// <summary>
  /// Rejects all tracked changes in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.rejectallrevisions?view=word-pia"/>
  public void RejectAllRevisions();

  /// <summary>
  /// Rejects all revisions in a document that are displayed on the screen.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.rejectallrevisionsshown?view=word-pia"/>
  public void RejectAllRevisionsShown();

  /// <summary>
  /// Reloads a cached document by resolving the hyperlink to the document and downloading it.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reload?view=word-pia"/>
  public void Reload();

  /// <summary>
  /// Reloads a document based on an HTML document, using the specified document encoding.
  /// </summary>
  /// <param name="Encoding">The encoding to use for the HTML document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reloadas?view=word-pia"/>
  public void ReloadAs(Core.Encoding Encoding);

  /// <summary>
  /// Removes sensitive information, properties, comments, and other metadata from a document.
  /// </summary>
  /// <param name="RemoveDocInfoType">The type of information to remove. Can be one of the RemoveDocInfoType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removedocumentinformation?view=word-pia"/>
  public void RemoveDocumentInformation(RemoveDocInfoType RemoveDocInfoType);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="ID">The ID of the document workspace header to remove.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removedocumentworkspaceheader?view=word-pia"/>
  public void RemoveDocumentWorkspaceHeader(string ID);

  /// <summary>
  /// Purges a document of locked styles when formatting restrictions have been applied in a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removelockedstyles?view=word-pia"/>
  public void RemoveLockedStyles();

  /// <summary>
  /// Removes numbers or bullets from the specified object.
  /// </summary>
  /// <param name="NumberType">The type of numbering to remove. Can be one of the NumberType constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removenumbers?view=word-pia"/>
  public void RemoveNumbers(NumberType NumberType);

  /// <summary>
  /// Removes all smart tag information from a document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removesmarttags?view=word-pia"/>
  public void RemoveSmartTags();

  /// <summary>
  /// Removes the active theme from the current document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.removetheme?view=word-pia"/>
  public void RemoveTheme();

  /// <summary>
  /// Repaginates the entire document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.repaginate?view=word-pia"/>
  public void Repaginate();

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.reply?view=word-pia"/>
  public void Reply();

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.replyall?view=word-pia"/>
  public void ReplyAll();

  /// <summary>
  /// Sends an e-mail message to the author of a document that has been sent out for review, notifying them that a reviewer has completed review of the document.
  /// </summary>
  /// <param name="ShowMessage">Specifies whether to show a message when replying with changes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.replywithchanges?view=word-pia"/>
  public void ReplyWithChanges(bool ShowMessage);

  /// <summary>
  /// Clears all form fields in a document, preparing the form to be filled in again.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.resetformfields?view=word-pia"/>
  public void ResetFormFields();

  /// <summary>
  /// Returns the active document to the last saved reading position, and returns an integer that represents that
  /// position.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.returntolastreadposition?view=word-pia"/>
  public int ReturnToLastReadPosition();

  /// <summary>
  /// Routes the specified document, using the document's current routing slip.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.route?view=word-pia"/>
  public void Route();

  /// <summary>
  /// Runs an auto macro that's stored in the specified document. If the specified auto macro doesn't exist, nothing happens.
  /// </summary>
  /// <param name="Which">Specifies which auto macro to run. Can be one of the AutoMacros constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.runautomacro?view=word-pia"/>
  public void RunAutoMacro(AutoMacros Which);

  /// <summary>
  /// Runs the Letter Wizard on the specified document.
  /// </summary>
  /// <param name="LetterContent">Specifies the content of the letter. Can be one of the WdLetterContent constants.</param>
  /// <param name="WizardMode">Specifies the mode of the wizard. Can be one of the WdLetterWizard constants.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.runletterwizard?view=word-pia"/>
  public void RunLetterWizard(object LetterContent, object WizardMode);

  /// <summary>
  /// Saves the specified document. If the document hasn't been saved before, the Save As dialog box prompts the
  /// user for a file name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.save?view=word-pia"/>
  public void Save();

  /// <summary>
  /// Saves the specified document with a new name or format. Some of the arguments for this method correspond to the options in the Save Asdialog box (File menu).
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <param name="Encoding">The encoding to use when saving the document.</param>
  /// <param name="InsertLineBreaks">Specifies whether to insert line breaks when saving the document.</param>
  /// <param name="AllowSubstitutions">Specifies whether to allow substitutions when saving the document.</param>
  /// <param name="LineEnding">Specifies the line ending to use when saving the document.</param>
  /// <param name="AddBiDiMarks">Specifies whether to add bidirectional marks when saving the document.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveas?view=word-pia"/>
  public void SaveAs
  (string FileName, SaveFormat FileFormat, bool LockComments, string Password, bool AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter, int Encoding, bool InsertLineBreaks, bool AllowSubstitutions,
    int LineEnding, bool AddBiDiMarks);

  /// <summary>
  /// Saves the specified document with a new name or format. Some of the arguments for this method correspond to the options in the Save As dialog box (File tab).
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <param name="Encoding">The encoding to use when saving the document.</param>
  /// <param name="InsertLineBreaks">Specifies whether to insert line breaks when saving the document.</param>
  /// <param name="AllowSubstitutions">Specifies whether to allow substitutions when saving the document.</param>
  /// <param name="LineEnding">Specifies the line ending to use when saving the document.</param>
  /// <param name="AddBiDiMarks">Specifies whether to add bidirectional marks when saving the document.</param>
  /// <param name="CompatibilityMode">Specifies the compatibility mode to use when saving the document.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveas2?view=word-pia"/>
  public void SaveAs2
  (string FileName, SaveFormat FileFormat, bool LockComments, string Password, bool AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter, int Encoding, bool InsertLineBreaks, bool AllowSubstitutions,
    int LineEnding, bool AddBiDiMarks, object CompatibilityMode);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveas2000?view=word-pia"/>
  public void SaveAs2000
  (object FileName, object FileFormat, object LockComments, object Password, object AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter);

  /// <summary>
  /// Saves the group of quick styles currently in use.
  /// </summary>
  /// <param name="FileName">The name of the file to save the quick style set as.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.saveasquickstyleset?view=word-pia"/>
  public void SaveAsQuickStyleSet(string FileName);

  /// <summary>
  /// Saves the specified document with a new name or format.
  /// Some of the arguments for this method correspond to the options in the Save As dialog box (File tab).
  /// This method is reserved for internal use, and its behavior may change, or it may be removed in future versions of Microsoft Office Word.
  /// </summary>
  /// <param name="FileName">The name of the file to save the document as.</param>
  /// <param name="FileFormat">The format in which to save the document. Can be one of the SaveFormat constants.</param>
  /// <param name="LockComments">Specifies whether to lock comments in the document.</param>
  /// <param name="Password">The password to protect the document.</param>
  /// <param name="AddToRecentFiles">Specifies whether to add the document to the list of recent files.</param>
  /// <param name="WritePassword">The password required to modify the document.</param>
  /// <param name="ReadOnlyRecommended">Specifies whether to recommend the document to be opened as read-only.</param>
  /// <param name="EmbedTrueTypeFonts">Specifies whether to embed TrueType fonts in the document.</param>
  /// <param name="SaveNativePictureFormat">Specifies whether to save pictures in their native format.</param>
  /// <param name="SaveFormsData">Specifies whether to save form data in the document.</param>
  /// <param name="SaveAsAOCELetter">Specifies whether to save the document as an AOCE letter.</param>
  /// <param name="Encoding">The encoding to use when saving the document.</param>
  /// <param name="InsertLineBreaks">Specifies whether to insert line breaks when saving the document.</param>
  /// <param name="AllowSubstitutions">Specifies whether to allow substitutions when saving the document.</param>
  /// <param name="LineEnding">Specifies the line ending to use when saving the document.</param>
  /// <param name="AddBiDiMarks">Specifies whether to add bidirectional marks when saving the document.</param>
  /// <param name="CompatibilityMode">Specifies the compatibility mode to use when saving the document.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.savecopyas?view=word-pia"/>
  public void SaveCopyAs
  (string FileName, SaveFormat FileFormat, bool LockComments, string Password, bool AddToRecentFiles,
    string WritePassword, bool ReadOnlyRecommended, bool EmbedTrueTypeFonts, bool SaveNativePictureFormat,
    bool SaveFormsData, bool SaveAsAOCELetter, int Encoding, bool InsertLineBreaks, bool AllowSubstitutions,
    int LineEnding, bool AddBiDiMarks, object CompatibilityMode);

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sblt?view=word-pia"/>
  public void sblt(string s);

  /// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.select?view=word-pia"/>
  public void Select();

  /// <summary>
  /// Selects all ranges for which the specified user or group of users has permission to modify.
  /// </summary>
  /// <param name="EditorID">The ID of the user or group of users.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectalleditableranges?view=word-pia"/>
  public void SelectAllEditableRanges(object EditorID);

  /// <summary>
  /// Returns a ContentControls collection that represents all the content controls in a document with the tag value specified in the Tag parameter. Read-only.
  /// </summary>
  /// <param name="Tag">The tag value of the content controls to return.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectcontentcontrolsbytag?view=word-pia"/>
  public ContentControls SelectContentControlsByTag(string Tag);

  /// <summary>
  /// Returns a ContentControls collection that represents all the content controls in a document with the title specified in the Title parameter. Read-only.
  /// </summary>
  /// <param name="Title">The title of the content controls to return.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectcontentcontrolsbytitle?view=word-pia"/>
  public ContentControls SelectContentControlsByTitle(string Title);

  /// <summary>
  /// Returns a ContentControls collection that represents all content controls in a document that are linked to the specific custom XML node in the document's XML data store as specified by the Node parameter. Read-only.
  /// </summary>
  /// <param name="Node">The custom XML node to which the content controls are linked.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectlinkedcontrols?view=word-pia"/>
  public ContentControls SelectLinkedControls(Core.CustomXMLNode Node);

  /// <summary>
  /// Returns an XMLNodes collection that represents all the specified nodes in the order in which they appear in the document.
  /// </summary>
  /// <param name="XPath">The XPath expression to evaluate.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="FastSearchSkippingTextNodes">Specifies whether to use fast search by skipping text nodes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectnodes?view=word-pia"/>
  public XMLNodes SelectNodes(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes);

  /// <summary>
  /// Returns an XMLNode object that represents a node in the specified document.
  /// </summary>
  /// <param name="XPath">The XPath expression to evaluate.</param>
  /// <param name="PrefixMapping">The prefix mapping for the XPath expression.</param>
  /// <param name="FastSearchSkippingTextNodes">Specifies whether to use fast search by skipping text nodes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectsinglenode?view=word-pia"/>
  public XMLNode SelectSingleNode(string XPath, string PrefixMapping, bool FastSearchSkippingTextNodes);

  /// <summary>
  /// Returns all of the content controls in a document that are not linked to an XML node in the document's XML data store. Read-only.
  /// </summary>
  /// <param name="Stream">The custom XML part to which the content controls are linked.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.selectunlinkedcontrols?view=word-pia"/>
  public ContentControls SelectUnlinkedControls(Core.CustomXMLPart Stream);

  /// <summary>
  /// Sends the specified document as a fax, without any user interaction.
  /// </summary>
  /// <param name="Address">The fax number to send the document to.</param>
  /// <param name="Subject">The subject of the fax.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendfax?view=word-pia"/>
  public void SendFax(string Address, string Subject);

  /// <summary>
  /// Sends a document to a fax service provider, who faxes the document to one or more specified recipients.
  /// </summary>
  /// <param name="Recipients">The recipients to send the fax to.</param>
  /// <param name="Subject">The subject of the fax.</param>
  /// <param name="ShowMessage">Specifies whether to show a message when sending the fax.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendfaxoverinternet?view=word-pia"/>
  public void SendFaxOverInternet(object Recipients, string Subject, bool ShowMessage);

  /// <summary>
  /// Sends a document in an e-mail message for review by the specified recipients.
  /// </summary>
  /// <param name="Recipients">The recipients to send the document to for review.</param>
  /// <param name="Subject">The subject of the review request.</param>
  /// <param name="ShowMessage">Specifies whether to show a message when sending the review request.</param>
  /// <param name="IncludeAttachment">Specifies whether to include the document as an attachment.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendforreview?view=word-pia"/>
  public void SendForReview(object Recipients, string Subject, bool ShowMessage, bool IncludeAttachment);

  /// <summary>
  /// Opens a message window for sending the specified document through Microsoft Exchange.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendmail?view=word-pia"/>
  public void SendMail();

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <param name="FileFormat">The file format to use when sending the mailer.</param>
  /// <param name="Priority">The priority of the mailer.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.sendmailer?view=word-pia"/>
  public void SendMailer(object FileFormat, object Priority);

  /// <summary>
  /// Sets the compatibility mode for the document.
  /// </summary>
  /// <param name="Mode">The compatibility mode to set for the document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setcompatibilitymode?view=word-pia"/>
  public void SetCompatibilityMode(int Mode);

  /// <summary>
  /// Specifies the table style to use for newly created tables in a document.
  /// </summary>
  /// <param name="Style">The table style to set as the default for newly created tables.</param>
  /// <param name="SetInTemplate">Specifies whether to set the default table style in the template.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setdefaulttablestyle?view=word-pia"/>
  public void SetDefaultTableStyle(object Style, bool SetInTemplate);

  /// <summary>
  /// Inserts the contents of the specified LetterContent object into a document.
  /// </summary>
  /// <param name="LetterContent">The LetterContent object that contains the letter elements to insert into the document.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setlettercontent?view=word-pia"/>
  public void SetLetterContent(object LetterContent);

  /// <summary>
  /// Sets the options Microsoft Word uses for encrypting documents with passwords.
  /// </summary>
  /// <param name="PasswordEncryptionProvider">The provider to use for password encryption.</param>
  /// <param name="PasswordEncryptionAlgorithm">The algorithm to use for password encryption.</param>
  /// <param name="PasswordEncryptionKeyLength">The key length to use for password encryption.</param>
  /// <param name="PasswordEncryptionFileProperties">Specifies whether to encrypt file properties.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.setpasswordencryptionoptions?view=word-pia"/>
  public void SetPasswordEncryptionOptions
  (string PasswordEncryptionProvider, string PasswordEncryptionAlgorithm, int PasswordEncryptionKeyLength,
    bool PasswordEncryptionFileProperties);

  /// <summary>
  /// Toggles form design mode on or off.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.toggleformsdesign?view=word-pia"/>
  public void ToggleFormsDesign();

  /// <summary>
  /// Applies the specified Extensible Stylesheet Language Transformation (XSLT) file to the specified document and replaces the document with the results.
  /// </summary>
  /// <param name="Path">The path to the XSLT file to apply to the document.</param>
  /// <param name="DataOnly">Specifies whether to apply the transformation to the data only.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.transformdocument?view=word-pia"/>
  public void TransformDocument(string Path, bool DataOnly);

  /// <summary>
  /// Undoes the last action or a sequence of actions, which are displayed in the Undo list. Returns True if the actions were successfully undone.
  /// </summary>
  /// <param name="Times">The number of actions to undo.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.undo?view=word-pia"/>
  public bool Undo(int Times);

  /// <summary>
  /// Clears the list of actions that can be undone for the specified document. Corresponds to the list of items
  /// that appears when you click the arrow beside the Undo button on the Standard toolbar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.undoclear?view=word-pia"/>
  public void UndoClear();

  /// <summary>
  /// Reverses the effect of UnfreezeLayout(), and enables line breaks to change and ink annotations to move when
  /// you resize the Web browser window.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.unfreezelayout?view=word-pia"/>
  public void UnfreezeLayout();

  /// <summary>
  /// Removes protection from the specified document. If the document isn't protected, this method generates an error.
  /// </summary>
  /// <param name="Password">The password used to protect the document, if any. If the document isn't protected with a password, this argument is ignored.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.unprotect?view=word-pia"/>
  public void Unprotect(string Password);

  /// <summary>
  /// Copies all styles from the attached template into the document, overwriting any existing styles in the
  /// document that have the same name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.updatestyles?view=word-pia"/>
  public void UpdateStyles();

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.updatesummaryproperties?view=word-pia"/>
  public void UpdateSummaryProperties();

  /// <summary>
  /// Displays the code window for the selected ActiveX control in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.viewcode?view=word-pia"/>
  public void ViewCode();

  /// <summary>
  /// Displays the property window for the selected ActiveX control in the specified document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.viewpropertybrowser?view=word-pia"/>
  public void ViewPropertyBrowser();

  /// <summary>
  /// Displays a preview of the current document as it would look if saved as a Web page.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.webpagepreview?view=word-pia"/>
  public void WebPagePreview();

  #endregion methods
}
