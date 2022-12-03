namespace DocumentModel.Presentation;

/// <summary>
/// Common slide data for notes slides.
/// </summary>
public interface CommonSlideData // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Slide Background.
  /// </summary>
  public Background? Background { get ; set; }
  
  /// <summary>
  /// Shape Tree.
  /// </summary>
  public ShapeTree? ShapeTree { get ; set; }
  
  /// <summary>
  /// Customer Data List.
  /// </summary>
  public CustomerDataList? CustomerDataList { get ; set; }
  
  /// <summary>
  /// List of controls.
  /// </summary>
  public ControlList? ControlList { get ; set; }
  
  /// <summary>
  /// CommonSlideDataExtensionList.
  /// </summary>
  public CommonSlideDataExtensionList? CommonSlideDataExtensionList { get ; set; }
  
}
