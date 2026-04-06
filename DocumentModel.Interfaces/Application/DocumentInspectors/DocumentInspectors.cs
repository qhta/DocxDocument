using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of DocumentInspector objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentinspectors?view=office-pia"/>
public partial interface IDocumentInspectors: IModelCollection<DocumentInspector>
{
}

