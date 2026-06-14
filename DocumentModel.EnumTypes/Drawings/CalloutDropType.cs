namespace DocumentModel.Drawings;

/// <summary>
/// Specifies starting position of the callout line relative to the text bounding box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutdroptype?view=office-pia` for Office interop details.
/// </remarks>
public enum CalloutDropType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  /// <summary>
  /// Custom. If this value is used as the value for the PresetDrop property, the Drop and AutoAttach properties of
  /// the ICalloutFormat object are used to determine where the callout line attaches to the text box.
  /// </summary>
  Custom = 1,
  /// <summary>
  /// Top.
  /// </summary>
  Top = 2,
  /// <summary>
  /// Center.
  /// </summary>
  Center = 3,
  /// <summary>
  /// Bottom.
  /// </summary>
  Bottom = 4
}

