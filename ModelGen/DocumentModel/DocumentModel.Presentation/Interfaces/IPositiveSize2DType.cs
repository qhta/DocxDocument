namespace DocumentModel.Presentation;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public interface IPositiveSize2DType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public System.Int64? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public System.Int64? Cy { get ; set; }
  
}
