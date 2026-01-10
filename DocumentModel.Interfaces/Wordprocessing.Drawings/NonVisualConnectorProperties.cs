using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents non-visual properties for connector shapes in a Wordprocessing document.
/// This interface provides access to connection locks, start and end connection information, and extension data for connectors.
/// </summary>
public interface NonVisualConnectorProperties : ExtendableElement
{
  /// <summary>
  /// The set of locks applied to the connector shape, restricting certain types of modifications or interactions.
  /// </summary>
  public ConnectionShapeLocks? ConnectionShapeLocks { get; set; }

  /// <summary>
  /// The definition of the starting connection point for the connector, specifying how it attaches to other shapes.
  /// </summary>
  public ConnectionType? StartConnection { get; set; }

  /// <summary>
  /// The definition of the ending connection point for the connector, specifying how it attaches to other shapes.
  /// </summary>
  public ConnectionType? EndConnection { get; set; }
}