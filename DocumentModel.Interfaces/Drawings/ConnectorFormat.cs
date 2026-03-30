namespace DocumentModel.Drawings;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat?view=word-pia"/>
public partial interface ConnectorFormat : IModelObject
{
  /// <summary>
  /// Gets a value indicating whether the beginning of the connector is attached to a shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnected?view=word-pia"/>
  public TriState BeginConnected { get; }

  /// <summary>
  /// Gets the shape attached to the beginning of the connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnectedshape?view=word-pia"/>
  public Shape BeginConnectedShape { get; }

  /// <summary>
  /// Gets the connection site on the shape where the beginning of the connector is attached.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnectionsite?view=word-pia"/>
  public int BeginConnectionSite { get; }

  /// <summary>
  /// Gets a value indicating whether the end of the connector is attached to a shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnected?view=word-pia"/>
  public TriState EndConnected { get; }

  /// <summary>
  /// Gets the shape attached to the end of the connector.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnectedshape?view=word-pia"/>
  public Shape EndConnectedShape { get; }

  /// <summary>
  /// Gets the connection site on the shape where the end of the connector is attached.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnectionsite?view=word-pia"/>
  public int EndConnectionSite { get; }

  /// <summary>
  /// Gets or sets the connector type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.type?view=word-pia"/>
  public Drw.ConnectorType Type { get; set; }
}
