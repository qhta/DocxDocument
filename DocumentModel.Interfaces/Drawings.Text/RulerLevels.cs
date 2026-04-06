using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents a collection of ruler outline levels.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2?view=office-pia"/>
public partial interface IRulerLevels: IModelCollection<IRulerLevel>
{
}

