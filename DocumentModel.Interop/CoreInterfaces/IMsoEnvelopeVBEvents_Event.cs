using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComEventInterface(typeof(IMsoEnvelopeVBEvents), typeof(IMsoEnvelopeVBEvents_EventProvider))]
[TypeLibType(16)]
[ComVisible(false)]
public interface IMsoEnvelopeVBEvents_Event
{
  event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}