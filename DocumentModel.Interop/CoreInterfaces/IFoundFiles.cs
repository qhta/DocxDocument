using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of files returned by a search.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia
/// </remarks>
public partial interface IFoundFiles: IEnumerable
{
  /// <summary>
  /// Gets a found file path by index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.item?view=office-pia
  /// </remarks>
  public string this[int Index] { get; }
  /// <summary>
  /// Gets the number of found files.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.count?view=office-pia
  /// </remarks>
  public int Count { get; }
}
