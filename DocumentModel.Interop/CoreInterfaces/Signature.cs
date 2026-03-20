
namespace DocumentModel.Interop.Core;

public partial interface Signature: InteropObject
{
  public string Signer { get; }
  public string Issuer { get; }
  public object ExpireDate { get; }
  public bool IsValid { get; }
  public bool AttachCertificate { get; set; }
  public bool IsCertificateExpired { get; }
  public bool IsCertificateRevoked { get; }
  public object SignDate { get; }
  public bool IsSigned { get; }
  public SignatureInfo Details { get; }
  public bool CanSetup { get; }
  public SignatureSetup Setup { get; }
  public bool IsSignatureLine { get; }
  public object SignatureLineShape { get; }
  public int SortHint { get; }
}
