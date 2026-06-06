using System.Collections;	
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents the `Trendlines` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines?view=office-pia"/>
public interface ITrendlines: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets the trendline at the specified index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.item?view=office-pia"/>
  public ITrendline this[object Index] { get; }	

  #region methods	
/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Order">The `Order` parameter.</param>
  /// <param name="Period">The `Period` parameter.</param>
  /// <param name="Forward">The `Forward` parameter.</param>
  /// <param name="Backward">The `Backward` parameter.</param>
  /// <param name="Intercept">The `Intercept` parameter.</param>
  /// <param name="DisplayEquation">The `DisplayEquation` parameter.</param>
  /// <param name="DisplayRSquared">The `DisplayRSquared` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.add?view=office-pia"/>
  public ITrendline Add
  (TrendlineType Type, object Order, object Period, object Forward, object Backward,
    object Intercept, object DisplayEquation, object DisplayRSquared, object Name);
  /// <summary>
  /// Invokes `GetEnumerator`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.trendlines.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();	
  #endregion methods
}	

