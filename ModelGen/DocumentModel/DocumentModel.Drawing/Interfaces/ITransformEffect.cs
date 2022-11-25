namespace DocumentModel.Drawing;

/// <summary>
/// Transform Effect.
/// </summary>
public interface ITransformEffect // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Ratio
  /// </summary>
  public System.Int32? HorizontalRatio { get ; set; }
  
  /// <summary>
  /// Vertical Ratio
  /// </summary>
  public System.Int32? VerticalRatio { get ; set; }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public System.Int32? HorizontalSkew { get ; set; }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public System.Int32? VerticalSkew { get ; set; }
  
  /// <summary>
  /// Horizontal Shift
  /// </summary>
  public System.Int64? HorizontalShift { get ; set; }
  
  /// <summary>
  /// Vertical Shift
  /// </summary>
  public System.Int64? VerticalShift { get ; set; }
  
}
