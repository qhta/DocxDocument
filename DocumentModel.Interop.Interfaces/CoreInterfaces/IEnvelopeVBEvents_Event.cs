
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Events interface for `MsoEnvelope` object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event?view=office-pia"/>
public interface IEnvelopeVBEvents_Event
{	

  #region methods	
/// <summary>
  /// Occurs when `EnvelopeShow` is raised.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopeshow?view=office-pia"/>
  public event MsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  /// <summary>
  /// Occurs when `EnvelopeHide` is raised.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopehide?view=office-pia"/>
  public event MsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;	
  #endregion methods
}	

