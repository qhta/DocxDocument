namespace DocumentModel.Presentation;

/// <summary>
/// Notes View Properties.
/// </summary>
public interface INotesViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common Slide View Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideViewProperties? CommonSlideViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
