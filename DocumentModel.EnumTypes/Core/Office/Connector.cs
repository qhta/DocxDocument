
namespace DocumentMode.Office;

/// <summary>
/// Specifies the connector between two similar property test values.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoconnector?view=office-pia` for Office interop details.
/// </remarks>
public enum Connector
{
  /// <summary>
  /// Combine property test values to form one property test.
  /// </summary>
  And = 1,
  /// <summary>
  /// Treat property test values as separate criteria.
  /// </summary>
  Or
}
