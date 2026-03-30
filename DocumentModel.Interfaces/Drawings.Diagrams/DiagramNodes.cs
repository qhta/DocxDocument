using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.diagramnodes?view=office-pia"/>
public partial interface IDiagramNodes: IModelCollection<IDiagramNode>
{
}

