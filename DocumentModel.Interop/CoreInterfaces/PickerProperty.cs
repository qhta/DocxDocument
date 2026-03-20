namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a custom picker property.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty?view=office-pia
/// </remarks>
public partial interface PickerProperty: InteropObject
{
  /// <summary>
  /// Gets the unique identifier of the picker property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the value of the picker property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty.value?view=office-pia
  /// </remarks>
  public string Value { get; }
  /// <summary>
  /// Gets the type of the picker property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperty.type?view=office-pia
  /// </remarks>
  public MsoPickerField Type { get; }
}
