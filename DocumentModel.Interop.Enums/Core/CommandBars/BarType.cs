namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobartype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoBarType")]
public enum BarType
{
  /// <summary>
  /// Default command bar.
  /// </summary>
  [InteropEnumValue("msoBarTypeNormal")]
  Normal,
  /// <summary>
  /// Menu bar.
  /// </summary>
  [InteropEnumValue("msoBarTypeMenuBar")]
  MenuBar,
  /// <summary>
  /// Shortcut menu.
  /// </summary>
  [InteropEnumValue("msoBarTypePopup")]
  Popup
}
