namespace DocumentModel.Presentation;

/// <summary>
/// Outline View Properties.
/// </summary>
public interface IOutlineViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Common View Properties.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// List of Presentation Slides.
  /// </summary>
  public IOutlineViewSlideList? OutlineViewSlideList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
