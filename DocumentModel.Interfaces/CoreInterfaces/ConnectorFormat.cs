
namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat?view=office-pia"/>
public partial interface ConnectorFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `BeginConnected` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnected?view=office-pia"/>
  public MsoTriState BeginConnected { get; }
  /// <summary>
  /// Gets the `BeginConnectedShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnectedshape?view=office-pia"/>
  public Shape BeginConnectedShape { get; }
  /// <summary>
  /// Gets the `BeginConnectionSite` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnectionsite?view=office-pia"/>
  public int BeginConnectionSite { get; }
  /// <summary>
  /// Gets the `EndConnected` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnected?view=office-pia"/>
  public MsoTriState EndConnected { get; }
  /// <summary>
  /// Gets the `EndConnectedShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnectedshape?view=office-pia"/>
  public Shape EndConnectedShape { get; }
  /// <summary>
  /// Gets the `EndConnectionSite` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnectionsite?view=office-pia"/>
  public int EndConnectionSite { get; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.type?view=office-pia"/>
  public MsoConnectorType Type { get; set; }
}

