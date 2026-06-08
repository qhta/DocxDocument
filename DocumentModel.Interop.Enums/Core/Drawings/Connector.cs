
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the connector between two similar property test values.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnector?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoConnector")]
public enum Connector
{
  /// <summary>
  /// Combine property test values to form one property test.
  /// </summary>
  [InteropEnumValue("msoConnectorAnd")]
  And = 1,
  /// <summary>
  /// Treat property test values as separate criteria.
  /// </summary>
  [InteropEnumValue("msoConnectorOr")]
  Or
}
