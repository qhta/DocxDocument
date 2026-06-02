namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all legend entry objects in a chart legend.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.legendentries?view=word-pia"/>
public interface ILegendEntries : IInteropObject, IInteropCollection<LegendEntry>
{
}
