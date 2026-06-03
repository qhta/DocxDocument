using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of file search criteria.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests?view=office-pia"/>
public partial class PropertyTests: InteropCollection<PropertyTest>
{


  #region methods

/// <summary>
  /// Adds a search criterion to the collection.
  /// </summary>
  /// <param name="name">The name of the search property.</param>
  /// <param name="condition">The condition constant used for the criterion.</param>
  /// <param name="value">The primary value for the condition.</param>
  /// <param name="secondValue">The secondary value for the condition.</param>
  /// <param name="connector">The logical connector to use with subsequent criteria.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.add?view=office-pia"/>
  public void Add (string name, Condition condition, object value, object secondValue, Connector connector) { throw new NotImplementedException(); }
  /// <summary>
  /// Removes a search criterion from the collection.
  /// </summary>
  /// <param name="index">The index of the criterion to remove.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytests.remove?view=office-pia"/>
  public void Remove(int index) { throw new NotImplementedException(); }

  #endregion methods
}

