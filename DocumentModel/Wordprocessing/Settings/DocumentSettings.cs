using DocumentModel.CustomXml;
using DocumentModel.Math;
using DocumentModel.Wordprocessing;

namespace DocumentModel;

/// <summary>
///   These settings specify all document-level properties which affect the handling of the current document. 
/// </summary>
public class DocumentSettings : DocumentProperties
{
  /// <summary>
  /// This element specifies information about the parameters of the grammar checking 
  /// which was performed on the contents of the current WordprocessingML document. 
  /// </summary>
  [Category("Proofing")]
  public Collection<ActiveWritingStyle>? ActiveWritingStyles { get; set; }

  /// <summary>
  /// This element specifies that paragraph borders specified using the pBdr element (§17.3.1.24) 
  /// and table borders using the tblBorders element (§17.4.39) shall be adjusted to align with extents of the page border 
  /// defined using the pgBorders element (§17.6.10) if the spacing between these borders is less than or equal to 10.5 points 
  /// (one character width) or less from the page border. The presence of this setting shall ensure 
  /// there are no gaps of one character width or less between adjoining page and paragraph/table borders, 
  /// as borders which are perfectly aligning shall not be displayed in favor of the intervening page border. 
  /// </summary>
  [Category("Page borders")]
  public bool? AlignBorderAndEdges { get; set; }

  /// <summary>
  /// This element specifies whether custom XML markup specified via the customXml element 
  /// which has no associated namespace shall be treated as an error and moved into a special error namespace 
  /// (for the purposes of XML schema validation) when the document is opened. 
  /// If this element is turned on, when an application determines that the current XML markup is in the empty namespace, 
  /// those elements shall not automatically be moved into an error namespace. 
  /// </summary>
  [Category("CustomXml")]
  public bool? AlwaysMergeEmptyNamespace { get; set; }

  /// <summary>
  /// This element specifies that each custom XML element specified using the customXml element 
  /// within this document shall always show some form of in-document placeholder text presentation when it contains no run content. 
  /// If the placeholder element (§17.5.2.25) is present in the custom XML element's properties, 
  /// then this is the placeholder text displayed and this effect has no effect. 
  /// If the placeholder element is omitted, then the application shall use the name of the element 
  /// to generate default placeholder text in its place. 
  /// </summary>
  [Category("CustomXml")]
  public bool? AlwaysShowPlaceholderText { get; set; }

  /// <summary>
  /// This element specifies that the custom XML schema whose target namespace matches the value specified in the val attribute 
  /// should be associated with this document when it is loaded, if such a schema is available to the hosting application. 
  /// Applications can also load and utilize any additional schemas as well as those explicitly mentioned here. 
  /// These customXML schemas can then be used to validate the structure of the custom XML markup in the document, etc.
  /// </summary>
  [Category("CustomXml")]
  public AttachedSchemas? AttachedSchemas { get; set; }

  /// <summary>
  /// This element specifies the location of a document template which shall be attached to the current WordprocessingML document 
  /// if it is accessible and of a format supported by an application. 
  /// Specifically, this element's val attribute shall contain the file path of the associated document template.  
  /// </summary>
  [Category("Template")]
  public AttachedTemplate? AttachedTemplate { get; set; }

  /// <summary>
  /// This element specifies whether formatting automatically applied by an application 
  /// (i.e. not explicitly applied by a use or an application) shall be allowed to override formatting protection 
  /// enabled via the formatting attribute on the documentProtection element (§17.15.1.9) 
  /// when those formatting operations would add formatting which has been explicitly disabled. 
  /// Example: Automatically adding superscript to the st in the string 1st.
  /// </summary>
  [Category("Protection")]
  public bool? AutoFormatOverride { get; set; }

  /// <summary>
  /// This element specifies whether the content of a given WordprocessingML document should automatically be hyphenated 
  /// by the hosting application before it is displayed, if the application supports this functionality.
  /// </summary>
  [Category("Hyphenation")]
  public bool? AutoHyphenation { get; set; }

  /// <summary>
  /// This element specifies if the contents of a given WordprocessingML document should be printed as signatures. 
  /// Signatures are printed sheets, which depict several pages of a document that are folded 
  /// and bound with other signatures to form a booklet, a set of which can be bound together to form a book like publication. 
  /// Specifically, this element specifies that each page in a given WordprocessingML document should be oriented in a landscape fashion, 
  /// divided in half vertically with two left margins emanating from the bisector of the page, 
  /// and two right margins instantiated at the left and right side of each page.
  /// </summary>
  [Category("Printing")]
  public bool? BookFoldPrinting { get; set; }

  /// <summary>
  /// This element shall be used in conjunction with the bookFoldPrinting (§17.15.1.11) and bookFoldRevPrinting (§17.15.1.13) 
  /// elements to specify the number of pages to be included in each booklet when printing a series of signatures. 
  /// Signatures are printed sheets, which depict several pages of a document that are to be folded 
  /// and bound with other signatures to form a booklet.
  /// Booklets can be bound together to form a book like publication.
  /// </summary>
  [Category("Printing")]
  public short? BookFoldPrintingSheets { get; set; }

  /// <summary>
  /// This element specifies if pages of a given WordprocessingML document are to be printed as signatures in reverse order. 
  /// Signatures are printed sheets, which depict several pages of a document that are folded 
  /// and bound with other signatures to form a booklet, 
  /// a set of which can be bound together to form a book like publication. 
  /// Specifically, this element specifies that each page in a given WordprocessingML document 
  /// should be oriented in a landscape fashion and divided in half vertically, 
  /// with two left margins emanating from the bisector of the page, 
  /// and right margins instantiated at the left and right side of each page.
  /// </summary>
  [Category("Printing")]
  public bool? BookFoldReversePrinting { get; set; }

  /// <summary>
  /// This element specifies that a given WordprocessingML document’s page border 
  /// specified using the pgBorders element (§17.6.10) should not surround contents of the footer.
  /// </summary>
  [Category("Page borders")]
  public bool? BordersDoNotSurroundFooter { get; set; }

  /// <summary>
  /// This element specifies that a given WordprocessingML document’s page border 
  /// specified using the pgBorders element (§17.6.10) should not surround contents of the header.
  /// </summary>
  [Category("Page borders")]
  public bool? BordersDoNotSurroundHeader { get; set; }

  /// <summary>
  /// This element specifies the presence of information about captions in a given WordprocessingML document.
  /// </summary>
  public Captions? Captions { get; set; }

  /// <summary>
  /// This element specifies how full-width characters in the current WordprocessingML document 
  /// should be compressed to remove additional whitespace when the contents of this document are displayed, 
  /// specifically by specifying the set(s) of characters which can be compressed to remove additional whitespace. 
  /// The behavior of this element is functionally identical to the CSS text-justify-trim property.
  /// </summary>
  public CharacterSpacingKind? CharacterSpacingControl { get; set; }

  /// <summary>
  /// This elementspecifies how the datapoint properties ([MS-ODRAWXML] section 2.8.3.1) and datalabels ([MS-ODRAWXML] section 2.2.1.2) 
  /// in all charts ([ISO/IEC29500-1:2016] section 21.2) in this document behave.
  /// </summary>
  [Category("Tracking")]
  public bool? ChartTrackingRefBased { get; set; }

  /// <summary>
  /// This element specifies the paragraph style, specified using the style element, 
  /// which shall be applied to paragraphs which are automatically created 
  /// when text is inserted into a WordprocessingML document 
  /// in an area of the document that has no other style associated with it. 
  /// This style is referenced via the val attribute, which stores the style ID 
  /// of the style (stored in the styleId attribute on the style definition). 
  /// </summary>
  public string? ClickAndTypeStyle { get; set; }

  /// <summary>
  /// This element specifies the theme color, stored in the document's Theme part 
  /// to which the value of this theme color shall be mapped. 
  /// This mapping enables multiple theme colors to be chained together.
  /// </summary>
  public ColorSchemeMapping? ColorSchemeMapping { get; set; }

  /// <summary>
  /// This element specifies a set of optional compatibility options for the current document.
  /// </summary>
  public Compatibility? Compatibility { get; set; }

  /// <summary>
  /// Specifies that the user was resolving conflicting edits when the document was saved. 
  /// </summary>
  public bool? ConflictMode { get; set; }

  /// <summary>
  /// This element specifies the maximum number of consecutive lines of text 
  /// that can end with a hyphen when the contents of this document are displayed. 
  /// Once this limit has been reached, the following line shall not be hyphenated 
  /// regardless of whether or not it meets the criteria needed for hyphenation.
  /// </summary>
  [Category("Hyphenation")]
  public ushort? ConsecutiveHyphenLimit { get; set; }

  /// <summary>
  /// This element specifies the character that shall be interpreted as the radix point 
  /// when evaluating the contents of all fields in the current document. 
  /// </summary>
  public string? DecimalSymbol { get; set; }

  /// <summary>
  /// This element that specifies the resolution in dots per inch (DPI) at which images in the document will be saved.
  /// This setting is ignored by images that have dots per inch (DPI) specified by useLocalDpi 
  /// (as specified in [MS-ODRAWXML] section 2.3.1.13). 
  /// This setting is also ignored when doNotAutoCompressPictures 
  /// (as specified in [ISO/IEC29500-1:2016] section 17.15.1.33) is set to "true".
  /// </summary>
  [Category("Images")]
  public int? DefaultImageDpi { get; set; }

  /// <summary>
  ///  This element specifies the table style which shall automatically be applied 
  ///  to the table properties of tables added to this document by an application. 
  ///  Note that it does not change the table style applied to tables which do not reference a style, 
  ///  instead, it automatically applies the style to that table via the tblStyle element (§17.4.62). 
  ///  This link is made by referencing the styleId attribute value of the table style 
  ///  which shall be used to format newly inserted tables.
  /// </summary>
  [Category("Styling")]
  public string? DefaultTableStyle { get; set; }

  /// <summary>
  /// This element specifies the value which shall be used as the multiplier 
  /// to generate automatic tab stops in this document. 
  /// Automatic tab stops refer to the tab stop locations 
  /// which occur after all custom tab stops in the current paragraph have been surpassed.
  /// </summary>
  public short? DefaultTabStop { get; set; }

  /// <summary>
  /// This element that specifies that when true, the cropped-out areas of the images are not to be saved. 
  /// Rather, the images saved are the results of applying imgProps (as specified in [MS-ODRAWXML] section 2.3.1.9) 
  /// on the original images. See section 2.2.2 for how this element integrates with ISO/IEC-29500-1.
  /// </summary>
  [Category("Images")]
  public bool? DiscardImageEditingData { get; set; }

  /// <summary>
  /// This element specifies whether the images and colors defined in the document's background 
  /// using the background element (§17.2.1) shall be displayed when the document 
  /// is displayed in print layout view (§17.18.102) as specified in the view element (§17.15.1.92).
  /// </summary>
  [Category("View")]
  public bool? DisplayBackgroundShape { get; set; }

  /// <summary>
  /// This element specifies the number of horizontal grid units defined using the drawingGridHorizontalSpacing element (§17.15.1.45) 
  /// which shall be allowed between subsequent visible horizontal drawing grid lines in this document, if gridlines are being shown.
  /// Note: The display of gridlines is an application-level setting not specified in ECMA-376. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document.
  /// </summary>
  [Category("Document grid")]
  public int? DisplayHorizontalDrawingGrid { get; set; }

  /// <summary>
  /// This element specifies the number of vertical grid units defined using the drawingGridVerticalSpacing element (§17.15.1.47) 
  /// which shall be allowed between subsequent vertical gridlines in this document, if gridlines are being shown. 
  /// Note: The display of gridlines is an application-level setting not specified in ECMA-376. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document. 
  /// If this element is omitted, then vertical gridlines shall not be displayed.
  /// </summary>
  [Category("Document grid")]
  public int? DisplayVerticalDrawingGrid { get; set; }

  /// <summary>
  /// A CT_LongHexNumber element that specifies an arbitrary identifier for the context of the paragraph identifiers 
  /// in the document. Values MUST be greater than 0 and less than 0x80000000. 
  /// </summary>
  [Category("Identification")]
  public HexInt? DocumentId { get; set; }

  /// <summary>
  /// This element specifies the set of document protection restrictions which have been applied to the contents 
  /// of a WordprocessingML document. These restrictions should be enforced by applications editing this document 
  /// when the enforcement attribute is turned on and ignored (but persisted) otherwise. 
  /// Document protection is a set of restrictions used to prevent unintentional changes 
  /// to all or part of a WordprocessingML document. 
  /// Note: This protection does not encrypt the document, and malicious applications might circumvent its use. 
  /// This protection is not intended as a security feature. 
  /// </summary>
  [Category("Protection")]
  public DocumentProtection? DocumentProtection { get; set; }

  /// <summary>
  /// This element specifies the classification of a given WordprocessingML document.  
  /// Note: This element can be used by hosting applications to facilitate customized user interface 
  /// and/or automatic formatting behaviors based on the 'type' of a given WordprocessingML document.
  /// </summary>
  public DocumentKind? DocumentType { get; set; }

  /// <summary>
  /// This element specifies the presence of document variables in a WordprocessingML. 
  /// A document variable is a storage location for arbitrary customer data in name/value pairs 
  /// that is persisted in a given WordprocessingML document
  /// </summary>
  public DocumentVariables? DocumentVariables { get; set; }

  /// <summary>
  /// This element specifies that pictures in this document shall not automatically be compressed 
  /// when saving the document in order to reduce the overall size of the resulting WordprocessingML document.
  /// </summary>
  [Category("Images")]
  public bool? DoNotAutoCompressPictures { get; set; }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around content contained in a WordprocessingML document 
  /// which is contained with custom XML markup specified via the customXml element when an application determines 
  /// that the current XML markup (or its contents) violate the constraints of the attached XML schema(s). 
  /// </summary>
  [Category("CustomXml")]
  public bool? DoNotDemarcateInvalidXml { get; set; }

  /// <summary>
  /// This element specifies whether applications displaying this document should display the contents of the header and footer 
  /// when displaying the document in print layout view (§17.18.102) or should collapse those areas 
  /// as well as the whitespace on all displayed pages so that the text extents are directly following one another.
  /// </summary>
  [Category("View")]
  public bool? DoNotDisplayPageBoundaries { get; set; }

  /// <summary>
  /// This element specifies whether or not words comprised of all capital letters shall be hyphenated 
  /// within a given document when automatic hyphenation is specified via the autoHyphenation element (§17.15.1.10).
  /// </summary>
  [Category("Hyphenation")]
  public bool? DoNotHyphenateCaps { get; set; }

  /// <summary>
  /// This element specifies if document content contained in text boxes, footnotes, and endnotes 
  /// shall be excluded when an application calculates a given document’s statistics 
  /// when these values are calculated and/or displayed by an application.
  /// </summary>
  public bool? DoNotIncludeSubdocsInStats { get; set; }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around form fields contained 
  /// in a WordprocessingML document specified via the FORMTEXT, FORMCHECKBOX, or FORMDROPDOWN fields.
  /// </summary>
  public bool? DoNotShadeFormData { get; set; }

  /// <summary>
  /// This element specifies that applications shall not track revisions made to the formatting 
  /// of this WordprocessingML document when the trackRevisions element (§17.15.1.89) is turned on.
  /// </summary>
  [Category("Tracking")]
  public bool? DoNotTrackFormatting { get; set; }

  /// <summary>
  /// This element specifies that applications shall not track revisions made to this WordprocessingML document
  /// as moves when the trackRevisions element (§17.15.1.89) is turned on, even when that syntax is appropriate. 
  /// Instead, applications should use a standard insertion and deletion annotation syntax. 
  /// Existing moves shall not be modified.
  /// </summary>
  [Category("Tracking")]
  public bool? DoNotTrackMoves { get; set; }

  /// <summary>
  /// This element specifies that the top-left corner of the page shall not be used as the origin for the drawing grid. 
  /// The drawing grid is a virtual grid which can be used by applications to specify 
  /// where drawing objects shall be positioned on a page when inserted (i.e. to ensure objects are aligned, etc.). 
  /// If this element is present the grid shall start at the top-left edge of the page and not the text extents.
  /// </summary>
  [Category("Document grid")]
  public bool? DoNotUseMarginsForDrawingGridOrigin { get; set; }

  /// <summary>
  /// This element specifies that applications shall not validate the custom XML markup in this document 
  /// against the applicable custom XML schema(s), even when those schemas are available. 
  /// The application should silently behave as if it was unable to provide this functionality. 
  /// </summary>
  [Category("CustomXml")]
  public bool? DoNotValidateAgainstSchema { get; set; }

  /// <summary>
  /// This element specifies the distance from of the left edge of the page which shall be used as the origin 
  /// for the horizontal gridlines used by the drawing grid. The drawing grid is a virtual grid 
  /// which might be used by applications to specify where drawing objects shall be positioned on a page when inserted 
  /// (i.e. to ensure objects are aligned, etc.). Since the grid always covers the entire page 
  /// when the doNotUseMarginsForDrawingGridOrigin element (§17.15.1.42) is specified, 
  /// this element shall only affect the starting edge of the first horizontal gridline displayed 
  /// (i.e. it only adjusts the grid by the modulus of the value against the width of one grid unit).
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridHorizontalOrigin { get; set; }

  /// <summary>
  /// This element specifies the width of horizontal grid units in this document. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document. 
  /// If this element is omitted, then each horizontal grid unit shall be 180 twentieths of a point (0.125") in width.
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridHorizontalSpacing { get; set; }

  /// <summary>
  /// This element specifies the distance from of the top edge of the page which shall be used as the origin 
  /// for the vertical gridlines used by the drawing grid. The drawing grid is a virtual grid 
  /// which can be used by applications to specify where drawing objects shall be positioned on a page when inserted 
  /// (i.e. to ensure objects are aligned, etc.). Since the grid always covers the entire page 
  /// when the doNotUseMarginsForDrawingGridOrigin element (§17.15.1.42) is specified, 
  /// this element shall only affect the starting edge of the first vertical gridline displayed 
  /// (i.e. it only adjusts the grid by the modulus of the value against the width of one grid unit).
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridVerticalOrigin { get; set; }

  /// <summary>
  /// This element specifies the width of vertical grid units in this document. 
  /// The drawing grid is a grid which can be used by applications to help position floating objects in the document.
  /// </summary>
  [Category("Document grid")]
  public Twips? DrawingGridVerticalSpacing { get; set; }

  /// <summary>
  /// This element specifies that applications shall embed common system fonts when they are in use 
  /// and font embedding is enabled for this document using the embedTrueTypeFonts element (§17.8.3.8). 
  /// </summary>
  [Category("Fonts")]
  public bool? EmbedSystemFonts { get; set; }

  /// <summary>
  /// This element specifies that applications shall embed the fonts in use in this document when it is saved. 
  /// These fonts shall be embedded subject to the algorithm specified in §17.8.1.
  /// </summary>
  [Category("Fonts")]
  public bool? EmbedTrueTypeFonts { get; set; }

  /// <summary>
  /// This element specifies the endnote properties for the current document. 
  /// Each of these properties are stored as a child element within the endnotePr element.
  /// These properties can be overridden for a specific section via the section-wide endnotePr element (§17.11.5).
  /// </summary>
  [Category("Footnotes and endnotes")]
  public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties { get; set; }

  /// <summary>
  /// This element specifies whether sections in this document shall have different headers and footers 
  /// for even and odd pages (an odd page header/footer and an even page header/footer).
  /// </summary>
  public bool? EvenAndOddHeaders { get; set; }

  /// <summary>
  /// This element specifies the footnote properties for this document. 
  /// Each property is stored as a unique element within the footnotePr element.
  /// These properties can be overridden for a specific section via the section-wide footnotePr element (§17.11.11).
  /// </summary>
  [Category("Footnotes and endnotes")]
  public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties { get; set; }

  /// <summary>
  /// This element specifies that the contents of this document can be upgraded 
  /// and that the resulting document shall not have its functionality limited 
  /// to only those functions compatible with earlier word processing applications.
  /// </summary>
  public bool? ForceUpgrade { get; set; }

  /// <summary>
  /// This element specifies that the document was last saved while the placeholder text 
  /// of all structured document tags in this document were being edited. 
  /// This means that the placeholder text currently displayed in all structured document tags 
  /// which are displaying the showingPlcHdr element (§17.5.2.39) shall be committed 
  /// to the corresponding glossary document entry as specified using the docPart element (§17.12.5) 
  /// when this document is opened, in order to ensure that the most recent placeholder text is stored in the glossary document entry. 
  /// If the current placeholder text cannot be saved as a glossary document entry, then it should be modified as needed before saving.
  /// </summary>
  [Category("Forms")]
  public bool? FormsDesign { get; set; }

  /// <summary>
  /// This element specifies that a given WordprocessingML document’s gutter shall be positioned 
  /// at the top of the document’s pages when the document is displayed. 
  /// A gutter is the white space formed by the inner margins of two pages facing one another; 
  /// such as the white space between the text on pages of a book when the book is opened.
  /// </summary>
  [Category("Printing")]
  public bool? GutterAtTop { get; set; }

  /// <summary>
  /// This element specifies the default parameters for object using the VML syntax (§14.1) 
  /// inserted in the header and footer of a WordprocessingML document. 
  /// </summary>
  [Category("VML")]
  [Obsolete]
  public HeaderShapeDefaults? HeaderShapeDefaults { get; set; }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around run content contained in a WordprocessingML document 
  /// which has been flagged as a possible grammatical error using the proofErr element (§17.13.8.1) or via the application's own grammar engine.
  /// </summary>
  [Category("Proofing")]
  public bool? HideGrammaticalErrors { get; set; }

  /// <summary>
  /// This element specifies whether a visual cue should be displayed around run content contained in a WordprocessingML document 
  /// which has been flagged as a possible spelling error using the proofErr element (§17.13.8.1) or via the application's own spelling engine.
  /// </summary>
  [Category("Proofing")]
  public bool? HideSpellingErrors { get; set; }

  /// <summary>
  /// This element specifies the hyphenation zone which shall be used when automatically or manually hyphenating the contents of this document. 
  /// The hyphenation zone is the amount of whitespace which can be left at the end of a line (or added to justified lines) 
  /// before hyphenation should be attempted on the next word in the document (in order to reduce the amount of whitespace on the line). 
  /// A smaller hyphenation zone should reduce the raggedness of the right edge of a given document's body text, as more words is hyphenated. 
  /// Conversely,  a larger hyphenation zone should increase the raggedness of the right edge of a given document's text, as fewer words is hyphenated.
  /// If this element is omitted, then a default hyphenation zone of 360 twentieths of a point (0.25") shall be applied when performing hyphenation on this document.
  /// </summary>
  [Category("Hyphenation")]
  public Twips? HyphenationZone { get; set; }

  /// <summary>
  /// This element specifies that applications should ignore all text content which is not contained within a leaf custom XML markup element 
  /// when validating the contents of the custom XML markup in this document against one or more attached custom XML schema(s). 
  /// A leaf element is a customXML element which has no child custom XML elements (it is a leaf in the custom XML tree).
  /// </summary>
  [Category("CustomXml")]
  public bool? IgnoreMixedContent { get; set; }

  /// <summary>
  /// This element specifies that styles in the given document shall be updated to match the styles in the attached template 
  /// specified using the attachedTemplate element (§17.15.1.6) when the document is opened by a hosting application. 
  /// This setting enables the styles contained in documents with attached templates to stay synchronized with the styles used in the attached template.
  /// </summary>
  [Category("Styling")]
  public bool? LinkStyles { get; set; }

  /// <summary>
  /// This element specifies the character that shall be interpreted as a list item separator 
  /// when evaluating the contents of all fields in the current document.
  /// </summary>
  public string? ListSeparator { get; set; }

  /// <summary>
  /// This element specifies all of the mail merge information for a document 
  /// that has been connected to an external data source as part of a mail merge operation.
  /// </summary>
  [Category("Mailing")]
  public MailMerge? MailMerge { get; set; }

  /// <summary>
  /// This element specifies the document-level properties for all math in the document.
  /// </summary>
  public MathProperties? MathProperties { get; set; }

  /// <summary>
  /// This element specifies that the left and right margins defined in the section properties shall be swapped on every second page. 
  /// </summary>
  public bool? MirrorMargins { get; set; }

  /// <summary>
  /// This element specifies the set of characters which shall be restricted 
  /// from ending a line for runs of text which shall be subject to custom line breaking logic 
  /// using the kinsoku element (§17.3.1.16) when the contents of the document are displayed. 
  /// This constraint shall only apply to text which has been flagged in the language of this rule 
  /// via the lang element (§17.3.2.20) or automatic detection methods outside the scope of /IEC 29500.
  /// </summary>
  [Category("Kinsoku")]
  public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku { get; set; }

  /// <summary>
  /// This element specifies the set of characters which shall be restricted 
  /// from beginning a new line for runs of text which shall be subject to custom line breaking logic
  /// using the kinsoku element (§17.3.1.16) when the contents of the document are displayed. 
  /// This constraint shall only apply to text which has been flagged in the language of this rule 
  /// via the lang element (§17.3.2.20) or automatic detection methods outside the scope of /IEC 29500.
  /// </summary>
  [Category("Kinsoku")]
  public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku { get; set; }

  /// <summary>
  /// This element specifies that punctuation characters shall not be kerned in the current document 
  /// when kerning is enabled on a run using the kern element (§17.3.2.19).
  /// </summary>
  public bool? NoPunctuationKerning { get; set; }

  /// <summary>
  /// The docId global element is a CT_Guid (as specified in [ISO/IEC-29500-1] section A.1) element 
  /// that specifies a unique identifier for a set of documents derived from a common source. 
  /// The possible values for this attribute are defined by the ST_Guid simple type.
  /// </summary>
  [Category("Identification")]
  public Guid? PersistentDocumentId { get; set; }

  /// <summary>
  /// This element specifies that printing the contents of this document shall only print the contents 
  /// of WordprocessingML form fields defined using the FORMTEXT, FORMCHECKBOX, and FORMDROPDOWN field codes
  /// in their current locations on the page - all other document contents shall be suppressed.
  /// </summary>
  [Category("Printing")]
  public bool? PrintFormsData { get; set; }

  /// <summary>
  /// This element specifies the contents of this document shall be printed with fractional character widths. 
  /// Fractional character widths exist when the spacing between characters is not constant 
  /// (i.e. a proportional font face is used). 
  /// </summary>
  [Category("Printing")]
  public bool? PrintFractionalCharacterWidth { get; set; }

  /// <summary>
  /// This element specifies that the PostScript codes specified in WordprocessingML documents containing PRINT fields 
  /// shall be included in foreground (on the same Z-order as text) with the data printed in the contents of a given WordprocessingML document.
  /// </summary>
  [Category("Printing")]
  public bool? PrintPostScriptOverText { get; set; }

  /// <summary>
  /// This element specifies whether two pages should be printed on one sheet of paper when this document is printed. 
  /// Specifically, this element specifies that each page displayed for the contents in a given WordprocessingML document 
  /// should be the page size specified in the section settings divided in half with two top margins originating from the bisector of the page, 
  /// and bottom margins instantiated at the top and bottom of each page.
  /// </summary>
  [Category("Printing")]
  public bool? PrintTwoOnOne { get; set; }

  /// <summary>
  /// This element specifies if the grammar and spell-checking engines of the last application 
  /// to process this document completed checking the grammar and spelling of the document before the document was last saved. 
  /// Applications which modify the document contents without checking spelling or grammar should reset these states as needed.
  /// </summary>
  [Category("Proofing")]
  public ProofState? ProofState { get; set; }

  /// <summary>
  /// This element specifies the exact set of page and text sizing parameters which shall be used to display 
  /// the contents of a WordprocessingML document. 
  /// Rationale: This setting is typically used for documents that have been annotated using ink. 
  /// This setting freezes the document's presentation such that the ink annotations must exist at the same position 
  /// of the WordprocessingML document irrespective of the monitor on which the WordprocessingML document is rendered.
  /// </summary>
  public ReadModeInkLockDown? ReadModeInkLockDown { get; set; }

  /// <summary>
  /// This element specifies that the date and time information shall be removed from all annotations which are present 
  /// in the current document when it is saved. Annotations store this information in the date attribute on the annotation's XML element.
  /// </summary>
  [Category("Protection")]
  public bool? RemoveDateAndTime { get; set; }

  /// <summary>
  /// This element specifies that hosting applications shall remove all personal information of document authors 
  /// upon saving a given WordprocessingML document. The definition and extent of personal information is not defined by ECMA-376.
  /// </summary>
  [Category("Protection")]
  public bool? RemovePersonalInformation { get; set; }

  /// <summary>
  /// This element specifies which forms of annotations shall be visible for a WordprocessingML document when it is displayed. 
  /// This setting shall not affect whether annotations are added or persisted, it shall only affect the display of the annotations 
  /// which exist in the document's contents (persisted or in memory).
  /// </summary>
  [Category("View")]
  public RevisionView? RevisionView { get; set; }

  /// <summary>
  /// This element specifies the set of revision save ID values for the current document. 
  /// Revision save ID values refer to four-digit hexadecimal values which uniquely identify 
  /// an editing session in the life of the current document. 
  /// An editing session is the period of time between two subsequent save operations by an application.
  /// </summary>
  [Category("Tracking")]
  public Rsids? Rsids { get; set; }

  /// <summary>
  /// This element specifies that saving the contents of this document shall only save the contents of WordprocessingML form fields 
  /// defined using the FORMTEXT, FORMCHECKBOX, and FORMDROPDOWN field codes in a comma-delimited text format which does not conform to ECMA-376 
  /// (i.e. it is a one-way export from a WordprocessingML document).
  /// </summary>
  [Category("Forms")]
  public bool? SaveFormsData { get; set; }

  /// <summary>
  /// This element specifies that this document should be capable of being saved into a format consisting of a single XML file 
  /// (not defined by ECMA-376) even when its contents are invalid based XML schema validation of the custom XML markup contained in the document. 
  /// This setting has no effect on documents that do not contain custom XML markup, or that do contain custom XML markup but do not have a schema attached.
  /// </summary>
  [Category("CustomXml")]
  public bool? SaveInvalidXml { get; set; }

  /// <summary>
  /// This element specifies if a document's Thumbnail part should be generated for the contents of the first page of this document 
  /// when saved by application which support document thumbnail generation.
  /// </summary>
  public bool? SavePreviewPicture { get; set; }

  /// <summary>
  /// This element specifies that applications shall subset fonts when font embedding is enabled
  /// for this document using the embedTrueTypeFonts element (§17.8.3.8). 
  /// Subsetting is a mechanism by which only the glyphs used in the contents of this WordprocessingML document
  /// are stored in an embedded font, in order to prevent the file from becoming unnecessarily large 
  /// from the use of a small number of glyphs from a large embedded font.
  /// </summary>
  [Category("Fonts")]
  public bool? SaveSubsetFonts { get; set; }

  /// <summary>
  /// This element specifies the location of a custom XSL transform that shall be used when this document is saved as a single XML file 
  /// (in an application-defined format).
  /// </summary>
  [Category("Xslt")]
  public SaveThroughXslt? SaveThroughXslt { get; set; }

  /// <summary>
  /// This element specifies that the contents of this document shall be saved as an XML file containing only the custom XML markup 
  /// in this document in its regular form. The resulting document does not conform to ECMA376 
  /// (i.e. this is an export-only save option for a WordprocessingML document).
  /// </summary>
  [Category("CustomXml")]
  public bool? SaveXmlDataOnly { get; set; }

  /// <summary>
  /// This element specifies the set of XML namespaces which have been associated with the contents of the custom XML markup 
  /// within the current Office Open XML document. Each unique namespace which is referenced within the document 
  /// can be referenced within this element by a single schema element, regardless of the number of constituent XML schemas 
  /// which comprise that namespace.
  /// </summary>
  [Category("CustomXml")]
  public SchemaLibrary? SchemaLibrary { get; set; }

  /// <summary>
  /// This element specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
  /// </summary>
  [Category("VML")]
  [Obsolete]
  public ShapeDefaults? ShapeDefaults { get; set; }

  /// <summary>
  /// This element specifies that an e-mail message header shall be displayed when this document is opened, 
  /// if an email header is supported by the application opening the file.
  /// </summary>
  [Category("Mailing")]
  public bool? ShowEnvelope { get; set; }

  /// <summary>
  /// This element specifies that some visual indicator shall be provided for the start and end locations 
  /// of custom XML markup present in this document, if any.
  /// </summary>
  [Category("CustomXml")]
  public bool? ShowXmlTags { get; set; }

  /// <summary>
  /// This element specifies that the strict set of Kinsoku rules shall be applied to Japanese text in this document 
  /// when the kinsoku element (§17.3.1.16) is applied to that text. The resulting line breaking rules are provided on the kinsoku element.
  /// </summary>
  [Category("Kinsoku")]
  public bool? StrictFirstAndLastChars { get; set; }

  /// <summary>
  /// This element specifies a set of suggested filters which should be applied to the list of document styles 
  /// in this application if the styles are displayed in a user interface. 
  /// </summary>
  [Category("Styling")]
  public StylePaneFormatFilter? StylePaneFormatFilter { get; set; }

  /// <summary>
  /// This element specifies a sorting which should be applied to the list of styles 
  /// in this document if the styles are displayed in a user interface.
  /// </summary>
  [Category("Styling")]
  public string? StylePaneSortMethods { get; set; }

  /// <summary>
  /// This element specifies the size for automatic document summaries performed on the content of a WordprocessingML document. 
  /// An automatic document summary is a subset of text contained in a document deemed by the hosting application 
  /// to summarize the content of the WordprocessingML document. 
  /// The val attribute of this element specifies the size of an automatic document summary to be performed 
  /// on a given WordprocessingML document as a percentage of the total size of the given WordprocessingML document. 
  /// Performing an automatic document summary is a runtime operation outside the scope of ECMA-376.
  /// </summary>
  public Percent? SummaryLength { get; set; }

  /// <summary>
  /// This element specifies the language which shall be used to determine the appropriate theme fonts 
  /// in the document's Theme part which map to the major/minor theme fonts. 
  /// Specifically, the bidi attribute is used to determine the theme font applied to complex script text, 
  /// the eastAsia attribute is used to determine the theme font applied to East Asian text, 
  /// and the val attribute is used to determine the theme font applied to all other text.
  /// </summary>
  [Category("Fonts")]
  public Languages? ThemeFontLanguages { get; set; }

  /// <summary>
  /// This element specifies that applications shall track revisions made to the WordprocessingML document. 
  /// Revisions are changes to a WordprocessingML document which are recorded such that they can be viewed independently, 
  /// accepted, or removed, and reverted if needed. When revisions are tracked, 
  /// the resulting WordprocessingML markup in the Revisions subclause of this document describes the necessary syntax.
  /// </summary>
  [Category("Tracking")]
  public bool? TrackRevisions { get; set; }

  /// <summary>
  /// Disable Features Incompatible With Earlier Word Processing Formats.
  /// </summary>
  public bool? UICompatibleWith97To2003 { get; set; }

  /// <summary>
  /// This element specifies whether the fields contained in this document should automatically have their field result recalculated 
  /// from the field codes when this document is opened by an application which supports field calculations. 
  /// Note: Some fields are always recalculated (e.g. the page numbering), therefore this element only affects fields 
  /// which are typically not automatically recalculated on opening the document. Also note that this setting must 
  /// not supersede any document protection (§17.15.1.29) or write protection (§17.15.1.93) settings.
  /// </summary>
  [Category("Protection")]
  public bool? UpdateFieldsOnOpen { get; set; }

  /// <summary>
  /// This element specifies that this document should be saved through the custom XSLT transform 
  /// defined by the saveThroughXslt element (§17.15.1.76) in this document when it is saved as a single XML file (not defined by ECMA-376). 
  /// Guidance: Because this setting specifies behavior when saving to an alternative file format not defined by ECMA-376, this behavior is optional. 
  /// Note: If the saveXmlDataOnly element (§17.15.1.77) is specified, then the single XML file to be transformed is the custom XML markup of the document, 
  /// otherwise, it is in an implementation-defined format. 
  /// If the XSL transform specified by the saveThroughXslt element is not present, then this setting should be ignored.
  /// </summary>
  [Category("Xslt")]
  public bool? UseXsltWhenSaving { get; set; }

  /// <summary>
  /// This element specifies the manner in which the contents of this document should be displayed when opened by an application. 
  /// Note: Although this Standard is for a file format, occasionally, guidance is given regarding intent in dealing with things outside that file format, 
  /// such as the rendering of documents to a screen or printer. 
  /// </summary>
  [Category("View")]
  public ViewKind? View { get; set; }

  /// <summary>
  /// This element specifies the write protection settings which have been applied to a WordprocessingML document. 
  /// Write protection refers to a mode in which the document's contents cannot be edited, 
  /// and the document cannot be resaved using the same file name. 
  /// This setting is independent of the documentProtection (§17.15.1.29) element, but like document protection, 
  /// this setting is not intended as a security feature and can be ignored.
  /// </summary>
  [Category("Protection")]
  public WriteProtection? WriteProtection { get; set; }

  /// <summary>
  /// This element specifies the magnification level which should be applied to a document when it is displayed by an application.
  /// </summary>
  [Category("View")]
  public Zoom? Zoom { get; set; }

}