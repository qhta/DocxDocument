using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PropertyTest` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PropertyTest: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Condition` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.condition?view=office-pia
  /// </remarks>
  public MsoCondition Condition { get; }
  /// <summary>
  /// Gets the `Value` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.value?view=office-pia
  /// </remarks>
  public object Value { get; }
  /// <summary>
  /// Gets the `SecondValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.secondvalue?view=office-pia
  /// </remarks>
  public object SecondValue { get; }
  /// <summary>
  /// Gets the `Connector` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.connector?view=office-pia
  /// </remarks>
  public MsoConnector Connector { get; }
}
