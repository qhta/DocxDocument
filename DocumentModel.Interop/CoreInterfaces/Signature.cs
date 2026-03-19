
namespace DocumentModel.Interop.Core;

public interface Signature: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Signer { get; }
  string Issuer { get; }
  object ExpireDate { get; }
  bool IsValid { get; }
  bool AttachCertificate { get; set; }
  void Delete();
  object Parent { get; }
  bool IsCertificateExpired { get; }
  bool IsCertificateRevoked { get; }
  object SignDate { get; }
  bool IsSigned { get; }
  void Sign(object varSigImg, object varDelSuggSigner, object varDelSuggSignerLine2, object varDelSuggSignerEmail);
  SignatureInfo Details { get; }
  void ShowDetails();
  bool CanSetup { get; }
  SignatureSetup Setup { get; }
  bool IsSignatureLine { get; }
  object SignatureLineShape { get; }
  int SortHint { get; }
}