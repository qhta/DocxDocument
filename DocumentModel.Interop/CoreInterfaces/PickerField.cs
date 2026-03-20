
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PickerField` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PickerField: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield.type?view=office-pia
  /// </remarks>
  public MsoPickerField Type { get; }
  /// <summary>
  /// Gets the `IsHidden` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield.ishidden?view=office-pia
  /// </remarks>
  public bool IsHidden { get; }
}
