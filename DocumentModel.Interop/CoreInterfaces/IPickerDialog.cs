
namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides dialog UI functionality for picking people or data.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog?view=office-pia"/>
public interface IPickerDialog : IInteropObject
{
  /// <summary>
  /// Gets or sets the `DataHandlerId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.datahandlerid?view=office-pia"/>
  public string DataHandlerId { get; set; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.title?view=office-pia"/>
  public string Title { get; set; }
  /// <summary>
  /// Gets the `Properties` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.properties?view=office-pia"/>
  public IPickerProperties Properties { get; }


  #region methods

  /// <summary>
  /// Creates an empty `PickerResults` object.
  /// </summary>
  /// <returns>The created picker results collection.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.createpickerresults?view=office-pia"/>
  public IPickerResults CreatePickerResults();
  /// <summary>
  /// Displays the picker dialog with the specified options.
  /// </summary>
  /// <param name="isMultiSelect">The `IsMultiSelect` parameter.</param>
  /// <param name="existingResults">The `ExistingResults` parameter.</param>
  /// <returns>The selected picker results.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.show?view=office-pia"/>
  public IPickerResults Show(bool isMultiSelect, IPickerResults existingResults);
  /// <summary>
  /// Resolves a token and returns matching picker results.
  /// </summary>
  /// <param name="tokenText">The `TokenText` parameter.</param>
  /// <param name="duplicateDlgMode">The `duplicateDlgMode` parameter.</param>
  /// <returns>The resolved picker results.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.resolve?view=office-pia"/>
  public IPickerResults Resolve(string tokenText, int duplicateDlgMode);

  #endregion methods
}

