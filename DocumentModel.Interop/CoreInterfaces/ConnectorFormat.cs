
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat?view=office-pia
/// </remarks>
public partial interface ConnectorFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `BeginConnected` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnected?view=office-pia
  /// </remarks>
  public MsoTriState BeginConnected { get; }
  /// <summary>
  /// Gets the `BeginConnectedShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnectedshape?view=office-pia
  /// </remarks>
  public Shape BeginConnectedShape { get; }
  /// <summary>
  /// Gets the `BeginConnectionSite` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnectionsite?view=office-pia
  /// </remarks>
  public int BeginConnectionSite { get; }
  /// <summary>
  /// Gets the `EndConnected` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnected?view=office-pia
  /// </remarks>
  public MsoTriState EndConnected { get; }
  /// <summary>
  /// Gets the `EndConnectedShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnectedshape?view=office-pia
  /// </remarks>
  public Shape EndConnectedShape { get; }
  /// <summary>
  /// Gets the `EndConnectionSite` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnectionsite?view=office-pia
  /// </remarks>
  public int EndConnectionSite { get; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.type?view=office-pia
  /// </remarks>
  public MsoConnectorType Type { get; set; }
}
