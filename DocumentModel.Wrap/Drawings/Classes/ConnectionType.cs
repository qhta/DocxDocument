namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  ///   Index
  /// </summary>
  public UInt32? Index { get; set; }
}