namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ConnectionType Class.
/// </summary>
public interface ConnectionType // : System.Boolean
{
  /// <summary>
  /// Identifier
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index { get ; set; }
  
}
