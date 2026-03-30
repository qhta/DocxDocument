using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia"/>
public partial interface IPickerProperties: IModelCollection<IPickerProperty>
{
}

