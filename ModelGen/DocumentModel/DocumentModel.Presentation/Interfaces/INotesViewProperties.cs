namespace DocumentModel.Presentation;

/// <summary>
/// Notes View Properties.
/// </summary>
public interface INotesViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common Slide View Properties.
  /// </summary>
  public ICommonSlideViewProperties? CommonSlideViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
