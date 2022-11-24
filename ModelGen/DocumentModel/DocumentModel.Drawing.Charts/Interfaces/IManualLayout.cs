namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
public interface IManualLayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  public ILayoutTarget? LayoutTarget { get ; set; }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  public ILeftMode? LeftMode { get ; set; }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  public ITopMode? TopMode { get ; set; }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  public IWidthMode? WidthMode { get ; set; }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  public IHeightMode? HeightMode { get ; set; }
  
  /// <summary>
  /// Left.
  /// </summary>
  public ILeft? Left { get ; set; }
  
  /// <summary>
  /// Top.
  /// </summary>
  public ITop? Top { get ; set; }
  
  /// <summary>
  /// Width.
  /// </summary>
  public IWidth? Width { get ; set; }
  
  /// <summary>
  /// Height.
  /// </summary>
  public IHeight? Height { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
