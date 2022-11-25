namespace DocumentModel.Presentation;

/// <summary>
/// Slide View Properties.
/// </summary>
public interface ISlideViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommonSlideViewProperties.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideViewProperties? CommonSlideViewProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
