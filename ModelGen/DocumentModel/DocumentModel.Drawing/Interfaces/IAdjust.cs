namespace DocumentModel.Drawing;

/// <summary>
/// Shape Adjust.
/// </summary>
public interface IAdjust // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.Double? Val { get ; set; }
  
}
