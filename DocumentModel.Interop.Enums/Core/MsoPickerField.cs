
namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopickerfield?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoPickerField")]
public enum MsoPickerField
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPickerFieldUnknown")]
  Unknown,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPickerFieldDateTime")]
  DateTime,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPickerFieldNumber")]
  Number,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPickerFieldText")]
  Text,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPickerFieldUser")]
  User,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoPickerFieldMax")]
  Max
}
