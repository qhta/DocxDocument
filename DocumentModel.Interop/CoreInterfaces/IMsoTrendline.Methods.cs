
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoTrendline` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoTrendline
{
  /// <summary>
  /// Invokes `ClearFormats`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsotrendline.select?view=office-pia
  /// </remarks>
  public object Select();
}
