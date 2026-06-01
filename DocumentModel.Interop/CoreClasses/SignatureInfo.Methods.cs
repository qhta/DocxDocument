
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureInfo` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo?view=office-pia` for Office interop details.
/// </remarks>
public partial class SignatureInfo
{
  /// <summary>
  /// Invokes `GetSignatureDetail`.
  /// </summary>
  /// <param name="sigdet">The `sigdet` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.getsignaturedetail?view=office-pia"/>
  public object GetSignatureDetail(SignatureDetail sigdet) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetCertificateDetail`.
  /// </summary>
  /// <param name="certdet">The `certdet` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.getcertificatedetail?view=office-pia"/>
  public object GetCertificateDetail(CertificateDetail certdet) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowSignatureCertificate`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.showsignaturecertificate?view=office-pia"/>
  public void ShowSignatureCertificate(object ParentWindow) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SelectSignatureCertificate`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.selectsignaturecertificate?view=office-pia"/>
  public void SelectSignatureCertificate(object ParentWindow) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SelectCertificateDetailByThumbprint`.
  /// </summary>
  /// <param name="bstrThumbprint">The `bstrThumbprint` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.selectcertificatedetailbythumbprint?view=office-pia"/>
  public void SelectCertificateDetailByThumbprint(string bstrThumbprint) { throw new NotImplementedException(); }
}

