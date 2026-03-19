
namespace DocumentModel.Interop.Core;

public delegate void IMsoEnvelopeVBEvents_EnvelopeShowEventHandler();
public delegate void IMsoEnvelopeVBEvents_EnvelopeHideEventHandler();

public interface IMsoEnvelopeVBEvents_Event
{
  event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}