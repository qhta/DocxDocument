namespace DocumentModel.Drawings;

/// <summary>
/// Manual Layout.
/// </summary>
public interface ManualLayout
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  public LayoutTargetKind? LayoutTarget { get ; set; }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  public LayoutMode? LeftMode { get ; set; }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  public LayoutMode? TopMode { get ; set; }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  public LayoutMode? WidthMode { get ; set; }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  public LayoutMode? HeightMode { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList { get ; set; }
  
}
