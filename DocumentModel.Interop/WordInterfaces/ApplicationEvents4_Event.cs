namespace DocumentModel.Interop.Word;

/// <summary>
/// Events interface for WordApplication object events.This is a .NET interface created when processing a COM coclass that is required by managed code for interoperability with the corresponding COM object. This interface implements all events of earlier interfaces and any additional new events. Use this interface only when the event you want to use shares the same name as a method of the COM object; in this case, cast to this interface to connect to the event, and cast to the primary interface to call the method. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.applicationevents4_event?view=word-pia"/>
public partial interface ApplicationEvents4_Event
{
}
