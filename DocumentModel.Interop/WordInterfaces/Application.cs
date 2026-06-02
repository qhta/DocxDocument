namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the Word application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.application?view=word-pia"/>
public interface IApplication : _IApplication, IApplicationEvents4_Event
{
}
