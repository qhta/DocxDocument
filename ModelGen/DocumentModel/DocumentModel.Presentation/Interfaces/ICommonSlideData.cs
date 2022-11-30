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
  public DocumentModel.Presentation.IShapeTree? ShapeTree { get ; set; }
  
  /// <summary>
  /// Customer Data List.
  /// </summary>
  public DocumentModel.Presentation.ICustomerDataList? CustomerDataList { get ; set; }
  
  /// <summary>
  /// List of controls.
  /// </summary>
  public DocumentModel.Presentation.IControlList? ControlList { get ; set; }
  
  /// <summary>
  /// CommonSlideDataExtensionList.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideDataExtensionList? CommonSlideDataExtensionList { get ; set; }
  
}
