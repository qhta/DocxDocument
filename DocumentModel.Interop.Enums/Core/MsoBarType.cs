namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of the command bar.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobartype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoBarType")]
public enum BarType
{
  /// <summary>
  /// Default command bar.
  /// </summary>
  [OfficeInteropEnumValue("msoBarTypeNormal")]
  Normal,
  /// <summary>
  /// Menu bar.
  /// </summary>
  [OfficeInteropEnumValue("msoBarTypeMenuBar")]
  MenuBar,
  /// <summary>
  /// Shortcut menu.
  /// </summary>
  [OfficeInteropEnumValue("msoBarTypePopup")]
  Popup
}
