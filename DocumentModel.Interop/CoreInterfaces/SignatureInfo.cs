
namespace DocumentModel.Interop.Core;

public interface SignatureInfo: InteropObject
{
  public bool ReadOnly { get; }
  public string SignatureProvider { get; }
  public string SignatureText { get; set; }
  public object SignatureImage { get; set; }
  public string SignatureComment { get; set; }
  public object GetSignatureDetail(SignatureDetail sigdet);
  public object GetCertificateDetail(CertificateDetail certdet);
  public ContentVerificationResults ContentVerificationResults { get; }
  public CertificateVerificationResults CertificateVerificationResults { get; }
  public bool IsValid { get; }
  public bool IsCertificateExpired { get; }
  public bool IsCertificateRevoked { get; }
  public bool IsCertificateUntrusted { get; }
  public void ShowSignatureCertificate(object ParentWindow);
  public void SelectSignatureCertificate(object ParentWindow);
  public void SelectCertificateDetailByThumbprint(string bstrThumbprint);
}
