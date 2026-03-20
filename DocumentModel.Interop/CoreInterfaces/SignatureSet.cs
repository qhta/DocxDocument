using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SignatureSet: InteropCollection<Signature>
{
  public Signature Add();
  public void Commit();
  public Signature AddNonVisibleSignature(object varSigProv);
  public bool CanAddSignatureLine { get; }
  public Signature AddSignatureLine(object varSigProv);
  public MsoSignatureSubset Subset { get; set; }
  public bool ShowSignaturesPane { set; }
}
