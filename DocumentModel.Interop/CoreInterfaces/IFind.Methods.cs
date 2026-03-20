using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IFind` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IFind
{
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.show?view=office-pia
  /// </remarks>
  public int Show();
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.execute?view=office-pia
  /// </remarks>
  public void Execute();
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.load?view=office-pia
  /// </remarks>
  public void Load(string bstrQueryName);
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.save?view=office-pia
  /// </remarks>
  public void Save(string bstrQueryName);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="bstrQueryName">The `bstrQueryName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifind.delete?view=office-pia
  /// </remarks>
  public void Delete(string bstrQueryName);
}
