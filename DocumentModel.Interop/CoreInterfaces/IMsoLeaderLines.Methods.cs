
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoLeaderLines` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoLeaderLines
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
