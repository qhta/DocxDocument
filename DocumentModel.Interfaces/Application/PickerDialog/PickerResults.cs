using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of `PickerResult` objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pickerresults?view=office-pia"/>
public partial interface IPickerResults: IModelCollection<IPickerResult>
{
}

