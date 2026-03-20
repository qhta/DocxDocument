
namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides dialog UI functionality for picking people or data.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog?view=office-pia
/// </remarks>
public partial interface PickerDialog
{
  /// <summary>
  /// Creates an empty `PickerResults` object.
  /// </summary>
  /// <returns>The created picker results collection.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.createpickerresults?view=office-pia
  /// </remarks>
  public PickerResults CreatePickerResults();
  /// <summary>
  /// Displays the picker dialog with the specified options.
  /// </summary>
  /// <param name="IsMultiSelect">The `IsMultiSelect` parameter.</param>
  /// <param name="ExistingResults">The `ExistingResults` parameter.</param>
  /// <returns>The selected picker results.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.show?view=office-pia
  /// </remarks>
  public PickerResults Show(bool IsMultiSelect, PickerResults ExistingResults);
  /// <summary>
  /// Resolves a token and returns matching picker results.
  /// </summary>
  /// <param name="TokenText">The `TokenText` parameter.</param>
  /// <param name="duplicateDlgMode">The `duplicateDlgMode` parameter.</param>
  /// <returns>The resolved picker results.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.resolve?view=office-pia
  /// </remarks>
  public PickerResults Resolve(string TokenText, int duplicateDlgMode);
}
