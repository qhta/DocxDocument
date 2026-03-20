
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoHiLoLines` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoHiLoLines
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
