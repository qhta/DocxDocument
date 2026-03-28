namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comparison results.
/// </summary>
[OpenXmlNotMapped]
public enum ComparisonKind
{
  /// <summary>Range is before the other range</summary>
  Before,
  /// <summary>Range is after the other range</summary>
  After,
  /// <summary>Range equals the other range</summary>
  Equal,
  /// <summary>Range contains the other range</summary>
  Contains,
  /// <summary>Range is contained by the other range</summary>
  ContainedBy,
  /// <summary>Range overlaps the other range</summary>
  Overlaps
}