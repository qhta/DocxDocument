namespace DocumentModel.Drawing;

/// <summary>
/// Manual Layout.
/// </summary>
public interface IManualLayout // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout Target.
  /// </summary>
  public DocumentModel.Drawing.LayoutTargetKind? LayoutTarget { get ; set; }
  
  /// <summary>
  /// Left Mode.
  /// </summary>
  public DocumentModel.Drawing.LayoutMode? LeftMode { get ; set; }
  
  /// <summary>
  /// Top Mode.
  /// </summary>
  public DocumentModel.Drawing.LayoutMode? TopMode { get ; set; }
  
  /// <summary>
  /// Width Mode.
  /// </summary>
  public DocumentModel.Drawing.LayoutMode? WidthMode { get ; set; }
  
  /// <summary>
  /// Height Mode.
  /// </summary>
  public DocumentModel.Drawing.LayoutMode? HeightMode { get ; set; }
  
  /// <summary>
  /// Left.
  /// </summary>
  public System.Double? Left { get ; set; }
  
  /// <summary>
  /// Top.
  /// </summary>
  public System.Double? Top { get ; set; }
  
  /// <summary>
  /// Width.
  /// </summary>
  public System.Double? Width { get ; set; }
  
  /// <summary>
  /// Height.
  /// </summary>
  public System.Double? Height { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
