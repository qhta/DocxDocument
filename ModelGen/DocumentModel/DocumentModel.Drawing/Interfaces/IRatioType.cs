namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RatioType Class.
/// </summary>
public interface IRatioType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Numerator
  /// </summary>
  public System.Int32? Numerator { get ; set; }
  
  /// <summary>
  /// Denominator
  /// </summary>
  public System.Int32? Denominator { get ; set; }
  
}
