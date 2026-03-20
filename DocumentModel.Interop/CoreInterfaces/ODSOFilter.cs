
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ODSOFilter` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ODSOFilter: InteropObject
{
  /// <summary>
  /// Gets or sets the `Index` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.index?view=office-pia
  /// </remarks>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the `Column` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.column?view=office-pia
  /// </remarks>
  public string Column { get; set; }
  /// <summary>
  /// Gets or sets the `Comparison` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.comparison?view=office-pia
  /// </remarks>
  public MsoFilterComparison Comparison { get; set; }
  /// <summary>
  /// Gets or sets the `CompareTo` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.compareto?view=office-pia
  /// </remarks>
  public string CompareTo { get; set; }
  /// <summary>
  /// Gets or sets the `Conjunction` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.conjunction?view=office-pia
  /// </remarks>
  public MsoFilterConjunction Conjunction { get; set; }
}
