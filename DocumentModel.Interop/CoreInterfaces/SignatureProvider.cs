using System;

namespace DocumentModel.Interop.Core;

public interface SignatureProvider
{
  object GenerateSignatureLineImage
    (SignatureLineImage siglnimg, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream);

  void ShowSignatureSetup(object ParentWindow, SignatureSetup psigsetup);
  void ShowSigningCeremony(object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo);
  void SignXmlDsig(object QueryContinue, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream);
  void NotifySignatureAdded(object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo);

  void VerifyXmlDsig
  (object QueryContinue, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres);

  void ShowSignatureDetails
  (object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres);

  object GetProviderDetail(SignatureProviderDetail sigprovdet);
  Array HashStream(object QueryContinue, object Stream);
}