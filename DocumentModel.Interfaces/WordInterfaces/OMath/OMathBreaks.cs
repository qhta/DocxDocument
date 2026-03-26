namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the collection of equation line break objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreaks?view=word-pia"/>
public partial interface OMathBreaks : InteropObject, InteropCollection<OMathBreak>
{

}
