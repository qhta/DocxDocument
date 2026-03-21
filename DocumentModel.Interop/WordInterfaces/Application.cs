namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the Word application.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.application?view=word-pia"/>
public interface Application : _Application, ApplicationEvents4_Event
{
}
