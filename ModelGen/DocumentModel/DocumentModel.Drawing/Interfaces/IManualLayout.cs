namespace DocumentModel.Drawing;

/// <summary>
/// Manual Layout.
/// </summary>
public interface IManualLayout // : DocumentModel.ITypedOpenXmlCompositeElement
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
  /// Left.
  /// </summary>
  public Double? Left { get ; set; }
  
  /// <summary>
  /// Top.
  /// </summary>
  public Double? Top { get ; set; }
  
  /// <summary>
  /// Width.
  /// </summary>
  public Double? Width { get ; set; }
  
  /// <summary>
  /// Height.
  /// </summary>
  public Double? Height { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
