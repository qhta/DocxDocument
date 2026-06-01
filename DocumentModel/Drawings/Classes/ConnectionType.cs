namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ConnectionType Class.
/// </summary>
public class ConnectionType: ModelElement
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public UInt32? Id { get; set; }

  /// <summary>
  ///   IIndex
  /// </summary>
  public UInt32? IIndex { get; set; }
}
