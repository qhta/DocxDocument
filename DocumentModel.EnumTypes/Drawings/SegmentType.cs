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
  /// ILine.
  /// </summary>
  ILine,
  /// <summary>
  /// Curve.
  /// </summary>
  Curve
}

