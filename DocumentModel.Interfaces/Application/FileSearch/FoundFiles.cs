using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the list of files returned from a file search.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.foundfiles?view=office-pia"/>
public partial interface FoundFiles: IModelValues<string>
{
}

