using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the full set of Series objects in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fullseriescollection?view=office-pia"/>
public interface IFullSeriesCollection: IInteropCollection<IMsoSeries>
{

}

