namespace DocumentModel.Wordprocessing;

/// <summary>
/// Form Field Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICheckBox))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDropDownListFormField))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IHelpText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IFormFieldName))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IStatusText))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITextInput))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEntryMacro))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IExitMacro))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IEnabled))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICalculateOnExit))]
public interface IFormFieldData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
}
