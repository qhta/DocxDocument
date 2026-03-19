namespace DocumentModel.Interop.Word;

public partial interface ConnectorFormat
{
  /// <summary>
  /// Connects the beginning of the connector to a shape.
  /// </summary>
  /// <param name="ConnectedShape">The shape to which the beginning of the connector is attached.</param>
  /// <param name="ConnectionSite">The connection site index on the target shape.</param>
  public void BeginConnect(Shape ConnectedShape, int ConnectionSite);
}
