
namespace DocumentModel.Interop.Core;

public delegate void IMsoEnvelopeVBEvents_EnvelopeShowEventHandler();
public delegate void IMsoEnvelopeVBEvents_EnvelopeHideEventHandler();

public interface IMsoEnvelopeVBEvents_Event
{
  public event IMsoEnvelopeVBEvents_EnvelopeShowEventHandler EnvelopeShow;
  public event IMsoEnvelopeVBEvents_EnvelopeHideEventHandler EnvelopeHide;
}
