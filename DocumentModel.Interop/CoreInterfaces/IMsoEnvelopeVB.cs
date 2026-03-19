
namespace DocumentModel.Interop.Core;

public interface IMsoEnvelopeVB
{
  string Introduction { get; set; }
  object Item { get; }
  object Parent { get; }
  object CommandBars { get; }
}