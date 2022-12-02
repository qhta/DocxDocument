namespace DocumentModel.Drawing;

/// <summary>
/// Shape Extent.
/// </summary>
public interface IExtent // : DocumentModel.ITypedOpenXmlLeafElement
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
