using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IFoundFiles` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IFoundFiles: IEnumerable
{
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.count?view=office-pia
  /// </remarks>
  public string this[int Index] { get; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles.count?view=office-pia
  /// </remarks>
  public int Count { get; }
}
