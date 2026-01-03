namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ConnectionType interface.
/// </summary>
public interface ConnectionType: IModelElement
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public UInt32? Id { get; set; }
  /// <summary>
  ///   Index
  /// </summary>
  public UInt32? Index { get; set; }
}