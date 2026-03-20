using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PropertyTests` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PropertyTests
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="Condition">The `Condition` parameter.</param>
  /// <param name="Value">The `Value` parameter.</param>
  /// <param name="SecondValue">The `SecondValue` parameter.</param>
  /// <param name="Connector">The `Connector` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.add?view=office-pia
  /// </remarks>
  public void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector);
  /// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.remove?view=office-pia
  /// </remarks>
  public void Remove(int Index);
}
