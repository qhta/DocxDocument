namespace DocumentModel.Presentation;

/// <summary>
/// Common slide data for notes slides.
/// </summary>
public interface ICommonSlideData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Slide Background.
  /// </summary>
  public DocumentModel.Presentation.IBackground? Background { get ; set; }
  
  /// <summary>
  /// Shape Tree.
  /// </summary>
  public DocumentModel.Presentation.IGroupShapeType? ShapeTree { get ; set; }
  
  /// <summary>
  /// Customer Data List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CustomerDataList { get ; set; }
  
  /// <summary>
  /// List of controls.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ControlList { get ; set; }
  
  /// <summary>
  /// CommonSlideDataExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CommonSlideDataExtensionList { get ; set; }
  
}
