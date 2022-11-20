namespace DocumentModel.Wordprocessing;

/// <summary>
/// Checkbox Form Field Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFormFieldSize))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAutomaticallySizeFormField))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDefaultCheckBoxFormFieldState))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IChecked))]
public interface ICheckBox // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
