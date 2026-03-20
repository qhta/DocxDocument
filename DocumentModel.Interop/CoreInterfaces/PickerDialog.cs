
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PickerDialog` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PickerDialog: InteropObject
{
  /// <summary>
  /// Gets or sets the `DataHandlerId` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.datahandlerid?view=office-pia
  /// </remarks>
  public string DataHandlerId { get; set; }
  /// <summary>
  /// Gets or sets the `Title` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.title?view=office-pia
  /// </remarks>
  public string Title { get; set; }
  /// <summary>
  /// Gets the `Properties` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerdialog.properties?view=office-pia
  /// </remarks>
  public PickerProperties Properties { get; }
}
