namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a paragraph element in a WordprocessingML document.
/// This class extends multiple content and collection Interop, providing properties for unique identification, revision tracking, spell checking, and paragraph formatting. Enables advanced management, revision, and formatting of paragraph content within the document.
/// </summary>
[XmlRoot("Paragraph", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlLoadData(nameof(LoadDataCollection))]
[OpenXmlUpdateData(nameof(UpdateDataCollection))]
[SpecificClass]
public partial class Paragraph : ModelElement<DXW.Paragraph>, IStoryContent, ITableCellContent, ISdtBlockContent, ICustomXmlBlockContent, ICommentContent, IBidirectionalContent
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Paragraph() : base() { }

  /// <summary>
  /// Constructor that initializes the element within an owner collection.
  /// </summary>
  /// <param name="collection">The collection to which this element belongs.</param>
  public Paragraph(object collection) : base(collection) { }

  /// <summary>
  /// Identifier for the paragraph, unique within the document part (except across Alternate Content blocks). Values must be greater than 0 and less than 0x80000000.
  /// </summary>
  public HexInt? ParagraphId { get; set; }
  /// <summary>
  /// Version identifier for the paragraph. Values must be greater than 0 and less than 0x80000000. Requires <see cref = "ParagraphId"/>. Used for text identity across documents with the same docId.
  /// </summary>
  public HexInt? TextId { get; set; }
  /// <summary>
  /// Revision identifier for paragraph glyph formatting.
  /// </summary>
  public HexInt? RsidParagraphMarkRevision { get; set; }
  /// <summary>
  /// Revision identifier for paragraph addition.
  /// </summary>
  public HexInt? RsidParagraphAddition { get; set; }
  /// <summary>
  /// Revision identifier for paragraph deletion.
  /// </summary>
  public HexInt? RsidParagraphDeletion { get; set; }
  /// <summary>
  /// Revision identifier for paragraph properties.
  /// </summary>
  public HexInt? RsidParagraphProperties { get; set; }
  /// <summary>
  /// Default revision identifier for runs within the paragraph.
  /// </summary>
  public HexInt? RsidRunAdditionDefault { get; set; }
  /// <summary>
  /// Indicates whether the text of the paragraph is free of detected spelling errors.
  /// </summary>
  public bool? NoSpellError { get; set; }
  /// <summary>
  /// Paragraph properties, specifying formatting and layout options for the paragraph.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }

  private readonly Dictionary<Type, Type> _modelElementTypeMapping = new()
  {
    { typeof(DXM.Accent), typeof(DMM.Accent) },
    { typeof(DXM.Bar), typeof(DMM.Bar) },
    { typeof(DXM.BorderBox), typeof(DMM.BorderBox) },
    { typeof(DXM.Box), typeof(DMM.Box) },
    { typeof(DXM.Delimiter), typeof(DMM.Delimiter) },
    { typeof(DXM.EquationArray), typeof(DMM.EquationArray) },
    { typeof(DXM.Fraction), typeof(DMM.Fraction) },
    { typeof(DXM.MathFunction), typeof(DMM.Function) },
    { typeof(DXM.GroupChar), typeof(DMM.GroupChar) },
    { typeof(DXM.LimitLower), typeof(DMM.LimitLower) },
    { typeof(DXM.LimitUpper), typeof(DMM.LimitUpper) },
    { typeof(DXM.Matrix), typeof(DMM.Matrix) },
    { typeof(DXM.Nary), typeof(DMM.Nary) },
    { typeof(DXM.OfficeMath), typeof(DMM.OfficeMath) },
    { typeof(DXM.Paragraph), typeof(DMM.Paragraph) },
    { typeof(DXM.Phantom), typeof(DMM.Phantom) },
    { typeof(DXM.Run), typeof(DMM.Run) },
    { typeof(DXM.Radical), typeof(DMM.Radical) },
    { typeof(DXM.PreSubSuper), typeof(DMM.PreSubSuper) },
    { typeof(DXM.Subscript), typeof(DMM.Subscript) },
    { typeof(DXM.SubSuperscript), typeof(DMM.SubSuperscript) },
    { typeof(DXM.Superscript), typeof(DMM.Superscript) },
    { typeof(DXW.BidirectionalOverride), typeof(DMW.BidirectionalOverride) },
    { typeof(DXW.BookmarkStart), typeof(DMW.BookmarkStart) },
    { typeof(DXW.ContentPart), typeof(DMW.ContentPart) },
    { typeof(DXW.CustomXmlRun), typeof(DMW.CustomXmlRun) },
    { typeof(DXW.BidirectionalEmbedding), typeof(DMW.BidirectionalEmbedding) },
    { typeof(DXW.Hyperlink), typeof(DMW.Hyperlink) },
    { typeof(DXW.CustomXmlInsRangeEnd), typeof(DMW.CustomXmlInsRangeEnd) },
    { typeof(DXW.CustomXmlDelRangeEnd), typeof(DMW.CustomXmlDelRangeEnd) },
    { typeof(DXW.CustomXmlMoveFromRangeEnd), typeof(DMW.CustomXmlMoveFromRangeEnd) },
    { typeof(DXW.CustomXmlMoveToRangeEnd), typeof(DMW.CustomXmlMoveToRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeEnd), typeof(DMW.CustomXmlConflictInsertionRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeEnd), typeof(DMW.CustomXmlConflictDeletionRangeEnd) },
    { typeof(DXW.BookmarkEnd), typeof(DMW.BookmarkEnd) },
    { typeof(DXW.CommentRangeStart), typeof(DMW.CommentRangeStart) },
    { typeof(DXW.CommentRangeEnd), typeof(DMW.CommentRangeEnd) },
    { typeof(DXW.MoveFromRangeEnd), typeof(DMW.MoveFromRangeEnd) },
    { typeof(DXW.MoveToRangeEnd), typeof(DMW.MoveToRangeEnd) },
    { typeof(DXW.MoveFromRangeStart), typeof(DMW.MoveFromRangeStart) },
    { typeof(DXW.MoveToRangeStart), typeof(DMW.MoveToRangeStart) },
    { typeof(DXW.PermEnd), typeof(DMW.PermEnd) },
    { typeof(DXW.PermStart), typeof(DMW.PermStart) },
    { typeof(DXW.ParagraphProperties), typeof(DMW.ParagraphProperties) },
    { typeof(DXW.ProofError), typeof(DMW.ProofError) },
    { typeof(DXW.Run), typeof(DMW.Run) },
    { typeof(DXW.SubDocumentReference), typeof(DMW.SubDocumentReference) },
    { typeof(DXW.InsertedRun), typeof(DMW.InsertedRun) },
    { typeof(DXW.DeletedRun), typeof(DMW.DeletedRun) },
    { typeof(DXW.MoveFromRun), typeof(DMW.MoveFromRun) },
    { typeof(DXW.MoveToRun), typeof(DMW.MoveToRun) },
    { typeof(DXO10W.RunConflictInsertion), typeof(DMW.RunConflictInsertion) },
    { typeof(DXO10W.RunConflictDeletion), typeof(DMW.RunConflictDeletion) },
    { typeof(DXW.SdtRun), typeof(DMW.SdtRun) },
    { typeof(DXW.SimpleField), typeof(DMW.SimpleField) },
    { typeof(DXW.CustomXmlInsRangeStart), typeof(DMW.CustomXmlInsRangeStart) },
    { typeof(DXW.CustomXmlDelRangeStart), typeof(DMW.CustomXmlDelRangeStart) },
    { typeof(DXW.CustomXmlMoveFromRangeStart), typeof(DMW.CustomXmlMoveFromRangeStart) },
    { typeof(DXW.CustomXmlMoveToRangeStart), typeof(DMW.CustomXmlMoveToRangeStart) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeStart), typeof(DMW.CustomXmlConflictInsertionRangeStart) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeStart), typeof(DMW.CustomXmlConflictDeletionRangeStart) },
  };

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
  public ObservableCollection<ModelElement> Items { get; set; } = new();


  /// <summary>
  /// Loads model elements from the specified Open XML composite element and populates the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element containing child elements to load.</param>
  protected void LoadDataCollection(DXW.Paragraph openXmlModeledCollection)
  {
    Items.Clear();
    foreach (var openXmlElement in openXmlModeledCollection.Elements())
    {
      var openXmlElementType = openXmlElement.GetType();
      if (openXmlElementType == typeof(DXW.ParagraphProperties))
      {
        if (ParagraphProperties == null)
        {
          ParagraphProperties = new ParagraphProperties(this);
        }
        ParagraphProperties.LoadData(openXmlElement);
        continue;
      }
      if (!_modelElementTypeMapping.TryGetValue(openXmlElementType, out var modelElementType))
      {
        throw new InvalidOperationException(
          $"No model element type mapping found for Open XML element type {openXmlElementType.FullName}.");
      }
      ModelElement? modelObject = null;
      var constructor = modelElementType.GetConstructor([this.GetType()]);
      if (constructor != null)
      {
        modelObject = (ModelElement)constructor.Invoke([this]);
        Items.Add(modelObject);
        modelObject.LoadData(openXmlElement);
      }
      else
      {
        constructor = modelElementType.GetConstructor([openXmlElementType, this.GetType()]);
        if (constructor != null)
        {
          modelObject = (ModelElement)constructor.Invoke([openXmlElement, this]);
        }
        else
        {
          constructor = modelElementType.GetConstructor([openXmlElementType]);
          if (constructor != null)
          {
            modelObject = (ModelElement)constructor.Invoke([openXmlElement]);
            Items.Add(modelObject);
          }
          else
          {
            constructor = modelElementType.GetConstructor([]);
            if (constructor != null)
            {
              modelObject = (ModelElement)constructor.Invoke([]);
              Debug.WriteLine(
                $"Warning: Model element of type {modelElementType.FullName} was created using a parameterless constructor. Consider adding a constructor that accepts the parent collection or the Open XML element for better initialization.");
              Items.Add(modelObject);
              modelObject.LoadData(openXmlElement);
            }
            else
            {
              throw new InvalidOperationException(
                $"No suitable constructor found for model element type {modelElementType.FullName}.");
            }
          }
        }
      }
    }
  }

  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element to update.</param>
  protected void UpdateDataCollection(DXW.Paragraph openXmlModeledCollection)
  {
    SetUpdatableElement(openXmlModeledCollection);
    var children = openXmlModeledCollection.Elements().ToArray();
    foreach (var child in children)
    {
      child.Remove();
    }
    foreach (var item in Items)
    {
      if (item is IUpdatable updatable)
      {
        var updatableElement = updatable.GetUpdatableElement();
        if (updatableElement is DX.OpenXmlElement openXmlElement)
        {
          item.UpdateData(openXmlElement);
          openXmlModeledCollection.AppendChild(openXmlElement);
        }
      }
    }
  }

}