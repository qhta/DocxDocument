namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the content of the document or part of the document.
/// This class extends <see cref = "ModelElementCollection{StoryContent}"/> and contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
/// </summary>
[DataContract]
[XmlRoot("Story", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DX.OpenXmlCompositeElement))]
[DirectAccess(true)]
public abstract partial class Story<OpenXmlCollectionType>: ModelElement<OpenXmlCollectionType>, IStory
  where OpenXmlCollectionType: DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Default constructor for the Story class, initializing a new instance of the Story class.
  /// </summary>
  protected Story() { }

  /// <summary>
  /// Initializes a new instance of the Story class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement to associate with this story. Cannot be null. </param>
  /// <param name="openXmlElement">The OpenXmlCollectionType element that provides the underlying XML data for the story.</param>
  protected Story(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement): base(parent, openXmlElement) { }

  /// <summary>
  /// Initializes a new instance of the Story class using the specified OpenXmlCollectionType element.
  /// </summary>
  protected Story(DX.OpenXmlCompositeElement openXmlElement) : base(openXmlElement) { }

  /// <summary>
  /// Collection of items.
  /// </summary>
  //[XmlArray("Items")]
  //[XmlArrayItem("AlternateContent", typeof(DM.AlternateContent))]
  //[XmlArrayItem("Accent", typeof(DMM.Accent))]
  //[XmlArrayItem("Bar", typeof(DMM.Bar))]
  //[XmlArrayItem("BorderBox", typeof(DMM.BorderBox))]
  //[XmlArrayItem("Box", typeof(DMM.Box))]
  //[XmlArrayItem("Delimiter", typeof(DMM.Delimiter))]
  //[XmlArrayItem("EquationArray", typeof(DMM.EquationArray))]
  //[XmlArrayItem("Fraction", typeof(DMM.Fraction))]
  //[XmlArrayItem("GroupChar", typeof(DMM.GroupChar))]
  //[XmlArrayItem("LimitLower", typeof(DMM.LimitLower))]
  //[XmlArrayItem("LimitUpper", typeof(DMM.LimitUpper))]
  //[XmlArrayItem("MathFunction", typeof(DMM.Function))]
  //[XmlArrayItem("Matrix", typeof(DMM.Matrix))]
  //[XmlArrayItem("Nary", typeof(DMM.Nary))]
  //[XmlArrayItem("OfficeMath", typeof(DMM.OfficeMath))]
  //[XmlArrayItem("Paragraph", typeof(DMM.Paragraph))]
  //[XmlArrayItem("Phantom", typeof(DMM.Phantom))]
  //[XmlArrayItem("PreSubSuper", typeof(DMM.PreSubSuper))]
  //[XmlArrayItem("Radical", typeof(DMM.Radical))]
  //[XmlArrayItem("Run", typeof(DMM.Run))]
  //[XmlArrayItem("Subscript", typeof(DMM.Subscript))]
  //[XmlArrayItem("SubSuperscript", typeof(DMM.SubSuperscript))]
  //[XmlArrayItem("Superscript", typeof(DMM.Superscript))]
  //[XmlArrayItem("CustomXmlConflictDeletionRangeEnd", typeof(DMW.CustomXmlConflictDeletionRangeEnd))]
  //[XmlArrayItem("CustomXmlConflictDeletionRangeStart", typeof(DMW.CustomXmlConflictDeletionRangeStart))]
  //[XmlArrayItem("CustomXmlConflictInsertionRangeEnd", typeof(DMW.CustomXmlConflictInsertionRangeEnd))]
  //[XmlArrayItem("CustomXmlConflictInsertionRangeStart", typeof(DMW.CustomXmlConflictInsertionRangeStart))]
  //[XmlArrayItem("RunConflictDeletion", typeof(DMW.RunConflictDeletion))]
  //[XmlArrayItem("RunConflictInsertion", typeof(DMW.RunConflictInsertion))]
  //[XmlArrayItem("AltChunk", typeof(DMW.AltChunk))]
  //[XmlArrayItem("AnnotationReferenceMark", typeof(DMW.AnnotationReferenceMark))]
  //[XmlArrayItem("BidirectionalEmbedding", typeof(DMW.BidirectionalEmbedding))]
  //[XmlArrayItem("BidirectionalOverride", typeof(DMW.BidirectionalOverride))]
  //[XmlArrayItem("BookmarkEnd", typeof(DMW.BookmarkEnd))]
  //[XmlArrayItem("BookmarkStart", typeof(DMW.BookmarkStart))]
  //[XmlArrayItem("Break", typeof(DMW.Break))]
  //[XmlArrayItem("CarriageReturn", typeof(DMW.CarriageReturn))]
  //[XmlArrayItem("CommentRangeEnd", typeof(DMW.CommentRangeEnd))]
  //[XmlArrayItem("CommentRangeStart", typeof(DMW.CommentRangeStart))]
  //[XmlArrayItem("CommentReference", typeof(DMW.CommentReference))]
  //[XmlArrayItem("ContentPart", typeof(DMW.ContentPart))]
  //[XmlArrayItem("ContinuationSeparatorMark", typeof(DMW.ContinuationSeparatorMark))]
  //[XmlArrayItem("CustomXmlBlock", typeof(DMW.CustomXmlBlock))]
  //[XmlArrayItem("CustomXmlDelRangeEnd", typeof(DMW.CustomXmlDelRangeEnd))]
  //[XmlArrayItem("CustomXmlDelRangeStart", typeof(DMW.CustomXmlDelRangeStart))]
  //[XmlArrayItem("CustomXmlInsRangeEnd", typeof(DMW.CustomXmlInsRangeEnd))]
  //[XmlArrayItem("CustomXmlInsRangeStart", typeof(DMW.CustomXmlInsRangeStart))]
  //[XmlArrayItem("CustomXmlMoveFromRangeEnd", typeof(DMW.CustomXmlMoveFromRangeEnd))]
  //[XmlArrayItem("CustomXmlMoveFromRangeStart", typeof(DMW.CustomXmlMoveFromRangeStart))]
  //[XmlArrayItem("CustomXmlMoveToRangeEnd", typeof(DMW.CustomXmlMoveToRangeEnd))]
  //[XmlArrayItem("CustomXmlMoveToRangeStart", typeof(DMW.CustomXmlMoveToRangeStart))]
  //[XmlArrayItem("CustomXmlRun", typeof(DMW.CustomXmlRun))]
  //[XmlArrayItem("DayLong", typeof(DMW.DayLong))]
  //[XmlArrayItem("DayShort", typeof(DMW.DayShort))]
  //[XmlArrayItem("DeletedFieldCode", typeof(DMW.DeletedFieldCode))]
  //[XmlArrayItem("DeletedRun", typeof(DMW.DeletedRun))]
  //[XmlArrayItem("DeletedText", typeof(DMW.DeletedText))]
  //[XmlArrayItem("Drawing", typeof(DMW.Drawing))]
  //[XmlArrayItem("EmbeddedObject", typeof(DMW.EmbeddedObject))]
  //[XmlArrayItem("EndnoteReference", typeof(DMW.EndnoteReference))]
  //[XmlArrayItem("EndnoteReferenceMark", typeof(DMW.EndnoteReferenceMark))]
  //[XmlArrayItem("FieldChar", typeof(DMW.FieldChar))]
  //[XmlArrayItem("FieldCode", typeof(DMW.FieldCode))]
  //[XmlArrayItem("FootnoteReference", typeof(DMW.FootnoteReference))]
  //[XmlArrayItem("FootnoteReferenceMark", typeof(DMW.FootnoteReferenceMark))]
  //[XmlArrayItem("Hyperlink", typeof(DMW.Hyperlink))]
  //[XmlArrayItem("InsertedRun", typeof(DMW.InsertedRun))]
  //[XmlArrayItem("LastRenderedPageBreak", typeof(DMW.LastRenderedPageBreak))]
  //[XmlArrayItem("MonthLong", typeof(DMW.MonthLong))]
  //[XmlArrayItem("MonthShort", typeof(DMW.MonthShort))]
  //[XmlArrayItem("MoveFromRangeEnd", typeof(DMW.MoveFromRangeEnd))]
  //[XmlArrayItem("MoveFromRangeStart", typeof(DMW.MoveFromRangeStart))]
  //[XmlArrayItem("MoveFromRun", typeof(DMW.MoveFromRun))]
  //[XmlArrayItem("MoveToRangeEnd", typeof(DMW.MoveToRangeEnd))]
  //[XmlArrayItem("MoveToRangeStart", typeof(DMW.MoveToRangeStart))]
  //[XmlArrayItem("MoveToRun", typeof(DMW.MoveToRun))]
  //[XmlArrayItem("NoBreakHyphen", typeof(DMW.NoBreakHyphen))]
  //[XmlArrayItem("PageNumber", typeof(DMW.PageNumber))]
  //[XmlArrayItem("Paragraph", typeof(DMW.Paragraph))]
  //[XmlArrayItem("ParagraphProperties", typeof(DMW.ParagraphProperties))]
  //[XmlArrayItem("PermEnd", typeof(DMW.PermEnd))]
  //[XmlArrayItem("PermStart", typeof(DMW.PermStart))]
  //[XmlArrayItem("Picture", typeof(DMW.Picture))]
  //[XmlArrayItem("PositionalTab", typeof(DMW.PositionalTab))]
  //[XmlArrayItem("ProofError", typeof(DMW.ProofError))]
  //[XmlArrayItem("Ruby", typeof(DMW.Ruby))]
  //[XmlArrayItem("Run", typeof(DMW.Run))]
  //[XmlArrayItem("RunProperties", typeof(DMW.RunProperties))]
  //[XmlArrayItem("SdtBlock", typeof(DMW.SdtBlock))]
  //[XmlArrayItem("SdtRun", typeof(DMW.SdtRun))]
  //[XmlArrayItem("SectionProperties", typeof(DMW.SectionProperties))]
  //[XmlArrayItem("SeparatorMark", typeof(DMW.SeparatorMark))]
  //[XmlArrayItem("SimpleField", typeof(DMW.SimpleField))]
  //[XmlArrayItem("SoftHyphen", typeof(DMW.SoftHyphen))]
  //[XmlArrayItem("SubDocumentReference", typeof(DMW.SubDocumentReference))]
  //[XmlArrayItem("SymbolChar", typeof(DMW.SymbolChar))]
  //[XmlArrayItem("TabChar", typeof(DMW.TabChar))]
  //[XmlArrayItem("Table", typeof(DMW.Table))]
  //[XmlArrayItem("Text", typeof(DMW.RunText))]
  //[XmlArrayItem("YearLong", typeof(DMW.YearLong))]
  //[XmlArrayItem("YearShort", typeof(DMW.YearShort))]
  public StoryItemsCollection Items
  {
    get
    {
      var result = _Items ??= new StoryItemsCollection(this, GetUpdatableElement());
      result.SetHasDirectAccess(this.HasDirectAccess);
      return result;
    }
  }

  private StoryItemsCollection? _Items;


  /// <summary>
  /// Gets a collection of paragraphs within the story, providing access to all paragraph elements contained in the story's items.
  /// This property retrieves a collection of paragraphs by filtering the items in the story to include only those that are of type <see cref="DMW.Paragraph"/>.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DMW.Paragraphs Paragraphs
  {
    get
    {
      var result = _Paragraphs ??= new DMW.Paragraphs(this, Items);
      return result;
    }
  }

  private DMW.Paragraphs? _Paragraphs;


  /// <summary>
  /// Gets a collection of paragraphs within the story, providing access to all paragraph elements contained in the story's items.
  /// This property retrieves a collection of paragraphs by filtering the items in the story to include only those that are of type <see cref="DMW.Paragraph"/>.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public DMW.Sections Sections
  {
    get
    {
      var result = _Sections ??= new DMW.Sections(this);
      return result;
    }
  }

  private DMW.Sections? _Sections;


  /// <summary>
  /// Clears the content of the story by removing all child elements from the underlying OpenXmlCollectionType element and resetting the items, paragraphs, and sections collections to null.
  /// </summary>
  public void Clear()
  {
    GetUpdatableElement()?.RemoveAllChildren();
    _Items = null;
    _Paragraphs = null;
    _Sections = null;
  }

  /// <summary>
  /// Adds a new ModelElement to the story's items collection.
  /// </summary>
  /// <param name="element">The ModelElement to add to the story's items collection.</param>
  public void Add(ModelElement element)
  {
    Items.AddModelElement(element);
  }
}