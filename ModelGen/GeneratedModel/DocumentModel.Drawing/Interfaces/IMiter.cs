namespace DocumentModel.Drawing;

/// <summary>
/// Miter Line Join.
/// </summary>
public interface IMiter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public int? Limit { get ; set; }
  
}
