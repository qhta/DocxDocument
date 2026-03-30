using System.Collections;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a collection of legend entries.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.legendentries?view=office-pia"/>
public partial interface LegendEntries: IModelCollection<LegendEntry>
{
}

