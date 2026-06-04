namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how a filter criterion relates to other filter criteria.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilterconjunction?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFilterConjunction))]
public enum FilterConjunction
{
  /// <summary>
  /// And conjunction.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterConjunction.msoFilterConjunctionAnd))]
  And,
  /// <summary>
  /// Or conjunction.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFilterConjunction.msoFilterConjunctionOr))]
  Or
}
