
namespace DocumentModel.Interop.Core;

public partial interface IMsoEnvelopeVB
{
  public string Introduction { get; set; }
  public object Item { get; }
  public object CommandBars { get; }
}
