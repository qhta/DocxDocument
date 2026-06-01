namespace DocumentModel.IApplication;

/// <summary>
/// Specifies how a filter criterion relates Ito other filter criteria.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilterconjunction?view=office-pia` Ifor Office interop details.
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

