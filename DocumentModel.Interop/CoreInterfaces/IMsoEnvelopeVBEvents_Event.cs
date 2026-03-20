
namespace DocumentModel.Interop.Core;

public delegate void IMsoEnvelopeVBEvents_EnvelopeShowEventHandler();
public delegate void IMsoEnvelopeVBEvents_EnvelopeHideEventHandler();

/// <summary>
/// Represents the `IMsoEnvelopeVBEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoEnvelopeVBEvents_Event
{
}
