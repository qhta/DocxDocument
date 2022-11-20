namespace DocumentModel.Presentation;

/// <summary>
/// Common slide data for notes slides.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IBackground))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideDataExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IControlList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomerDataList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShapeTree))]
public interface ICommonSlideData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name { get ; set; }
  
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
