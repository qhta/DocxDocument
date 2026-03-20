
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDropLines` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDropLines
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
