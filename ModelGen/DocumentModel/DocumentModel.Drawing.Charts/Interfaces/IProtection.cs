namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Protection Class.
/// </summary>
public interface IProtection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  public System.Boolean? ChartObject { get ; set; }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  public System.Boolean? Data { get ; set; }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  public System.Boolean? Formatting { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public System.Boolean? Selection { get ; set; }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  public System.Boolean? UserInterface { get ; set; }
  
}
