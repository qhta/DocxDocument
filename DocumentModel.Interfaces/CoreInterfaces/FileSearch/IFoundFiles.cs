using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of files returned by a search.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia"/>
public partial interface IFoundFiles: IEnumerable
{
  /// <summary>
  /// Gets a found file path by index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.item?view=office-pia"/>
  public string this[int Index] { get; }
  /// <summary>
  /// Gets the number of found files.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.count?view=office-pia"/>
  public int Count { get; }
}

