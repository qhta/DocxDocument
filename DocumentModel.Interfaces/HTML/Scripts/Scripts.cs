using System.Collections;
using System.Reflection;

namespace DocumentModel.HTML;

/// <summary>
/// Represents a collection of HTML script blocks in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia"/>
public partial interface IScripts: IModelCollection<IScript>
{
}

