namespace DocumentModel.Drawing;

/// <summary>
/// Miter Line Join.
/// </summary>
public interface IMiter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  public Int32? Limit { get ; set; }
  
}
