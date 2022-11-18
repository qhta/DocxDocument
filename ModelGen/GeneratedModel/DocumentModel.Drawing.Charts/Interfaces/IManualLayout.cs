namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Manual Layout.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILeft))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITop))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IWidth))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHeight))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILeftMode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITopMode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IWidthMode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHeightMode))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ILayoutTarget))]
public interface IManualLayout // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public DocumentModel.Drawing.Charts.IWidth? Width { get ; set; }
  
  /// <summary>
  /// Height.
  /// </summary>
  public IHeight? Height { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
