namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public interface ITintEffect // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public Int32? Hue { get ; set; }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount { get ; set; }
  
}
