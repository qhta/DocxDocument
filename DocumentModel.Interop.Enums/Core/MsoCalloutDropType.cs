namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies starting position of the callout line relative to the text bounding box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutdroptype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoCalloutDropType")]
public enum CalloutDropType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [OfficeInteropEnumValue("msoCalloutDropMixed")]
  Mixed = -2,
  /// <summary>
  /// Custom. If this value is used as the value for the PresetDrop property, the Drop and AutoAttach properties of
  /// the CalloutFormat object are used to determine where the callout line attaches to the text box.
  /// </summary>
  [OfficeInteropEnumValue("msoCalloutDropCustom")]
  Custom = 1,
  /// <summary>
  /// Top.
  /// </summary>
  [OfficeInteropEnumValue("msoCalloutDropTop")]
  Top = 2,
  /// <summary>
  /// Center.
  /// </summary>
  [OfficeInteropEnumValue("msoCalloutDropCenter")]
  Center = 3,
  /// <summary>
  /// Bottom.
  /// </summary>
  [OfficeInteropEnumValue("msoCalloutDropBottom")]
  Bottom = 4
}
