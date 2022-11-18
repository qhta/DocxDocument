namespace DocumentModel.Math;

/// <summary>
/// Control Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsertedMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveFromMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IMoveToMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunProperties))]
public interface IControlProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
