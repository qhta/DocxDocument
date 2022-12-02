namespace DocumentModel.Drawing;

/// <summary>
/// Shape Extent.
/// </summary>
public interface IExtent // : DocumentModel.ITypedOpenXmlLeafElement
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
