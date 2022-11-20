namespace DocumentModel.Bibliography;

/// <summary>
/// Person.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.ILast))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IFirst))]
[ChildElementInfo(typeof(DocumentModel.Bibliography.IMiddle))]
public interface IPerson // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
