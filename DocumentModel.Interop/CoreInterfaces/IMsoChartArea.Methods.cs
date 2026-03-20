
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoChartArea` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoChartArea
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `Clear`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clear?view=office-pia
  /// </remarks>
  public object Clear();
  /// <summary>
  /// Invokes `ClearContents`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clearcontents?view=office-pia
  /// </remarks>
  public object ClearContents();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.copy?view=office-pia
  /// </remarks>
  public object Copy();
  /// <summary>
  /// Invokes `ClearFormats`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsochartarea.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
}
