
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a field definition for picker result sub-items.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield?view=office-pia"/>
public interface IPickerField: IInteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield.type?view=office-pia"/>
  public PickerField Type { get; }
  /// <summary>
  /// Gets the `IsHidden` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerfield.ishidden?view=office-pia"/>
  public bool IsHidden { get; }
}

