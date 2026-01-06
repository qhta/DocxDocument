using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing.DrawingShape;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Main Document interface representing a Word document.
/// </summary>
/// <remarks>
///   This interface provides access to document-level properties, settings, and content.
///   It corresponds to the Microsoft.Office.Interop.Word._Document interface.
/// </remarks>
public interface Document
{
  #region CoreProperties

  /// <summary>
  /// Title of the document.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  /// First author of the document.
  /// </summary>
  public string? Author { get; set; }

  /// <summary>
  ///   Comma-delimited set of keywords to support searching and indexing. 
  /// </summary>
  public string? Keywords { get; set; }

  /// <summary>
  ///   Short description of the document.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   The user who performed the last modification.
  /// </summary>
  public string? LastModifiedBy { get; set; }

  /// <summary>
  ///   The revision number.
  /// </summary>
  public int? Revision { get; set; }

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted { get; set; }

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created { get; set; }

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified { get; set; }

  /// <summary>
  ///   A categorization of the content of the document. 
  /// </summary>
  public string? Category { get; set; }

  /// <summary>
  ///   An unambiguous reference to the document within a given context.
  /// </summary>
  public string? Identifier { get; set; }

  /// <summary>
  ///   The type of content document.
  /// </summary>
  public string? ContentType { get; set; }

  /// <summary>
  ///   Main language of the document.
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version { get; set; }

  /// <summary>
  ///   The status of the content.
  /// </summary>
  public string? ContentStatus { get; set; }

  /// <summary>
  ///   Subject of the document.
  /// </summary>
  public string? Subject { get; set; }

  /// <summary>
  ///   Company name associated with the document.
  /// </summary>
  public string? Company { get; set; }

  /// <summary>
  ///   Manager name associated with the document.
  /// </summary>
  public string? Manager { get; set; }

  #endregion

  #region Document Properties and Collections

  /// <summary>
  /// Compound object of document properties
  /// </summary>
  public AllDocumentProperties? Properties { get; set; }

  /// <summary>
  /// Style definitions.
  /// </summary>
  public Styles? Styles { get; set; }

  /// <summary>
  /// Set of color and font themes.
  /// </summary>
  public DMD.Theme? Theme { get; set; }

  /// <summary>
  /// Font table
  /// </summary>
  public Fonts? Fonts { get; set; }

  /// <summary>
  /// Collection of embedded fonts data.
  /// </summary>
  public EmbedFontData? EmbeddedFonts { get; set; }

  /// <summary>
  /// Numbering definitions.
  /// </summary>
  public Numbering? Numbering { get; set; }

  /// <summary>
  /// Comment annotations.
  /// </summary>
  public DocComments? Comments { get; set; }

  /// <summary>
  /// Document background.
  /// </summary>
  public DocumentBackground? Background { get; set; }

  /// <summary>
  ///   Document conformance level.
  /// </summary>
  public DocumentConformance? Conformance { get; set; }

  /// <summary>
  ///   Document Background (duplicate - consider removing).
  /// </summary>
  [Obsolete("Use Background property instead")]
  public DocumentBackground? DocumentBackground { get; set; }

  /// <summary>
  ///   Main document body content.
  /// </summary>
  public Body? Body { get; set; }

  /// <summary>
  ///   Collection of sections in the document.
  /// </summary>
  public Sections? Sections { get; set; }

  /// <summary>
  ///   Collection of paragraphs in the document.
  /// </summary>
  public Paragraphs? Paragraphs { get; set; }

  /// <summary>
  ///   Collection of tables in the document.
  /// </summary>
  public Tables? Tables { get; set; }

  /// <summary>
  ///   Collection of bookmarks in the document.
  /// </summary>
  public Bookmarks? Bookmarks { get; set; }

  /// <summary>
  ///   Collection of variables stored in the document.
  /// </summary>
  public Variables? Variables { get; set; }

  /// <summary>
  ///   Collection of fields in the document.
  /// </summary>
  public Fields? Fields { get; set; }

  /// <summary>
  ///   Collection of shapes in the document.
  /// </summary>
  public Shapes? Shapes { get; set; }

  /// <summary>
  ///   Collection of inline shapes in the document.
  /// </summary>
  public InlineShapes? InlineShapes { get; set; }

  /// <summary>
  ///   Collection of footnotes in the document.
  /// </summary>
  public Footnotes? Footnotes { get; set; }

  /// <summary>
  ///   Collection of endnotes in the document.
  /// </summary>
  public Endnotes? Endnotes { get; set; }

  /// <summary>
  ///   Collection of hyperlinks in the document.
  /// </summary>
  public Hyperlinks? Hyperlinks { get; set; }

  /// <summary>
  ///   Collection of content controls in the document.
  /// </summary>
  public ContentControls? ContentControls { get; set; }

  #endregion

  #region Document Settings

  /// <summary>
  ///   Full path and filename of the document.
  /// </summary>
  public string? FullName { get; set; }

  /// <summary>
  ///   Document name without path.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   Path where the document is saved.
  /// </summary>
  public string? Path { get; set; }

  /// <summary>
  ///   Indicates whether the document has been saved.
  /// </summary>
  public bool Saved { get; set; }

  /// <summary>
  ///   Indicates whether the document is read-only.
  /// </summary>
  public bool ReadOnly { get; set; }

  /// <summary>
  ///   Password required to open the document.
  /// </summary>
  public string? Password { get; set; }

  /// <summary>
  ///   Password required to modify the document.
  /// </summary>
  public string? WritePassword { get; set; }

  /// <summary>
  ///   Indicates whether changes are tracked in the document.
  /// </summary>
  public bool TrackRevisions { get; set; }

  /// <summary>
  ///   Indicates whether the document contains tracked changes.
  /// </summary>
  public bool HasRevisions { get; set; }

  /// <summary>
  ///   Protection type applied to the document.
  /// </summary>
  public DocumentProtectionKind? ProtectionType { get; set; }

  /// <summary>
  ///   Default tab stop spacing.
  /// </summary>
  public int? DefaultTabStop { get; set; }

  /// <summary>
  ///   Indicates whether to show grammatical errors.
  /// </summary>
  public bool ShowGrammaticalErrors { get; set; }

  /// <summary>
  ///   Indicates whether to show spelling errors.
  /// </summary>
  public bool ShowSpellingErrors { get; set; }

  /// <summary>
  ///   Indicates whether to automatically hyphenate the document.
  /// </summary>
  public bool AutoHyphenation { get; set; }

  /// <summary>
  ///   Indicates whether to use consecutive hyphens.
  /// </summary>
  public bool ConsecutiveHyphensLimit { get; set; }

  /// <summary>
  ///   Hyphenation zone width in points.
  /// </summary>
  public int? HyphenationZone { get; set; }

  /// <summary>
  ///   Indicates whether to hyphenate words in all caps.
  /// </summary>
  public bool HyphenateCaps { get; set; }

  /// <summary>
  ///   View type for the document (Print, Web, Outline, etc.).
  /// </summary>
  public DocumentViewKind? ViewKind { get; set; }

  /// <summary>
  ///   Zoom percentage for the document view.
  /// </summary>
  public int? ZoomPercentage { get; set; }

  /// <summary>
  ///   Page setup settings for the document.
  /// </summary>
  public PageSetup? PageSetup { get; set; }

  /// <summary>
  ///   Document compatibility settings.
  /// </summary>
  public CompatibilitySettings? CompatibilitySettings { get; set; }

  /// <summary>
  ///   Document settings.
  /// </summary>
  public DocumentSettings? Settings { get; set; }

  /// <summary>
  ///   Web options for the document.
  /// </summary>
  public WebOptions? WebOptions { get; set; }

  /// <summary>
  ///   Mail merge settings.
  /// </summary>
  public MailMerge? MailMerge { get; set; }

  /// <summary>
  ///   Grammar checking settings.
  /// </summary>
  public GrammarSettings? GrammarSettings { get; set; }

  #endregion

  #region Range and Selection

  /// <summary>
  ///   Returns a range object representing the main document story.
  /// </summary>
  public Range? Range { get; set; }

  /// <summary>
  ///   Returns a range object representing the content of the document.
  /// </summary>
  public Range? Content { get; set; }

  /// <summary>
  ///   Returns the number of characters in the document.
  /// </summary>
  public int? Characters { get; set; }

  /// <summary>
  ///   Returns the number of words in the document.
  /// </summary>
  public int? Words { get; set; }

  /// <summary>
  ///   Returns the number of sentences in the document.
  /// </summary>
  public int? Sentences { get; set; }

  #endregion

  #region Headers and Footers

  /// <summary>
  ///   Indicates whether headers and footers are different for the first page.
  /// </summary>
  public bool DifferentFirstPageHeaderFooter { get; set; }

  /// <summary>
  ///   Indicates whether headers and footers are different for odd and even pages.
  /// </summary>
  public bool OddAndEvenPagesHeaderFooter { get; set; }

  #endregion

  #region Document Type and Format

  /// <summary>
  ///   Type of the document (normal document, template, etc.).
  /// </summary>
  public DocumentTypeKind? DocumentType { get; set; }

  /// <summary>
  ///   Attached template for the document.
  /// </summary>
  public string? AttachedTemplate { get; set; }

  /// <summary>
  ///   Indicates whether to automatically update styles from the template.
  /// </summary>
  public bool AutoUpdateStyles { get; set; }

  /// <summary>
  ///   Default target frame for hyperlinks.
  /// </summary>
  public string? DefaultTargetFrame { get; set; }

  /// <summary>
  ///   Encoding used for the document.
  /// </summary>
  public int? Encoding { get; set; }

  /// <summary>
  ///   Character set used for the document.
  /// </summary>
  public int? CharacterSet { get; set; }

  #endregion

  #region Collaboration and Versioning

  /// <summary>
  ///   Collection of versions saved for the document.
  /// </summary>
  public Versions? Versions { get; set; }

  /// <summary>
  ///   Indicates whether to save version history.
  /// </summary>
  public bool SaveVersionHistory { get; set; }

  /// <summary>
  ///   Collection of revisions (tracked changes) in the document.
  /// </summary>
  public Revisions? Revisions { get; set; }

  #endregion

  #region Custom XML

  /// <summary>
  ///   Collection of custom XML parts in the document.
  /// </summary>
  public DMPack.CustomXMLParts? CustomXMLParts { get; set; }

  /// <summary>
  ///   Collection of XML schemas attached to the document.
  /// </summary>
  public DMCX.XMLSchemas? XMLSchemas { get; set; }

  #endregion

  #region Bibliography and Citations

  /// <summary>
  ///   Bibliography sources used in the document.
  /// </summary>
  public Bibliography? Bibliography { get; set; }

  #endregion

  #region Document Actions (Methods)

  /// <summary>
  ///   Saves the document.
  /// </summary>
  void Save();

  /// <summary>
  ///   Saves the document with a new name or format.
  /// </summary>
  /// <param name="fileName">The name for the document.</param>
  /// <param name="fileFormat">The format in which to save the document.</param>
  void SaveAs(string fileName, FileFormatKind? fileFormat = null);

  /// <summary>
  ///   Closes the document.
  /// </summary>
  /// <param name="saveChanges">Whether to save changes before closing.</param>
  void Close(bool? saveChanges = null);

  /// <summary>
  ///   Prints the document.
  /// </summary>
  /// <param name="background">Whether to print in the background.</param>
  /// <param name="append">Whether to append to an existing print job.</param>
  /// <param name="range">The page range to print.</param>
  /// <param name="outputFileName">File name for print-to-file.</param>
  /// <param name="copies">Number of copies to print.</param>
  void PrintOut(bool? background = null, bool? append = null, PrintRangeKind? range = null, 
                string? outputFileName = null, int? copies = null);

  /// <summary>
  ///   Prints preview of the document.
  /// </summary>
  void PrintPreview();

  /// <summary>
  ///   Activates the document window.
  /// </summary>
  void Activate();

  /// <summary>
  ///   Protects the document with specified protection type.
  /// </summary>
  /// <param name="type">Type of protection to apply.</param>
  /// <param name="password">Optional password for protection.</param>
  void Protect(DocumentProtectionKind type, string? password = null);

  /// <summary>
  ///   Removes protection from the document.
  /// </summary>
  /// <param name="password">Password if document is password-protected.</param>
  void Unprotect(string? password = null);

  /// <summary>
  ///   Checks spelling and grammar in the document.
  /// </summary>
  void CheckSpelling();

  /// <summary>
  ///   Checks grammar in the document.
  /// </summary>
  void CheckGrammar();

  /// <summary>
  ///   Updates all fields in the document.
  /// </summary>
  void UpdateFields();

  /// <summary>
  ///   Updates the table of contents.
  /// </summary>
  void UpdateTableOfContents();

  /// <summary>
  ///   Accepts all tracked changes in the document.
  /// </summary>
  void AcceptAllRevisions();

  /// <summary>
  ///   Rejects all tracked changes in the document.
  /// </summary>
  void RejectAllRevisions();

  /// <summary>
  ///   Repaginates the document.
  /// </summary>
  void Repaginate();

  /// <summary>
  ///   Fits the document to one page.
  /// </summary>
  void FitToPages();

  /// <summary>
  ///   Merges changes from another document.
  /// </summary>
  /// <param name="fileName">Path to the document to merge.</param>
  void Merge(string fileName);

  /// <summary>
  ///   Compares this document with another document.
  /// </summary>
  /// <param name="fileName">Path to the document to compare.</param>
  /// <returns>New document showing the differences.</returns>
  Document? Compare(string fileName);

  /// <summary>
  ///   Converts the document to a different format.
  /// </summary>
  /// <param name="format">Target format.</param>
  void ConvertTo(FileFormatKind format);

  /// <summary>
  ///   Sends the document via email.
  /// </summary>
  void SendMail();

  /// <summary>
  ///   Routes the document to multiple recipients.
  /// </summary>
  void Route();

  #endregion
}

#region Enumerations

/// <summary>
/// Document protection types.
/// </summary>
public enum DocumentProtectionKind
{
  /// <summary>No protection</summary>
  NoProtection,
  /// <summary>Allow only revisions</summary>
  AllowOnlyRevisions,
  /// <summary>Allow only comments</summary>
  AllowOnlyComments,
  /// <summary>Allow only form fields</summary>
  AllowOnlyFormFields,
  /// <summary>Read only</summary>
  ReadOnly
}

/// <summary>
/// Document view types.
/// </summary>
public enum DocumentViewKind
{
  /// <summary>Normal view</summary>
  Normal,
  /// <summary>Outline view</summary>
  Outline,
  /// <summary>Print layout view</summary>
  PrintLayout,
  /// <summary>Web layout view</summary>
  WebLayout,
  /// <summary>Reading layout view</summary>
  ReadingLayout,
  /// <summary>Master document view</summary>
  MasterDocument
}

/// <summary>
/// Document types.
/// </summary>
public enum DocumentTypeKind
{
  /// <summary>Normal document</summary>
  Document,
  /// <summary>Template</summary>
  Template,
  /// <summary>Email message</summary>
  Email
}

/// <summary>
/// File format types.
/// </summary>
public enum FileFormatKind
{
  /// <summary>Word document (.docx)</summary>
  OpenXMLDocument,
  /// <summary>Word 97-2003 document (.doc)</summary>
  Word97,
  /// <summary>Word template (.dotx)</summary>
  OpenXMLTemplate,
  /// <summary>Word 97-2003 template (.dot)</summary>
  Template97,
  /// <summary>PDF format</summary>
  PDF,
  /// <summary>XPS format</summary>
  XPS,
  /// <summary>HTML format</summary>
  HTML,
  /// <summary>Plain text (.txt)</summary>
  Text,
  /// <summary>Rich Text Format (.rtf)</summary>
  RTF,
  /// <summary>XML format</summary>
  XML
}

/// <summary>
/// Print range types.
/// </summary>
public enum PrintRangeKind
{
  /// <summary>Print all pages</summary>
  AllPages,
  /// <summary>Print current page</summary>
  CurrentPage,
  /// <summary>Print selection</summary>
  Selection,
  /// <summary>Print specific pages</summary>
  Pages
}

#endregion