namespace DocumentModel.Drawing;

/// <summary>
/// Defines the TintEffect Class.
/// </summary>
public interface ITintEffect // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Hue
  /// </summary>
  public int? Hue { get ; set; }
  
  /// <summary>
  /// Amount
  /// </summary>
  public int? Amount { get ; set; }
  
}
