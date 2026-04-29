namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Run items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
public class RunItemsCollection: ContentItemsCollection<ModelElement>
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
  /// Static mapping between OpenXml element types and their corresponding model element types. This bidirectional dictionary allows for easy conversion and lookup between the two type systems, facilitating the loading and updating of model elements based on their OpenXml representations.
  /// </summary>
  private static readonly BiDiDictionary<Type, Type> _ModelElementTypeMapping = new()
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
    { typeof(DXW.Text), typeof(DMW.Text) },
    { typeof(DXW.DeletedText), typeof(DMW.DeletedText) },
    { typeof(DXW.FieldCode), typeof(DMW.FieldCode) },
    { typeof(DXW.DeletedFieldCode), typeof(DMW.DeletedFieldCode) },
  };
  /// <summary>
  /// Gets the mapping between model element types and their corresponding mapped types.  
  /// </summary>
  /// <remarks>This property provides a bidirectional dictionary that associates each model element type with
  /// its mapped type. The mapping enables conversion or lookup operations between the two type systems, which is useful
  /// for scenarios such as serialization, deserialization, or type resolution in modeling frameworks.</remarks>
  public override BiDiDictionary<Type, Type> ModelElementTypeMapping => _ModelElementTypeMapping;

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
