namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ConnectionType Class.
/// </summary>
public interface IConnectionType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Identifier
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Index
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
}
