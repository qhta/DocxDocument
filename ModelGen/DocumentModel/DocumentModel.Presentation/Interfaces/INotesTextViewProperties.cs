namespace DocumentModel.Presentation;

/// <summary>
/// Notes Text View Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonViewProperties))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface INotesTextViewProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Base properties for Notes View.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
