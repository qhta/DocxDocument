namespace DocumentModel.Presentation;

/// <summary>
/// Slide View Properties.
/// </summary>
public interface ISlideViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommonSlideViewProperties.
  /// </summary>
  public ICommonSlideViewProperties? CommonSlideViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
