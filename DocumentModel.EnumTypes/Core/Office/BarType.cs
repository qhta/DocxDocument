namespace DocumentMode.Office;

/// <summary>
/// Specifies the type of the command bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobartype?view=office-pia` for Office interop details.
/// </remarks>
public enum BarType
{
  /// <summary>
  /// Default command bar.
  /// </summary>
  Normal,
  /// <summary>
  /// Menu bar.
  /// </summary>
  MenuBar,
  /// <summary>
  /// Shortcut menu.
  /// </summary>
  Popup
}
