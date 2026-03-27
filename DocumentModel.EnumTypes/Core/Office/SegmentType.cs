namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the type for a segment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosegmenttype?view=office-pia` for Office interop details.
/// </remarks>
public enum SegmentType
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
