namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object.For information about the COM object, see Document
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document?view=word-pia"/>
public partial interface _Document : InteropObject
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
  public WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfter { get; set; }

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
  public WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }

  /// <summary>
  /// Returns or sets the line break control level for the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.fareastlinebreaklevel?view=word-pia"/>
  public WdFarEastLineBreakLevel FarEastLineBreakLevel { get; set; }

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
  /// Returns or sets a WdShowFilter constant that represents the styles and formatting displayed in the Styles and Formatting task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.formattingshowfilter?view=word-pia"/>
  public WdShowFilter FormattingShowFilter { get; set; }

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
  public WdJustificationMode JustificationMode { get; set; }

  /// <summary>
  /// Determines if Microsoft Word kerns half-width Latin characters and punctuation marks in the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.kerningbyalgorithm?view=word-pia"/>
  public bool KerningByAlgorithm { get; set; }

  /// <summary>
  /// Returns or sets the format type that Microsoft Word uses when automatically formatting the specified document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.kind?view=word-pia"/>
  public WdDocumentKind Kind { get; set; }

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
  /// Returns or sets a WdOMathBreakBin enumeration value that represents where Microsoft Office Word places binary operators when equations span two or more lines. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathbreakbin?view=word-pia"/>
  public WdOMathBreakBin OMathBreakBin { get; set; }

  /// <summary>
  /// Returns or sets a WdOMathBreakSub enumeration value that represents how Microsoft Office Word handles a subtraction operator that falls before a line break. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.omathbreaksub?view=word-pia"/>
  public WdOMathBreakSub OMathBreakSub { get; set; }

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
  public WdOMathJc OMathJc { get; set; }

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
  public Core.MsoEncoding OpenEncoding { get; }

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
  public WdProtectionType ProtectionType { get; }

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
  public Core.MsoEncoding SaveEncoding { get; set; }

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
  public WdStyleSort StyleSortMethod { get; set; }

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
  public WdSummaryMode SummaryViewMode { get; set; }

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
  public Core.MsoEncoding TextEncoding { get; set; }

  /// <summary>
  /// Returns or sets a WdLineEndingType constant indicating how Microsoft Word marks the line and paragraph breaks in documents saved as text files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._document.textlineending?view=word-pia"/>
  public WdLineEndingType TextLineEnding { get; set; }

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
  public WdDocumentType Type { get; }

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

}
