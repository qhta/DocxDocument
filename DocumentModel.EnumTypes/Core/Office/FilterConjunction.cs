namespace DocumentMode.Office;

/// <summary>
/// Specifies how a filter criterion relates to other filter criteria.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilterconjunction?view=office-pia` for Office interop details.
/// </remarks>
public enum FilterConjunction
{
  /// <summary>
  /// And conjunction.
  /// </summary>
  And,
  /// <summary>
  /// Or conjunction.
  /// </summary>
  Or
}
