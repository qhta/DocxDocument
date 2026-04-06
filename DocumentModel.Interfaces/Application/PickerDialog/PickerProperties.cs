using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of `PickerProperty` objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerproperties?view=office-pia"/>
public partial interface IPickerProperties: IModelCollection<IPickerProperty>
{
}

