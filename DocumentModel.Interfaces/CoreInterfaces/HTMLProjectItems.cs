using System.Collections;
using System.Reflection;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a collection of HTML project items contained in an HTML project.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems?view=office-pia"/>
public partial interface HTMLProjectItems: InteropCollection<HTMLProjectItem>
{
}

