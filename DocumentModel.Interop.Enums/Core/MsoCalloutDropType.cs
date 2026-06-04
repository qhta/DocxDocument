namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies starting position of the callout line relative to the text bounding box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutdroptype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoCalloutDropType")]
public enum CalloutDropType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoCalloutDropMixed")]
  Mixed = -2,
  /// <summary>
  /// Custom. If this value is used as the value for the PresetDrop property, the Drop and AutoAttach properties of
  /// the CalloutFormat object are used to determine where the callout line attaches to the text box.
  /// </summary>
  [InteropEnumValue("msoCalloutDropCustom")]
  Custom = 1,
  /// <summary>
  /// Top.
  /// </summary>
  [InteropEnumValue("msoCalloutDropTop")]
  Top = 2,
  /// <summary>
  /// Center.
  /// </summary>
  [InteropEnumValue("msoCalloutDropCenter")]
  Center = 3,
  /// <summary>
  /// Bottom.
  /// </summary>
  [InteropEnumValue("msoCalloutDropBottom")]
  Bottom = 4
}
