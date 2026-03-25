namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of callout line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocallouttype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoCalloutType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Single, horizontal callout line.
  /// </summary>
  One = 1,
  /// <summary>
  /// Single, angled callout line.
  /// </summary>
  Two = 2,
  /// <summary>
  /// Callout line made up of two line segments. Callout line is attached on left side of text bounding box.
  /// </summary>
  Three = 3,
  /// <summary>
  /// Callout line made up of two line segments. Callout line is attached on right side of text bounding box.
  /// </summary>
  Four = 4
}
