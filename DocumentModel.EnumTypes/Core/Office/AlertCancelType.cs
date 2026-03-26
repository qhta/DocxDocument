namespace DocumentMode.Office;

/// <summary>
/// Specifies behavior when the user cancels an alert. Only msoAlertCancelDefault is currently supported.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoalertcanceltype?view=office-pia` for Office interop details.
/// </remarks>
public enum AlertCancelType
{
  /// <summary>
  /// Default behavior for canceling an alert.
  /// </summary>
  Default = -1,
  /// <summary>
  /// Not supported.
  /// </summary>
  First,
  /// <summary>
  /// Not supported.
  /// </summary>
  Second,
  /// <summary>
  /// Not supported.
  /// </summary>
  Third,
  /// <summary>
  /// Not supported.
  /// </summary>
  Fourth,
  /// <summary>
  /// Not supported.
  /// </summary>
  Fifth
}
