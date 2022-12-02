namespace DocumentModel.Wordprocessing.Drawing;

/// <summary>
/// Inline Drawing Object Extents.
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
