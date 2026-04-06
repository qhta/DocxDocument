namespace DocumentModel.Application;

/// <summary>
/// Represents a resolved or selected item of data.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult?view=office-pia"/>
public partial interface IPickerResult: IModelObject
{
  /// <summary>
  /// Gets the unique identifier of the picker result.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the display name of the picker result.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.displayname?view=office-pia"/>
  public string DisplayName { get; }
  /// <summary>
  /// Gets the picker result type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.type?view=office-pia"/>
  public string Type { get; }
  /// <summary>
  /// Gets or sets the Office Communication Server identifier.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.sipid?view=office-pia"/>
  public string SIPId { get; set; }
  /// <summary>
  /// Gets or sets data associated with the picker result.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.itemdata?view=office-pia"/>
  public object ItemData { get; set; }
  /// <summary>
  /// Gets or sets sub-item values associated with the picker result.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.subitems?view=office-pia"/>
  public object SubItems { get; set; }
  /// <summary>
  /// Gets field definitions for picker result sub-items.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.fields?view=office-pia"/>
  public IPickerFields Fields { get; }
  /// <summary>
  /// Gets duplicate candidates when resolution returns multiple matches.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresult.duplicateresults?view=office-pia"/>
  public IPickerResults DuplicateResults { get; }
}

