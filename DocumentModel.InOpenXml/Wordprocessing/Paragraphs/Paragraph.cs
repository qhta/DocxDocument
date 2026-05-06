namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a paragraph element in a WordprocessingML document.
/// This class extends multiple content and collection Interop, providing properties for unique identification, revision tracking, spell checking, and paragraph formatting. Enables advanced management, revision, and formatting of paragraph content within the document.
/// </summary>
[XmlRoot("Paragraph", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.Paragraph))]
[SpecificClass]
public partial class Paragraph : ModelElement<DXW.Paragraph>, IStoryContent, ITableCellContent, ISdtBlockContent, 
  ICustomXmlBlockContent, ICommentContent, IBidirectionalContent
{
  /// <summary>
  /// Initializes a new instance of the Paragraph class.
  /// </summary>
  /// <remarks>This constructor creates a new paragraph element using the default settings. Use this constructor
  /// when you want to create a new paragraph in a document without copying from an existing one.</remarks>
  public Paragraph() : base() { }

  private DXW.Paragraph _paragraph => _openXmlElement as DXW.Paragraph ?? throw new InvalidOperationException("Underlying OpenXml element is not of type DXW.Paragraph.");

  /// <summary>
  /// Identifier for the paragraph, unique within the document part (except across Alternate Content blocks). Values must be greater than 0 and less than 0x80000000.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.ParagraphId), DirectAccess = true)]
  public HexInt? ParagraphId 
  { 
    get => OpenXmlModelConverter.ConvertFrom<HexInt?, DX.HexBinaryValue>(_paragraph.ParagraphId); 
    set => _paragraph.ParagraphId = OpenXmlModelConverter.ConvertTo<HexInt?, DX.HexBinaryValue>(value);
  }

  /// <summary>
  /// Version identifier for the paragraph. Values must be greater than 0 and less than 0x80000000. Requires <see cref = "ParagraphId"/>. Used for text identity across documents with the same docId.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.TextId))]
  public HexInt? TextId { get => _TextId; set => UpdateField(ref _TextId, value, nameof(TextId)); }
  private HexInt? _TextId;

  /// <summary>
  /// Revision identifier for paragraph addition.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphAddition))]
  public HexInt? RsidParagraphAddition { get => _RsidParagraphAddition; set => UpdateField(ref _RsidParagraphAddition, value, nameof(RsidParagraphAddition)); }
  private HexInt? _RsidParagraphAddition;

  /// <summary>
  /// Revision identifier for paragraph deletion.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphDeletion))]
  public HexInt? RsidParagraphDeletion { get => _RsidParagraphDeletion; set => UpdateField(ref _RsidParagraphDeletion, value, nameof(RsidParagraphDeletion)); }
  private HexInt? _RsidParagraphDeletion;

  /// <summary>
  /// Revision identifier for paragraph properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphProperties))]
  public HexInt? RsidParagraphProperties { get => _RsidParagraphProperties; set => UpdateField(ref _RsidParagraphProperties, value, nameof(RsidParagraphProperties)); }
  private HexInt? _RsidParagraphProperties;

  /// <summary>
  /// Default revision identifier for runs within the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidRunAdditionDefault))]
  public HexInt? RsidRunAdditionDefault { get => _RsidRunAdditionDefault; set => UpdateField(ref _RsidRunAdditionDefault, value, nameof(RsidRunAdditionDefault)); }
  private HexInt? _RsidRunAdditionDefault;

  /// <summary>
  /// Revision identifier for paragraph glyph formatting.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.RsidParagraphMarkRevision))]
  public HexInt? RsidParagraphMarkRevision { get => _RsidParagraphMarkRevision; set => UpdateField(ref _RsidParagraphMarkRevision, value, nameof(RsidParagraphMarkRevision)); }
  private HexInt? _RsidParagraphMarkRevision;

  /// <summary>
  /// Indicates whether the text of the paragraph is free of detected spelling errors.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.NoSpellError))]
  public bool? NoSpellError { get => _NoSpellError; set => UpdateField(ref _NoSpellError, value, nameof(NoSpellError)); }
  private bool? _NoSpellError;

  /// <summary>
  /// Paragraph properties, specifying formatting and layout options for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Paragraph.ParagraphProperties))]
  public ParagraphProperties? ParagraphProperties { get => _ParagraphProperties; set => UpdateField(ref _ParagraphProperties, value, nameof(ParagraphProperties)); }
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
  public ParagraphItemsCollection Items
  {
    get => _Items ??= new ParagraphItemsCollection(this, _openXmlElement);
  }
  private ParagraphItemsCollection? _Items;
}