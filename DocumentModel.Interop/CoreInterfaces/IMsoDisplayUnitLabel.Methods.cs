
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDisplayUnitLabel` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDisplayUnitLabel
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.delete?view=office-pia
  /// </remarks>
  public new object Delete();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.select?view=office-pia
  /// </remarks>
  public new object Select();
}
