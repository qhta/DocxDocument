namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether the command bar combo box includes a label or not.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocombostyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoComboStyle))]
public enum ComboStyle
{
  /// <summary>
  /// Combo box does not include a label.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoComboStyle.msoComboNormal))]
  Normal,
  /// <summary>
  /// Combo box includes a label, specified by the Caption property of the combo box.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoComboStyle.msoComboLabel))]
  Label
}
