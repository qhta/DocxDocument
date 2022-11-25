namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideViewProperties Class.
/// </summary>
public interface ICommonSlideViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Snap Objects to Grid
  /// </summary>
  public System.Boolean? SnapToGrid { get ; set; }
  
  /// <summary>
  /// Snap Objects to Objects
  /// </summary>
  public System.Boolean? SnapToObjects { get ; set; }
  
  /// <summary>
  /// Show Guides in View
  /// </summary>
  public System.Boolean? ShowGuides { get ; set; }
  
  /// <summary>
  /// Base properties for Slide View.
  /// </summary>
  public DocumentModel.Presentation.ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// List of Guides.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? GuideList { get ; set; }
  
}
