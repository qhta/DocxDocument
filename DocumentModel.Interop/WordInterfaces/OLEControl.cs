namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an OLE control in a Word document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.olecontrol?view=word-pia"/>
public interface IOLEControl : _IOLEControl, IOCXEvents_Event
{
}
