namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Protection Class.
/// </summary>
public interface IProtection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  public IChartObject? ChartObject { get ; set; }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  public IData? Data { get ; set; }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  public IFormatting? Formatting { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public ISelection? Selection { get ; set; }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  public IUserInterface? UserInterface { get ; set; }
  
}
