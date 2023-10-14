namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Manual Layout.
/// </summary>
public partial class ManualLayout
{
  
  /// <summary>
  ///   Layout Target.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutTargetKind? LayoutTarget { get; set; }
  
  
  /// <summary>
  ///   Left Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LeftMode? LeftMode { get; set; }
  
  
  /// <summary>
  ///   Top Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.TopMode? TopMode { get; set; }
  
  
  /// <summary>
  ///   Width Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.WidthMode? WidthMode { get; set; }
  
  
  /// <summary>
  ///   Height Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.HeightMode? HeightMode { get; set; }
  
  
  /// <summary>
  ///   Left.
  /// </summary>
  public DocumentModel.Drawings.Charts.Left? Left { get; set; }
  
  
  /// <summary>
  ///   Top.
  /// </summary>
  public DocumentModel.Drawings.Charts.Top? Top { get; set; }
  
  
  /// <summary>
  ///   Width.
  /// </summary>
  public DocumentModel.Drawings.Charts.Width? Width { get; set; }
  
  
  /// <summary>
  ///   Height.
  /// </summary>
  public DocumentModel.Drawings.Charts.Height? Height { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
