namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of equation line break objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreaks?view=word-pia"/>
public interface IOMathBreaks : IInteropObject, IInteropCollection<OMathBreak>
{

}
