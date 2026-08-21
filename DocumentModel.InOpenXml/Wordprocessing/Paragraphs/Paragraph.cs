namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a paragraph element in a WordprocessingML document.
/// This class extends multiple content and collection Interop, providing properties for unique identification, revision tracking, spell checking, and paragraph formatting. Enables advanced management, revision, and formatting of paragraph content within the document.
/// </summary>
[DataContract]
[XmlRoot("Paragraph", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.Paragraph))]
[SpecificClass]
[DirectAccess(true)]
[ContentProperty(nameof(Items))]
public partial class Paragraph: ModelElement<DXW.Paragraph>, IHexIdentObject, IStoryContent, ITableCellContent, ISdtBlockContent,
  ICustomXmlBlockContent, ICommentContent, IBidirectionalContent
{
  /// <summary>
  /// Initializes a new instance of the Paragraph class.
  /// </summary>
  /// <remarks>This constructor creates a new paragraph element using the default settings. Use this constructor
  /// when you want to create a new paragraph in a document without copying from an existing one.</remarks>
  public Paragraph(): base() { }

  /// <summary>
  /// Initializes a new instance of the Paragraph class with the specified parent object.
  /// </summary>
  /// <param name = "parent">The parent object that will contain this Paragraph instance. This parameter establishes the hierarchical relationship
  /// within the object model and cannot be null.</param>
  /// <param name = "openXmlElement">The OpenXmlCompositeElement that provides the XML data for the Paragraph instance. Cannot be null.</param>
  public Paragraph(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement): base(parent, openXmlElement) { }

  /// <summary>
  /// Initializes a new instance of the Paragraph class using the specified OpenXmlCompositeElement.  
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the underlying XML data for the Paragraph.</param>
  public Paragraph(DX.OpenXmlCompositeElement openXmlElement): base(openXmlElement) { }

  private DXW.Paragraph? _openXmlParagraph => GetUpdatableElement() as DXW.Paragraph;

  /// <summary>
  /// If this object has direct access to the underlying OpenXml element,
  /// this method is overridden to set up the updatable object with the provided OpenXmlCompositeElement.
  /// However, it does not perform any additional data loading, as the properties are accessed directly from the OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the underlying XML data for the Paragraph.</param>
  /// <returns>True if the data was successfully loaded; otherwise, false.</returns>
  public override bool LoadData(object openXmlElement)
  {
    if (HasDirectAccess)
    {
      SetUpdatableObject(openXmlElement);
      return false;
    }
    return base.LoadData(openXmlElement);
  }

  /// <summary>
  /// Unique identifier for the paragraph, represented as a hexadecimal integer.
  /// This property is an alias for <see cref="ParagraphId"/> and provides a convenient way to access the paragraph's unique identifier in hexadecimal format.
  /// </summary>
  public HexInt? HexId => ParagraphId;

  /// <summary>
  /// Identifier for the paragraph, unique within the document part (except across Alternate Content blocks). Values must be greater than 0 and less than 0x80000000.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.ParagraphId), DirectAccess = true)]
  public HexInt? ParagraphId
  {
    get => _ParagraphId ??= GetProperty<HexInt?>(_openXmlParagraph!.ParagraphId);
    set => UpdateField(ref _ParagraphId, value, nameof(ParagraphId));
  }

  private HexInt? _ParagraphId;

  /// <summary>
  /// Version identifier for the paragraph. Values must be greater than 0 and less than 0x80000000. Requires <see cref = "ParagraphId"/>. Used for text identity across documents with the same docId.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.TextId))]
  public HexInt? TextId
  {
    get => _TextId ??= GetProperty<HexInt?>(_openXmlParagraph!.TextId);
    set => UpdateField(ref _TextId, value, nameof(TextId));
  }

  private HexInt? _TextId;

  /// <summary>
  /// Revision identifier for paragraph addition.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphAddition))]
  public HexInt? RsidParagraphAddition
  {
    get => _RsidParagraphAddition ??= GetProperty<HexInt?>(_openXmlParagraph!.RsidParagraphAddition);
    set => UpdateField(ref _RsidParagraphAddition, value, nameof(RsidParagraphAddition));
  }

  private HexInt? _RsidParagraphAddition;

  /// <summary>
  /// Revision identifier for paragraph deletion.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphDeletion))]
  public HexInt? RsidParagraphDeletion
  {
    get => _RsidParagraphDeletion ??= GetProperty<HexInt?>(_openXmlParagraph!.RsidParagraphDeletion);
    set => UpdateField(ref _RsidParagraphDeletion, value, nameof(RsidParagraphDeletion));
  }

  private HexInt? _RsidParagraphDeletion;

  /// <summary>
  /// Revision identifier for paragraph properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphProperties))]
  public HexInt? RsidParagraphProperties
  {
    get => _RsidParagraphProperties ??= GetProperty<HexInt?>(_openXmlParagraph!.RsidParagraphProperties);
    set => UpdateField(ref _RsidParagraphProperties, value, nameof(RsidParagraphProperties));
  }

  private HexInt? _RsidParagraphProperties;

  /// <summary>
  /// Default revision identifier for runs within the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidRunAdditionDefault))]
  public HexInt? RsidRunAdditionDefault
  {
    get => _RsidRunAdditionDefault ??= GetProperty<HexInt?>(_openXmlParagraph!.RsidRunAdditionDefault);
    set => UpdateField(ref _RsidRunAdditionDefault, value, nameof(RsidRunAdditionDefault));
  }

  private HexInt? _RsidRunAdditionDefault;

  /// <summary>
  /// Revision identifier for paragraph glyph formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphMarkRevision))]
  public HexInt? RsidParagraphMarkRevision
  {
    get => _RsidParagraphMarkRevision ??= GetProperty<HexInt?>(_openXmlParagraph!.RsidParagraphMarkRevision);
    set => UpdateField(ref _RsidParagraphMarkRevision, value, nameof(RsidParagraphMarkRevision));
  }

  private HexInt? _RsidParagraphMarkRevision;

  /// <summary>
  /// Indicates whether the text of the paragraph is free of detected spelling errors.
  /// <remarks>
  /// It acts as a performance and proofing flag for word processors like Microsoft Word,
  /// indicating that the application has already spell-checked the text and cleared it.
  /// 1 (or true) means that no spelling errors were detected in this paragraph.
  /// Word won't re-flag text in this paragraph with red squiggly lines unless the text is edited.
  /// 0 (or false) specifies that no spelling information is available (Default).
  /// The word processor will dynamically run its spell checker over the paragraph when the document is opened.
  /// </remarks>
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.NoSpellError))]
  public bool? NoSpellError
  {
    get => _NoSpellError ??= GetProperty<bool?>(_openXmlParagraph!.NoSpellError);
    set => UpdateField(ref _NoSpellError, value, nameof(NoSpellError));
  }

  private bool? _NoSpellError;

  /// <summary>
  /// Paragraph properties, specifying formatting and layout options for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.ParagraphProperties))]
  public ParagraphProperties? ParagraphProperties
  {
    get => _ParagraphProperties ??= GetProperty<ParagraphProperties?>(_openXmlParagraph?.ParagraphProperties);
    set => UpdateField(ref _ParagraphProperties, value, nameof(ParagraphProperties));
  }

  private ParagraphProperties? _ParagraphProperties;

  /// <summary>
  /// Collection of items.
  /// </summary>
  [XmlArray("Items")]
  [XmlArrayItem("m:Accent", typeof(DMM.Accent))]
  [XmlArrayItem("m:Bar", typeof(DMM.Bar))]
  [XmlArrayItem("m:BorderBox", typeof(DMM.BorderBox))]
  [XmlArrayItem("m:Box", typeof(DMM.Box))]
  [XmlArrayItem("m:Delimiter", typeof(DMM.Delimiter))]
  [XmlArrayItem("m:EquationArray", typeof(DMM.EquationArray))]
  [XmlArrayItem("m:Fraction", typeof(DMM.Fraction))]
  [XmlArrayItem("m:MathFunction", typeof(DMM.Function))]
  [XmlArrayItem("m:GroupChar", typeof(DMM.GroupChar))]
  [XmlArrayItem("m:LimitLower", typeof(DMM.LimitLower))]
  [XmlArrayItem("m:LimitUpper", typeof(DMM.LimitUpper))]
  [XmlArrayItem("m:Matrix", typeof(DMM.Matrix))]
  [XmlArrayItem("m:Nary", typeof(DMM.Nary))]
  [XmlArrayItem("m:OfficeMath", typeof(DMM.OfficeMath))]
  [XmlArrayItem("m:Paragraph", typeof(DMM.Paragraph))]
  [XmlArrayItem("m:Phantom", typeof(DMM.Phantom))]
  [XmlArrayItem("m:Run", typeof(DMM.Run))]
  [XmlArrayItem("m:Radical", typeof(DMM.Radical))]
  [XmlArrayItem("m:PreSubSuper", typeof(DMM.PreSubSuper))]
  [XmlArrayItem("m:Subscript", typeof(DMM.Subscript))]
  [XmlArrayItem("m:SubSuperscript", typeof(DMM.SubSuperscript))]
  [XmlArrayItem("m:Superscript", typeof(DMM.Superscript))]
  [XmlArrayItem("BidirectionalOverride", typeof(DMW.BidirectionalOverride))]
  [XmlArrayItem("BookmarkStart", typeof(DMW.BookmarkStart))]
  [XmlArrayItem("ContentPart", typeof(DMW.ContentPart))]
  [XmlArrayItem("CustomXmlRun", typeof(DMW.CustomXmlRun))]
  [XmlArrayItem("BidirectionalEmbedding", typeof(DMW.BidirectionalEmbedding))]
  [XmlArrayItem("Hyperlink", typeof(DMW.Hyperlink))]
  [XmlArrayItem("CustomXmlInsRangeEnd", typeof(DMW.CustomXmlInsRangeEnd))]
  [XmlArrayItem("CustomXmlDelRangeEnd", typeof(DMW.CustomXmlDelRangeEnd))]
  [XmlArrayItem("CustomXmlMoveFromRangeEnd", typeof(DMW.CustomXmlMoveFromRangeEnd))]
  [XmlArrayItem("CustomXmlMoveToRangeEnd", typeof(DMW.CustomXmlMoveToRangeEnd))]
  [XmlArrayItem("CustomXmlConflictInsertionRangeEnd", typeof(DMW.CustomXmlConflictInsertionRangeEnd))]
  [XmlArrayItem("CustomXmlConflictDeletionRangeEnd", typeof(DMW.CustomXmlConflictDeletionRangeEnd))]
  [XmlArrayItem("BookmarkEnd", typeof(DMW.BookmarkEnd))]
  [XmlArrayItem("CommentRangeStart", typeof(DMW.CommentRangeStart))]
  [XmlArrayItem("CommentRangeEnd", typeof(DMW.CommentRangeEnd))]
  [XmlArrayItem("MoveFromRangeEnd", typeof(DMW.MoveFromRangeEnd))]
  [XmlArrayItem("MoveToRangeEnd", typeof(DMW.MoveToRangeEnd))]
  [XmlArrayItem("MoveFromRangeStart", typeof(DMW.MoveFromRangeStart))]
  [XmlArrayItem("MoveToRangeStart", typeof(DMW.MoveToRangeStart))]
  [XmlArrayItem("PermEnd", typeof(DMW.PermEnd))]
  [XmlArrayItem("PermStart", typeof(DMW.PermStart))]
  [XmlArrayItem("ParagraphProperties", typeof(DMW.ParagraphProperties))]
  [XmlArrayItem("ProofError", typeof(DMW.ProofError))]
  [XmlArrayItem("Run", typeof(DMW.Run))]
  [XmlArrayItem("SubDocumentReference", typeof(DMW.SubDocumentReference))]
  [XmlArrayItem("InsertedRun", typeof(DMW.InsertedRun))]
  [XmlArrayItem("DeletedRun", typeof(DMW.DeletedRun))]
  [XmlArrayItem("MoveFromRun", typeof(DMW.MoveFromRun))]
  [XmlArrayItem("MoveToRun", typeof(DMW.MoveToRun))]
  [XmlArrayItem("RunConflictInsertion", typeof(DMW.RunConflictInsertion))]
  [XmlArrayItem("RunConflictDeletion", typeof(DMW.RunConflictDeletion))]
  [XmlArrayItem("SdtRun", typeof(DMW.SdtRun))]
  [XmlArrayItem("SimpleField", typeof(DMW.SimpleField))]
  [XmlArrayItem("CustomXmlInsRangeStart", typeof(DMW.CustomXmlInsRangeStart))]
  [XmlArrayItem("CustomXmlDelRangeStart", typeof(DMW.CustomXmlDelRangeStart))]
  [XmlArrayItem("CustomXmlMoveFromRangeStart", typeof(DMW.CustomXmlMoveFromRangeStart))]
  [XmlArrayItem("CustomXmlMoveToRangeStart", typeof(DMW.CustomXmlMoveToRangeStart))]
  [XmlArrayItem("CustomXmlConflictInsertionRangeStart", typeof(DMW.CustomXmlConflictInsertionRangeStart))]
  [XmlArrayItem("CustomXmlConflictDeletionRangeStart", typeof(DMW.CustomXmlConflictDeletionRangeStart))]
  public ParagraphItemsCollection Items => _Items ??= new ParagraphItemsCollection(this, GetUpdatableElement());

  private ParagraphItemsCollection? _Items;

  /// <summary>
  /// Gets a collection of runs within the paragraph, providing access to all run elements contained in the paragraph's items.
  /// This property retrieves a collection of runs by filtering the items in the paragraph to include only those that are of type <see cref="DMW.Run"/>.
  /// </summary>
  [XmlIgnore]
  public DMW.Runs Runs => _Runs ??= new DMW.Runs(this, Items);

  private DMW.Runs? _Runs;

  /// <summary>
  /// Adds a new ModelElement to the paragraph's items collection.
  /// </summary>
  /// <param name="element">The ModelElement to add to the paragraph's items collection.</param>
  public void Add(ModelElement element)
  {
    Items.AddModelElement(element);
  }
}