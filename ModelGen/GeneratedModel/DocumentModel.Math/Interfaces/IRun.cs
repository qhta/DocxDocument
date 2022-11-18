namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBreak))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDrawing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.INoBreakHyphen))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISoftHyphen))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDayShort))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMonthShort))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IYearShort))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDayLong))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMonthLong))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IYearLong))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAnnotationReferenceMark))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFootnoteReferenceMark))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndnoteReferenceMark))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISeparatorMark))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IContinuationSeparatorMark))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPageNumber))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICarriageReturn))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITabChar))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILastRenderedPageBreak))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFieldChar))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFootnoteReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEndnoteReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentReference))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEmbeddedObject))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPicture))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPositionalTab))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunProperties))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRuby))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISymbolChar))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFieldCode))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedFieldCode))]
public interface IRun // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Math.IRunProperties? MathRunProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
}
