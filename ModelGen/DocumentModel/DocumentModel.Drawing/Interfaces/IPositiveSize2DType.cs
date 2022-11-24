namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public interface IPositiveSize2DType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy { get ; set; }
  
}
