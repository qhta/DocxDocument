namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom picker property.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty?view=office-pia"/>
public partial class PickerProperty: InteropObject
{
  /// <summary>
  /// Gets the unique identifier of the picker property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the value of the picker property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty.value?view=office-pia"/>
  public string Value { get; }
  /// <summary>
  /// Gets the type of the picker property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty.type?view=office-pia"/>
  public PickerField Type { get; }
}

