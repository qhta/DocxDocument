using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of file search criteria.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests?view=office-pia
/// </remarks>
public partial interface PropertyTests
{
  /// <summary>
  /// Adds a search criterion to the collection.
  /// </summary>
  /// <param name="Name">The name of the search property.</param>
  /// <param name="Condition">The condition constant used for the criterion.</param>
  /// <param name="Value">The primary value for the condition.</param>
  /// <param name="SecondValue">The secondary value for the condition.</param>
  /// <param name="Connector">The logical connector to use with subsequent criteria.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.add?view=office-pia
  /// </remarks>
  public void Add
  (string Name, MsoCondition Condition, object Value, object SecondValue,
    MsoConnector Connector);
  /// <summary>
  /// Removes a search criterion from the collection.
  /// </summary>
  /// <param name="Index">The index of the criterion to remove.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.remove?view=office-pia
  /// </remarks>
  public void Remove(int Index);
}
