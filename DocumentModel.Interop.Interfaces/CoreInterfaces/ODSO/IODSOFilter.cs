
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents a filter applied to an attached mail merge data source.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter?view=office-pia"/>
public interface IODSOFilter: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets or sets the `Column` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.column?view=office-pia"/>
  public string Column { get; set; }
  /// <summary>
  /// Gets or sets the `Comparison` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.comparison?view=office-pia"/>
  public FilterComparison Comparison { get; set; }
  /// <summary>
  /// Gets or sets the `CompareTo` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.compareto?view=office-pia"/>
  public string CompareTo { get; set; }
  /// <summary>
  /// Gets or sets the `Conjunction` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.odsofilter.conjunction?view=office-pia"/>
  public FilterConjunction Conjunction { get; set; }
}	
