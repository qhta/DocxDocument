namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents one or more series plotted in a chart with the same format.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartgroups?view=word-pia"/>
public interface IChartGroups : IInteropObject, IInteropCollection<IChartGroup>
{
}
