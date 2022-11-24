namespace DocumentModel.Presentation;

/// <summary>
/// Notes Text View Properties.
/// </summary>
public interface INotesTextViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Base properties for Notes View.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
