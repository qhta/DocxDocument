using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single file search criterion.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest?view=office-pia
/// </remarks>
public partial interface PropertyTest: InteropObject
{
  /// <summary>
  /// Gets the name of the search property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the condition used for the search criterion.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.condition?view=office-pia
  /// </remarks>
  public MsoCondition Condition { get; }
  /// <summary>
  /// Gets the primary value used by the condition.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.value?view=office-pia
  /// </remarks>
  public object Value { get; }
  /// <summary>
  /// Gets the secondary value used by the condition.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.secondvalue?view=office-pia
  /// </remarks>
  public object SecondValue { get; }
  /// <summary>
  /// Gets the logical connector used with the next criterion.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.connector?view=office-pia
  /// </remarks>
  public MsoConnector Connector { get; }
}
