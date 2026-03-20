
namespace DocumentModel.Interop.Core;


/// <summary>
/// Represents the `IMsoEnvelopeVBEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoEnvelopeVBEvents_Event
{
  /// <summary>
  /// Occurs when `EnvelopeShow` is raised.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopeshow?view=office-pia
  /// </remarks>
  public event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  /// <summary>
  /// Occurs when `EnvelopeHide` is raised.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopehide?view=office-pia
  /// </remarks>
  public event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}
