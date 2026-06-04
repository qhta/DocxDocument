namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of callout line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocallouttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoCalloutType")]
public enum CalloutType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  [InteropEnumValue("msoCalloutMixed")]
  Mixed = -2,
  /// <summary>
  /// Single, horizontal callout line.
  /// </summary>
  [InteropEnumValue("msoCalloutOne")]
  One = 1,
  /// <summary>
  /// Single, angled callout line.
  /// </summary>
  [InteropEnumValue("msoCalloutTwo")]
  Two = 2,
  /// <summary>
  /// Callout line made up of two line segments. Callout line is attached on left side of text bounding box.
  /// </summary>
  [InteropEnumValue("msoCalloutThree")]
  Three = 3,
  /// <summary>
  /// Callout line made up of two line segments. Callout line is attached on right side of text bounding box.
  /// </summary>
  [InteropEnumValue("msoCalloutFour")]
  Four = 4
}
