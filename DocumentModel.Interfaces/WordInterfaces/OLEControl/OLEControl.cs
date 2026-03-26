namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an OLE control in a Word document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.olecontrol?view=word-pia"/>
public interface OLEControl : _OLEControl, OCXEvents_Event
{
}
