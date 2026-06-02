
namespace DocumentModel.Interop.Core;


/// <summary>
/// Events class for `MsoEnvelope` object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event?view=office-pia"/>
public partial class MsoEnvelopeVBEvents_Event
{


  #region methods

/// <summary>
  /// Occurs when `EnvelopeShow` is raised.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopeshow?view=office-pia"/>
  public event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
  /// <summary>
  /// Occurs when `EnvelopeHide` is raised.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoenvelopevbevents_event.envelopehide?view=office-pia"/>
  public event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

  #endregion methods
}

