namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Protection Class.
/// </summary>
public interface IProtection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Object.
  /// </summary>
  public Boolean? ChartObject { get ; set; }
  
  /// <summary>
  /// Data Cannot Be Changed.
  /// </summary>
  public Boolean? Data { get ; set; }
  
  /// <summary>
  /// Formatting.
  /// </summary>
  public Boolean? Formatting { get ; set; }
  
  /// <summary>
  /// Selection.
  /// </summary>
  public Boolean? Selection { get ; set; }
  
  /// <summary>
  /// User Interface.
  /// </summary>
  public Boolean? UserInterface { get ; set; }
  
}
