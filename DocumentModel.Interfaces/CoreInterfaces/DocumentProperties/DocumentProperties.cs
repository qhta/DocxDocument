using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// A collection of DocumentProperty objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties?view=office-pia"/>
public partial interface DocumentProperties: InteropCollection<DocumentProperty>
{
}

