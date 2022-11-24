namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommonSlideViewProperties Class.
/// </summary>
public interface ICommonSlideViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Snap Objects to Grid
  /// </summary>
  public Boolean? SnapToGrid { get ; set; }
  
  /// <summary>
  /// Snap Objects to Objects
  /// </summary>
  public Boolean? SnapToObjects { get ; set; }
  
  /// <summary>
  /// Show Guides in View
  /// </summary>
  public Boolean? ShowGuides { get ; set; }
  
  /// <summary>
  /// Base properties for Slide View.
  /// </summary>
  public ICommonViewProperties? CommonViewProperties { get ; set; }
  
  /// <summary>
  /// List of Guides.
  /// </summary>
  public IGuideList? GuideList { get ; set; }
  
}
