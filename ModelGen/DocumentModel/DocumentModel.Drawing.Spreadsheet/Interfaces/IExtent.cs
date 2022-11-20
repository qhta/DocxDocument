namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Defines the Extent Class.
/// </summary>
public interface IExtent // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public long? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public long? Cy { get ; set; }
  
}
