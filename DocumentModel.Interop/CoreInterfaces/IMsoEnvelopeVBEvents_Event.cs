
namespace DocumentModel.Interop.Core;

public delegate void IMsoEnvelopeVBEvents_EnvelopeShowEventHandler();
public delegate void IMsoEnvelopeVBEvents_EnvelopeHideEventHandler();

/// <summary>
/// Events interface for `MsoEnvelope` object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event?view=office-pia
/// </remarks>
public partial interface IMsoEnvelopeVBEvents_Event
{
}
