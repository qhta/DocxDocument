namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Run items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
public class RunItemsCollection: ContentItemsCollection
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="parent">Model element that owns this collection. Cannot be null.</param>
  /// <param name="openXmlRun">The OpenXml Run element to be wrapped by the collection. Can be null.</param>
  public RunItemsCollection(DMW.Run parent, DXW.Run? openXmlRun) : base(parent, openXmlRun)
  {
  }

  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type> _OpenXmlElement2ModelTypeMapping = new()
  {
    { typeof(DXW.Break), typeof(DMW.Break) },
    { typeof(DXW.Drawing), typeof(DMW.Drawing) },
    { typeof(DXW.NoBreakHyphen), typeof(DMW.NoBreakHyphen) },
    { typeof(DXW.SoftHyphen), typeof(DMW.SoftHyphen) },
    { typeof(DXW.DayShort), typeof(DMW.DayShort) },
    { typeof(DXW.MonthShort), typeof(DMW.MonthShort) },
    { typeof(DXW.YearShort), typeof(DMW.YearShort) },
    { typeof(DXW.DayLong), typeof(DMW.DayLong) },
    { typeof(DXW.MonthLong), typeof(DMW.MonthLong) },
    { typeof(DXW.YearLong), typeof(DMW.YearLong) },
    { typeof(DXW.AnnotationReferenceMark), typeof(DMW.AnnotationReferenceMark) },
    { typeof(DXW.FootnoteReferenceMark), typeof(DMW.FootnoteReferenceMark) },
    { typeof(DXW.EndnoteReferenceMark), typeof(DMW.EndnoteReferenceMark) },
    { typeof(DXW.SeparatorMark), typeof(DMW.SeparatorMark) },
    { typeof(DXW.ContinuationSeparatorMark), typeof(DMW.ContinuationSeparatorMark) },
    { typeof(DXW.PageNumber), typeof(DMW.PageNumber) },
    { typeof(DXW.CarriageReturn), typeof(DMW.CarriageReturn) },
    { typeof(DXW.TabChar), typeof(DMW.TabChar) },
    { typeof(DXW.LastRenderedPageBreak), typeof(DMW.LastRenderedPageBreak) },
    { typeof(DXW.FieldChar), typeof(DMW.FieldChar) },
    { typeof(DXW.FootnoteReference), typeof(DMW.FootnoteReference) },
    { typeof(DXW.EndnoteReference), typeof(DMW.EndnoteReference) },
    { typeof(DXW.CommentReference), typeof(DMW.CommentReference) },
    { typeof(DXW.EmbeddedObject), typeof(DMW.EmbeddedObject) },
    { typeof(DXW.Picture), typeof(DMW.Picture) },
    { typeof(DXW.PositionalTab), typeof(DMW.PositionalTab) },
    { typeof(DXW.RunProperties), typeof(DMW.RunProperties) },
    { typeof(DXW.Ruby), typeof(DMW.Ruby) },
    { typeof(DXW.SymbolChar), typeof(DMW.SymbolChar) },
    { typeof(DXW.Text), typeof(DMW.RunText) },
    { typeof(DXW.DeletedText), typeof(DMW.DeletedText) },
    { typeof(DXW.FieldCode), typeof(DMW.FieldCode) },
    { typeof(DXW.DeletedFieldCode), typeof(DMW.DeletedFieldCode) },
  };

  private static readonly Dictionary<Type, Type[]> _ModelType2OpenXmlElementMapping = new()
  {
    { typeof(DMW.Break), [typeof(DXW.Break)] },
    { typeof(DMW.Drawing), [typeof(DXW.Drawing)] },
    { typeof(DMW.NoBreakHyphen), [typeof(DXW.NoBreakHyphen)] },
    { typeof(DMW.SoftHyphen), [typeof(DXW.SoftHyphen)] },
    { typeof(DMW.DayShort), [typeof(DXW.DayShort)] },
    { typeof(DMW.MonthShort), [typeof(DXW.MonthShort)] },
    { typeof(DMW.YearShort), [typeof(DXW.YearShort)] },
    { typeof(DMW.DayLong), [typeof(DXW.DayLong)] },
    { typeof(DMW.MonthLong), [typeof(DXW.MonthLong)] },
    { typeof(DMW.YearLong), [typeof(DXW.YearLong)] },
    { typeof(DMW.AnnotationReferenceMark), [typeof(DXW.AnnotationReferenceMark)] },
    { typeof(DMW.FootnoteReferenceMark), [typeof(DXW.FootnoteReferenceMark)] },
    { typeof(DMW.EndnoteReferenceMark), [typeof(DXW.EndnoteReferenceMark)] },
    { typeof(DMW.SeparatorMark), [typeof(DXW.SeparatorMark)] },
    { typeof(DMW.ContinuationSeparatorMark), [typeof(DXW.ContinuationSeparatorMark)] },
    { typeof(DMW.PageNumber), [typeof(DXW.PageNumber)] },
    { typeof(DMW.CarriageReturn), [typeof(DXW.CarriageReturn)] },
    { typeof(DMW.TabChar), [typeof(DXW.TabChar)] },
    { typeof(DMW.LastRenderedPageBreak), [typeof(DXW.LastRenderedPageBreak)] },
    { typeof(DMW.FieldChar), [typeof(DXW.FieldChar)] },
    { typeof(DMW.FootnoteReference), [typeof(DXW.FootnoteReference)] },
    { typeof(DMW.EndnoteReference), [typeof(DXW.EndnoteReference)] },
    { typeof(DMW.CommentReference), [typeof(DXW.CommentReference)] },
    { typeof(DMW.EmbeddedObject), [typeof(DXW.EmbeddedObject)] },
    { typeof(DMW.Picture), [typeof(DXW.Picture)] },
    { typeof(DMW.PositionalTab), [typeof(DXW.PositionalTab)] },
    { typeof(DMW.RunProperties), [typeof(DXW.RunProperties)] },
    { typeof(DMW.Ruby), [typeof(DXW.Ruby)] },
    { typeof(DMW.SymbolChar), [typeof(DXW.SymbolChar)] },
    { typeof(DMW.RunText), [typeof(DXW.Text)] },
    { typeof(DMW.DeletedText), [typeof(DXW.DeletedText)] },
    { typeof(DMW.FieldCode), [typeof(DXW.FieldCode)] },
    { typeof(DMW.DeletedFieldCode), [typeof(DXW.DeletedFieldCode)] },
  };

  /// <summary>
  /// Gets the mapping from OpenXml element types to model element types for this collection.
  /// </summary>
  public override Dictionary<Type, Type> OpenXmlElement2ModelTypeMapping => _OpenXmlElement2ModelTypeMapping;

  /// <summary>
  /// Gets the mapping from model element types to OpenXml element types for this collection.
  /// </summary>
  public override Dictionary<Type, Type[]> ModelType2OpenXmlElementsMapping => _ModelType2OpenXmlElementMapping;

  /// <summary>
  /// Checks if the specified item is acceptable for this collection.
  /// </summary>
  /// <param name="item">The item to check.</param>
  /// <returns>True if the item is acceptable; otherwise, false.</returns>
  public override bool AcceptItem(object item)
  {
    return item is not DXW.RunProperties;
  }
}
