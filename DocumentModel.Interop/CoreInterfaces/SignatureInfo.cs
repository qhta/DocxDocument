
namespace DocumentModel.Interop.Core;

public interface SignatureInfo: InteropObject
{
  bool ReadOnly { get; }
  string SignatureProvider { get; }
  string SignatureText { get; set; }
  object SignatureImage { get; set; }
  string SignatureComment { get; set; }
  object GetSignatureDetail(SignatureDetail sigdet);
  object GetCertificateDetail(CertificateDetail certdet);
  ContentVerificationResults ContentVerificationResults { get; }
  CertificateVerificationResults CertificateVerificationResults { get; }
  bool IsValid { get; }
  bool IsCertificateExpired { get; }
  bool IsCertificateRevoked { get; }
  bool IsCertificateUntrusted { get; }
  void ShowSignatureCertificate(object ParentWindow);
  void SelectSignatureCertificate(object ParentWindow);
  void SelectCertificateDetailByThumbprint(string bstrThumbprint);
}