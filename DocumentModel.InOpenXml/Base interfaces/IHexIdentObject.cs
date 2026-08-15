namespace DocumentModel;

/// <summary>
/// Object that has a unique identifier in the form of a HexInt, allowing for consistent identification and tracking of instances within the system.
/// </summary>
public interface IHexIdentObject
{
  /// <summary>
  /// Gets the unique identifier of the object as a HexInt, which serves as a consistent and unique reference for the instance within the system.
  /// </summary>
  public HexInt? HexId { get;  }
}