using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SignatureSet: InteropCollection<Signature>
{
  public bool CanAddSignatureLine { get; }
  public MsoSignatureSubset Subset { get; set; }
  public bool ShowSignaturesPane { set; }
}
