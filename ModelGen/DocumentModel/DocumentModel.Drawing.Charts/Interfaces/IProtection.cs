namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Protection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartObject))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IData))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormatting))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ISelection))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IUserInterface))]
public interface IProtection // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  public IChartObject? ChartObject { get ; set; }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  public DocumentModel.Drawing.Charts.IData? Data { get ; set; }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  public IFormatting? Formatting { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public DocumentModel.Drawing.Charts.ISelection? Selection { get ; set; }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  public IUserInterface? UserInterface { get ; set; }
  
}
