
namespace DocumentModel.Interfaces;


/// <summary>
/// Events interface for `MsoEnvelope` object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event?view=office-pia"/>
public partial interface IMsoEnvelopeVBEvents_Event
{
  /// <summary>
  /// Occurs when `EnvelopeShow` is raised.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopeshow?view=office-pia"/>
  public event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  /// <summary>
  /// Occurs when `EnvelopeHide` is raised.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopehide?view=office-pia"/>
  public event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}

