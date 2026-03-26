using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of file search criteria.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests?view=office-pia"/>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.add?view=office-pia"/>
  public void Add
  (string Name, Condition Condition, object Value, object SecondValue,
    Connector Connector);
  /// <summary>
  /// Removes a search criterion from the collection.
  /// </summary>
  /// <param name="Index">The index of the criterion to remove.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.remove?view=office-pia"/>
  public void Remove(int Index);
}

