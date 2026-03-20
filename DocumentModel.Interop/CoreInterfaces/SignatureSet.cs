using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SignatureSet: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  int Count { get; }
  Signature this[int iSig] { get; }
  Signature Add();
  void Commit();
  Signature AddNonVisibleSignature(object varSigProv);
  bool CanAddSignatureLine { get; }
  Signature AddSignatureLine(object varSigProv);
  MsoSignatureSubset Subset { get; set; }
  bool ShowSignaturesPane { set; }
}