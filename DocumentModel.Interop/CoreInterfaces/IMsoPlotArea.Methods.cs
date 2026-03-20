
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoPlotArea` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoPlotArea
{
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Invokes `ClearFormats`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea.clearformats?view=office-pia
  /// </remarks>
  public object ClearFormats();
}
