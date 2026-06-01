using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides file search functionality.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind?view=office-pia"/>
public partial class IFind
{
  /// <summary>
  /// Displays the Find dialog.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.show?view=office-pia"/>
  public int Show() { throw new NotImplementedException(); }
  /// <summary>
  /// Executes the file search.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.execute?view=office-pia"/>
  public void Execute() { throw new NotImplementedException(); }
  /// <summary>
  /// Loads a saved search query.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.load?view=office-pia"/>
  public void Load(string bstrQueryName) { throw new NotImplementedException(); }
  /// <summary>
  /// Saves the current search query.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.save?view=office-pia"/>
  public void Save(string bstrQueryName) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes a saved search query.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.delete?view=office-pia"/>
  public void Delete(string bstrQueryName) { throw new NotImplementedException(); }
}

