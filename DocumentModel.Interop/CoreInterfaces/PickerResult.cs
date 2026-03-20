namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a resolved or selected item of data.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult?view=office-pia
/// </remarks>
public partial interface PickerResult: InteropObject
{
  /// <summary>
  /// Gets the unique identifier of the picker result.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the display name of the picker result.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.displayname?view=office-pia
  /// </remarks>
  public string DisplayName { get; }
  /// <summary>
  /// Gets the picker result type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.type?view=office-pia
  /// </remarks>
  public string Type { get; }
  /// <summary>
  /// Gets or sets the Office Communication Server identifier.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.sipid?view=office-pia
  /// </remarks>
  public string SIPId { get; set; }
  /// <summary>
  /// Gets or sets data associated with the picker result.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.itemdata?view=office-pia
  /// </remarks>
  public object ItemData { get; set; }
  /// <summary>
  /// Gets or sets sub-item values associated with the picker result.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.subitems?view=office-pia
  /// </remarks>
  public object SubItems { get; set; }
  /// <summary>
  /// Gets field definitions for picker result sub-items.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.fields?view=office-pia
  /// </remarks>
  public PickerFields Fields { get; }
  /// <summary>
  /// Gets duplicate candidates when resolution returns multiple matches.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.duplicateresults?view=office-pia
  /// </remarks>
  public PickerResults DuplicateResults { get; }
}
