namespace DocumentModel.Presentation;

/// <summary>
/// Outline View Properties.
/// </summary>
public interface IOutlineViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common View Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// List of Presentation Slides.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OutlineViewSlideList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
