using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of files returned by a search.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ifoundfiles?view=office-pia"/>
public partial class IFoundFiles: InteropCollection<string>
{
}

