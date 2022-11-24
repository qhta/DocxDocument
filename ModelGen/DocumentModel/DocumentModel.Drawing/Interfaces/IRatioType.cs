namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RatioType Class.
/// </summary>
public interface IRatioType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Numerator
  /// </summary>
  public Int32? Numerator { get ; set; }
  
  /// <summary>
  /// Denominator
  /// </summary>
  public Int32? Denominator { get ; set; }
  
}
