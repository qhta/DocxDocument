using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SignatureSet
{
  public Signature Add();
  public void Commit();
  public Signature AddNonVisibleSignature(object varSigProv);
  public Signature AddSignatureLine(object varSigProv);
}
