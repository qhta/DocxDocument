
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PickerDialog` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PickerDialog
{
  /// <summary>
  /// Invokes `CreatePickerResults`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.createpickerresults?view=office-pia
  /// </remarks>
  public PickerResults CreatePickerResults();
  /// <summary>
  /// Invokes `Show`.
  /// </summary>
  /// <param name="IsMultiSelect">The `IsMultiSelect` parameter.</param>
  /// <param name="ExistingResults">The `ExistingResults` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.show?view=office-pia
  /// </remarks>
  public PickerResults Show(bool IsMultiSelect, PickerResults ExistingResults);
  /// <summary>
  /// Invokes `Resolve`.
  /// </summary>
  /// <param name="TokenText">The `TokenText` parameter.</param>
  /// <param name="duplicateDlgMode">The `duplicateDlgMode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.resolve?view=office-pia
  /// </remarks>
  public PickerResults Resolve(string TokenText, int duplicateDlgMode);
}
