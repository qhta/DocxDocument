using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides file search functionality.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind?view=office-pia
/// </remarks>
public partial interface IFind
{
  /// <summary>
  /// Displays the Find dialog.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.show?view=office-pia
  /// </remarks>
  public int Show();
  /// <summary>
  /// Executes the file search.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.execute?view=office-pia
  /// </remarks>
  public void Execute();
  /// <summary>
  /// Loads a saved search query.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.load?view=office-pia
  /// </remarks>
  public void Load(string bstrQueryName);
  /// <summary>
  /// Saves the current search query.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.save?view=office-pia
  /// </remarks>
  public void Save(string bstrQueryName);
  /// <summary>
  /// Deletes a saved search query.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.delete?view=office-pia
  /// </remarks>
  public void Delete(string bstrQueryName);
}
