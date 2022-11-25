namespace DocumentModel.Presentation;

/// <summary>
/// Notes Text View Properties.
/// </summary>
public interface INotesTextViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Base properties for Notes View.
  /// </summary>
  public DocumentModel.Presentation.ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
