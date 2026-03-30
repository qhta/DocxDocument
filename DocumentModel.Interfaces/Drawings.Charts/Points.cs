using System.Collections;

namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents the collection of all chart points in a series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.points?view=office-pia"/>
public partial interface Points: IModelCollection<ChartPoint>
{

}

