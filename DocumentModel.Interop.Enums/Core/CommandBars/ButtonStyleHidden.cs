
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msobuttonstylehidden?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoButtonStyleHidden")]
public enum ButtonStyleHidden
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoButtonWrapText")]
  WrapText = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoButtonTextBelow")]
  TextBelow = 8
}
