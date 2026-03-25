namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type for a segment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosegmenttype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoSegmentType
{
  /// <summary>
  /// Line.
  /// </summary>
  Line,
  /// <summary>
  /// Curve.
  /// </summary>
  Curve
}
