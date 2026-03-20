
namespace DocumentModel.Interop.Core;

public partial interface SignatureInfo
{
  public object GetSignatureDetail(SignatureDetail sigdet);
  public object GetCertificateDetail(CertificateDetail certdet);
  public void ShowSignatureCertificate(object ParentWindow);
  public void SelectSignatureCertificate(object ParentWindow);
  public void SelectCertificateDetailByThumbprint(string bstrThumbprint);
}
