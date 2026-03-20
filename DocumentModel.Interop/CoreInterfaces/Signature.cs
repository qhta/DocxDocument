
namespace DocumentModel.Interop.Core;

public interface Signature: InteropObject
{
  public string Signer { get; }
  public string Issuer { get; }
  public object ExpireDate { get; }
  public bool IsValid { get; }
  public bool AttachCertificate { get; set; }
  public void Delete();
  public bool IsCertificateExpired { get; }
  public bool IsCertificateRevoked { get; }
  public object SignDate { get; }
  public bool IsSigned { get; }
  public void Sign(object varSigImg, object varDelSuggSigner, object varDelSuggSignerLine2, object varDelSuggSignerEmail);
  public SignatureInfo Details { get; }
  public void ShowDetails();
  public bool CanSetup { get; }
  public SignatureSetup Setup { get; }
  public bool IsSignatureLine { get; }
  public object SignatureLineShape { get; }
  public int SortHint { get; }
}
