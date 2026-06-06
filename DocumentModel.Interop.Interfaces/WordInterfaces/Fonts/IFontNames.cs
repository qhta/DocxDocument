namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a list of the names of all the available fonts.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fontnames?view=word-pia"/>
public interface IFontNames : IInteropObject, IInteropCollection<string>
{
}
