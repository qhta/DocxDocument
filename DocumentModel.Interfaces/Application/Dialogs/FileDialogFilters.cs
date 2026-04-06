using System.Collections;
using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// A collection of FileDialogFilter objects used by a FileDialog.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters?view=office-pia"/>
public partial interface IFileDialogFilters: IModelCollection<IFileDialogFilter>
{
}

