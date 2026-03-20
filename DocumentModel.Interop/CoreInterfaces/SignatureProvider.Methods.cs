using System;

namespace DocumentModel.Interop.Core;

public partial interface SignatureProvider
{
  public object GenerateSignatureLineImage
    (SignatureLineImage siglnimg, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream);
  public void ShowSignatureSetup(object ParentWindow, SignatureSetup psigsetup);
  public void ShowSigningCeremony(object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo);
  public void SignXmlDsig(object QueryContinue, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream);
  public void NotifySignatureAdded(object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo);
  public void VerifyXmlDsig
  (object QueryContinue, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres);
  public void ShowSignatureDetails
  (object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres);
  public object GetProviderDetail(SignatureProviderDetail sigprovdet);
  public Array HashStream(object QueryContinue, object Stream);
}
