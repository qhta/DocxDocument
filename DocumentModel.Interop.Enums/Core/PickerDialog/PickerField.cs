
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopickerfield?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoPickerField")]
public enum MsoPickerField
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPickerFieldUnknown")]
  Unknown,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPickerFieldDateTime")]
  DateTime,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPickerFieldNumber")]
  Number,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPickerFieldText")]
  Text,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPickerFieldUser")]
  User,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoPickerFieldMax")]
  Max
}
