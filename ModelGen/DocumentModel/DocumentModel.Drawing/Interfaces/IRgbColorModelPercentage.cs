namespace DocumentModel.Drawing;

/// <summary>
/// RGB Color Model - Percentage Variant.
/// </summary>
public interface IRgbColorModelPercentage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Red
  /// </summary>
  public System.Int32? RedPortion { get ; set; }
  
  /// <summary>
  /// Green
  /// </summary>
  public System.Int32? GreenPortion { get ; set; }
  
  /// <summary>
  /// Blue
  /// </summary>
  public System.Int32? BluePortion { get ; set; }
  
}
