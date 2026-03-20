using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SignatureSet: InteropCollection<Signature>
{
  Signature Add();
  void Commit();
  Signature AddNonVisibleSignature(object varSigProv);
  bool CanAddSignatureLine { get; }
  Signature AddSignatureLine(object varSigProv);
  MsoSignatureSubset Subset { get; set; }
  bool ShowSignaturesPane { set; }
}