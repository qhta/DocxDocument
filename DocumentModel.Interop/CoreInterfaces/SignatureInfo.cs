
namespace DocumentModel.Interop.Core;

public partial interface SignatureInfo: InteropObject
{
  public bool ReadOnly { get; }
  public string SignatureProvider { get; }
  public string SignatureText { get; set; }
  public object SignatureImage { get; set; }
  public string SignatureComment { get; set; }
  public ContentVerificationResults ContentVerificationResults { get; }
  public CertificateVerificationResults CertificateVerificationResults { get; }
  public bool IsValid { get; }
  public bool IsCertificateExpired { get; }
  public bool IsCertificateRevoked { get; }
  public bool IsCertificateUntrusted { get; }
}
