namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public partial interface ManualLayout
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutTargetKind? LayoutTarget { get; set; }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? LeftMode { get; set; }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? TopMode { get; set; }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? WidthMode { get; set; }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  public DocumentModel.Drawings.Charts.LayoutMode? HeightMode { get; set; }
  
  /// <summary>
  /// Left.
  /// </summary>
  public Double? Left { get; set; }
  
  /// <summary>
  /// Top.
  /// </summary>
  public Double? Top { get; set; }
  
  /// <summary>
  /// Width.
  /// </summary>
  public Double? Width { get; set; }
  
  /// <summary>
  /// Height.
  /// </summary>
  public Double? Height { get; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
