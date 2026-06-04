
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstylehidden?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoButtonStyleHidden")]
public enum ButtonStyleHidden
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonWrapText")]
  WrapText = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoButtonTextBelow")]
  TextBelow = 8
}
