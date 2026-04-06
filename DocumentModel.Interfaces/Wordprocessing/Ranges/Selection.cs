using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the current selection in a window or pane.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection?view=word-pia"/>
public partial interface ISelection : IModelObject
{
  /// <summary>
  /// Returns or sets the text in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// Returns or sets a Range object that includes the formatted text in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.formattedtext?view=word-pia"/>
  public IRange FormattedText { get; set; }

  /// <summary>
  /// Returns or sets the starting character position of a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.start?view=word-pia"/>
  public int Start { get; set; }

  /// <summary>
  /// Returns or sets the ending character position of a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.end?view=word-pia"/>
  public int End { get; set; }

  /// <summary>
  /// Returns or sets a TextFormat object that represents the character formatting of the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.font?view=word-pia"/>
  public ITextFormat TextFormat { get; set; }

  /// <summary>
  /// Returns the selection type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.type?view=word-pia"/>
  public SelectionType Type { get; }

  /// <summary>
  /// Returns the story type for the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.storytype?view=word-pia"/>
  public StoryType StoryType { get; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns a Tables collection that represents all the tables in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.tables?view=word-pia"/>
  public ITables Tables { get; }

  /// <summary>
  /// Returns a Words collection that represents all the words in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.words?view=word-pia"/>
  public IWords Words { get; }

  /// <summary>
  /// Returns a Sentences collection that represents all the sentences in the selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.sentences?view=word-pia"/>
  public ISentences Sentences { get; }

  /// <summary>
  /// Returns a Characters collection that represents the characters in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.characters?view=word-pia"/>
  public ICharacters Characters { get; }

  /// <summary>
  /// Returns a Footnotes collection that represents all the footnotes in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.footnotes?view=word-pia"/>
  public IFootnotes Footnotes { get; }

  /// <summary>
  /// Returns a Endnotes collection that represents all the endnotes in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.endnotes?view=word-pia"/>
  public IEndnotes Endnotes { get; }

  /// <summary>
  /// Returns a Comments collection that represents all the comments in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.comments?view=word-pia"/>
  public IComments Comments { get; }

  /// <summary>
  /// Returns a Cells collection that represents the table cells in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.cells?view=word-pia"/>
  public ICells Cells { get; }

  /// <summary>
  /// Returns a Sections collection that represents the sections in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.sections?view=word-pia"/>
  public ISections Sections { get; }

  /// <summary>
  /// Returns a Paragraphs collection that represents all the paragraphs in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.paragraphs?view=word-pia"/>
  public IParagraphs Paragraphs { get; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.borders?view=word-pia"/>
  public IBorders Borders { get; set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Returns a read-only Fields collection that represents all the fields in the selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.fields?view=word-pia"/>
  public IFields Fields { get; }

  /// <summary>
  /// Returns a FormFields collection that represents all the form fields in the selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.formfields?view=word-pia"/>
  public IFormFields FormFields { get; }

  /// <summary>
  /// Returns a Frames collection that represents all the frames in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.frames?view=word-pia"/>
  public IFrames Frames { get; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the paragraph settings for the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.paragraphformat?view=word-pia"/>
  public IParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// Returns a PageSetup object that's associated with the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.pagesetup?view=word-pia"/>
  public IPageSetup PageSetup { get; set; }

  /// <summary>
  /// Returns a Bookmarks collection that represents all the bookmarks in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.bookmarks?view=word-pia"/>
  public IBookmarks Bookmarks { get; }

  /// <summary>
  /// Returns the number of characters in the story that contains the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.storylength?view=word-pia"/>
  public int StoryLength { get; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageid?view=word-pia"/>
  public LanguageID LanguageID { get; set; }

  /// <summary>
  /// Returns or sets an East Asian language for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageidfareast?view=word-pia"/>
  public LanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// Returns or sets the language for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languageidother?view=word-pia"/>
  public LanguageID LanguageIDOther { get; set; }

  /// <summary>
  /// Returns a Hyperlinks collection that represents all the hyperlinks in the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.hyperlinks?view=word-pia"/>
  public IHyperlinks Hyperlinks { get; }

  /// <summary>
  /// Returns a Columns collection that represents all the table columns in the selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.columns?view=word-pia"/>
  public IColumns Columns { get; }

  /// <summary>
  /// Returns a Rows collection that represents all the table rows in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.rows?view=word-pia"/>
  public IRows Rows { get; }

  /// <summary>
  /// Returns a HeaderFooter object for the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.headerfooter?view=word-pia"/>
  public IHeaderFooter HeaderFooter { get; }

  /// <summary>
  /// Determines if the specified selection is collapsed and is located at the end-of-row mark in a table.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.isendofrowmark?view=word-pia"/>
  public bool IsEndOfRowMark { get; }

  /// <summary>
  /// Returns the number of the bookmark that encloses the beginning of the specified selection or 0 (zero) if
  /// there's no corresponding bookmark.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.bookmarkid?view=word-pia"/>
  public int BookmarkID { get; }

  /// <summary>
  /// Returns the number of the last bookmark that starts before or at the same place as the specified selection or
  /// returns 0 (zero) if there's no corresponding bookmark.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.previousbookmarkid?view=word-pia"/>
  public int PreviousBookmarkID { get; }

  /// <summary>
  /// Returns a Find object that contains the criteria for a find operation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.find?view=word-pia"/>
  public IFind Find { get; }

  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.range?view=word-pia"/>
  public IRange Range { get; }

  /// <summary>
  /// Returns or sets properties of the selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.flags?view=word-pia"/>
  public SelectionFlags Flags { get; set; }

  /// <summary>
  /// Determines if the selection in the specified window or pane is active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.active?view=word-pia"/>
  public bool Active { get; }

  /// <summary>
  /// Determines if the beginning of the selection is active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.startisactive?view=word-pia"/>
  public bool StartIsActive { get; set; }

  /// <summary>
  /// Determines if the insertion point is at the end of a line that wraps to the next line.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.ipatendofline?view=word-pia"/>
  public bool IPAtEndOfLine { get; }

  /// <summary>
  /// Determines if Extend mode is active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.extendmode?view=word-pia"/>
  public bool ExtendMode { get; set; }

  /// <summary>
  /// Determines if column selection mode is active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.columnselectmode?view=word-pia"/>
  public bool ColumnSelectMode { get; set; }

  /// <summary>
  /// Returns or sets the orientation of text in a selection when the Text Direction feature is enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.orientation?view=word-pia"/>
  public TextOrientation Orientation { get; set; }

  /// <summary>
  /// Returns a IInlineShapes collection that represents all the InlineShape objects in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.inlineshapes?view=word-pia"/>
  public DMD.IInlineShapes InlineShapes { get; }

  /// <summary>
  /// Returns a Document object associated with the specified selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.document?view=word-pia"/>
  public IDocument Document { get; }

  /// <summary>
  /// Returns a ShapeRange collection that represents all the Shape objects in the specified range or selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.shaperange?view=word-pia"/>
  public DMD.IShapeRange ShapeRange { get; }

  /// <summary>
  /// Determines if the spelling and grammar checker ignores the specified text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.noproofing?view=word-pia"/>
  public int NoProofing { get; set; }

  /// <summary>
  /// Returns a Tables collection that represents the tables at the outermost nesting level in the current
  /// selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.topleveltables?view=word-pia"/>
  public ITables TopLevelTables { get; }

  /// <summary>
  /// Returns or sets a value that specifies whether Microsoft Word has detected the language of the specified text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.languagedetected?view=word-pia"/>
  public bool LanguageDetected { get; set; }

  /// <summary>
  /// Returns or sets the width (in the current measurement units) in which Microsoft Word fits the text in the
  /// current selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.fittextwidth?view=word-pia"/>
  public float FitTextWidth { get; set; }

  /// <summary>
  /// Returns a HTMLDivisions object that represents an HTML division in a Web document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.htmldivisions?view=word-pia"/>
  public IHTMLDivisions HTMLDivisions { get; }

  /// <summary>
  /// Returns a SmartTags object that represents a smart tag in a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.smarttags?view=word-pia"/>
  public ISmartTags SmartTags { get; }

  /// <summary>
  /// Returns a ShapeRange object representing the child shapes of a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.childshaperange?view=word-pia"/>
  public DMD.IShapeRange ChildShapeRange { get; }

  /// <summary>
  /// Determines if the selection contains child shapes.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.haschildshaperange?view=word-pia"/>
  public bool HasChildShapeRange { get; }

  /// <summary>
  /// Returns a FootnoteOptions object that represents the footnote properties in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.footnoteoptions?view=word-pia"/>
  public IFootnoteOptions FootnoteOptions { get; }

  /// <summary>
  /// Returns a EndnoteOptions object that represents the endnotes in a selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.endnoteoptions?view=word-pia"/>
  public IEndnoteOptions EndnoteOptions { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xmlnodes?view=word-pia"/>
  public IXMLNodes XMLNodes { get; }

  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xmlparentnode?view=word-pia"/>
  public IXMLNode XMLParentNode { get; }

  /// <summary>
  /// Returns a Editors object that represents all the users authorized to modify a selection within a document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.editors?view=word-pia"/>
  public IEditors Editors { get; }

  /// <summary>
  /// Returns an Object that represents a picture representation of how a selection of text appears.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.enhmetafilebits?view=word-pia"/>
  public object EnhMetaFileBits { get; }

  /// <summary>
  /// Returns an OMaths collection that represents the OMath objects within the current selection. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.omaths?view=word-pia"/>
  public IOMaths OMaths { get; }

  /// <summary>
  /// Returns a String that represents the XML contained within the selection in the Microsoft Office Word Open XML
  /// format. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.wordopenxml?view=word-pia"/>
  public string WordOpenXML { get; }

  /// <summary>
  /// Returns a ContentControls collection that represents the content controls contained within a range. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.contentcontrols?view=word-pia"/>
  public IContentControls ContentControls { get; }

  /// <summary>
  /// Returns a ContentControl object that represents the parent content control for the specified range. Read-only.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.parentcontentcontrol?view=word-pia"/>
  public IContentControl ParentContentControl { get; }
}
