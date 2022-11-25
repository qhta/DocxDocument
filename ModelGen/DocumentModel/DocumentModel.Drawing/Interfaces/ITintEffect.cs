namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public interface ITintEffect // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public System.Int32? Hue { get ; set; }
  
  /// <summary>
  /// Amount
  /// </summary>
  public System.Int32? Amount { get ; set; }
  
}
