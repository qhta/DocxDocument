namespace DocumentModel.Presentation;

/// <summary>
/// Customer Data List.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomerData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomerDataTags))]
public interface ICustomerDataList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
