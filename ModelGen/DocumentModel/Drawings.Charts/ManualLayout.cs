namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Manual Layout.
/// </summary>
public partial class ManualLayout
{
  
  /// <summary>
  ///   Layout Target.
  /// </summary>
  public DMDC.LayoutTargetKind? LayoutTarget { get; set; }
  
  
  /// <summary>
  ///   Left Mode.
  /// </summary>
  public DMDC.LeftMode? LeftMode { get; set; }
  
  
  /// <summary>
  ///   Top Mode.
  /// </summary>
  public DMDC.TopMode? TopMode { get; set; }
  
  
  /// <summary>
  ///   Width Mode.
  /// </summary>
  public DMDC.WidthMode? WidthMode { get; set; }
  
  
  /// <summary>
  ///   Height Mode.
  /// </summary>
  public DMDC.HeightMode? HeightMode { get; set; }
  
  
  /// <summary>
  ///   Left.
  /// </summary>
  public DMDC.Left? Left { get; set; }
  
  
  /// <summary>
  ///   Top.
  /// </summary>
  public DMDC.Top? Top { get; set; }
  
  
  /// <summary>
  ///   Width.
  /// </summary>
  public DMDC.Width? Width { get; set; }
  
  
  /// <summary>
  ///   Height.
  /// </summary>
  public DMDC.Height? Height { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
