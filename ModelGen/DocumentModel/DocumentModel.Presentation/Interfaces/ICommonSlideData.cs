namespace DocumentModel.Presentation;

/// <summary>
/// Common slide data for notes slides.
/// </summary>
public interface ICommonSlideData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Slide Background.
  /// </summary>
  public IBackground? Background { get ; set; }
  
  /// <summary>
  /// Shape Tree.
  /// </summary>
  public IShapeTree? ShapeTree { get ; set; }
  
  /// <summary>
  /// Customer Data List.
  /// </summary>
  public ICustomerDataList? CustomerDataList { get ; set; }
  
  /// <summary>
  /// List of controls.
  /// </summary>
  public IControlList? ControlList { get ; set; }
  
  /// <summary>
  /// CommonSlideDataExtensionList.
  /// </summary>
  public ICommonSlideDataExtensionList? CommonSlideDataExtensionList { get ; set; }
  
}
