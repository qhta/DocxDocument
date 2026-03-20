
namespace DocumentModel.Interop.Core;

public interface IMsoEnvelopeVB
{
  string Introduction { get; set; }
  object Item { get; }
  object CommandBars { get; }
}