namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an OLE control in a Word document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.olecontrol?view=word-pia"/>
public interface IOLEControl : I_OLEControl, IOCXEvents_Event
{
}
