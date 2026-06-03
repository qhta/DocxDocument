namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat?view=word-pia"/>
public partial class ConnectorFormat : InteropObject
{
  /// <summary>
  /// Gets a value indicating whether the beginning of the connector is attached to a shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnected?view=word-pia"/>
  public Core.TriState BeginConnected { get; set; }

  /// <summary>
  /// Gets the shape attached to the beginning of the connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnectedshape?view=word-pia"/>
  public Shape BeginConnectedShape { get; set; }

  /// <summary>
  /// Gets the connection site on the shape where the beginning of the connector is attached.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnectionsite?view=word-pia"/>
  public int BeginConnectionSite { get; set; }

  /// <summary>
  /// Gets a value indicating whether the end of the connector is attached to a shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnected?view=word-pia"/>
  public Core.TriState EndConnected { get; set; }

  /// <summary>
  /// Gets the shape attached to the end of the connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnectedshape?view=word-pia"/>
  public Shape EndConnectedShape { get; set; }

  /// <summary>
  /// Gets the connection site on the shape where the end of the connector is attached.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnectionsite?view=word-pia"/>
  public int EndConnectionSite { get; set; }

  /// <summary>
  /// Gets or sets the connector type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.type?view=word-pia"/>
  public Core.ConnectorType Type { get; set; }


  #region methods

/// <summary>
  /// Connects the beginning of the connector to a shape.
  /// </summary>
  /// <param name="connectedShape">The shape to which the beginning of the connector is attached.</param>
  /// <param name="connectionSite">The connection site index on the target shape.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnect?view=word-pia"/>
  public void BeginConnect(Shape connectedShape, int connectionSite) { throw new NotImplementedException(); }

  #endregion methods
}
