namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat?view=word-pia"/>
public partial class ConnectorFormat
{
  /// <summary>
  /// Connects the beginning of the connector to a shape.
  /// </summary>
  /// <param name="ConnectedShape">The shape to which the beginning of the connector is attached.</param>
  /// <param name="ConnectionSite">The connection site index on the target shape.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnect?view=word-pia"/>
  public void BeginConnect(Shape ConnectedShape, int ConnectionSite) { throw new NotImplementedException(); }
}
