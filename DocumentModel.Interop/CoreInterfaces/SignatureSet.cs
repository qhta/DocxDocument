using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SignatureSet: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  int Count { get; }
  Signature this[int iSig] { get; }
  Signature Add();
  void Commit();
  object Parent { get; }
  Signature AddNonVisibleSignature(object varSigProv);
  bool CanAddSignatureLine { get; }
  Signature AddSignatureLine(object varSigProv);
  MsoSignatureSubset Subset { get; set; }
  bool ShowSignaturesPane { set; }
}