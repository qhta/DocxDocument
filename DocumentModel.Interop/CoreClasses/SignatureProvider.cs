using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureProvider` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider?view=office-pia` for Office interop details.
/// </remarks>
public partial class SignatureProvider
{


  #region methods

/// <summary>
  /// Invokes `GenerateSignatureLineImage`.
  /// </summary>
  /// <param name="siglnimg">The `siglnimg` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="XmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.generatesignaturelineimage?view=office-pia"/>
  public object GenerateSignatureLineImage
    (SignatureLineImage siglnimg, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowSignatureSetup`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.showsignaturesetup?view=office-pia"/>
  public void ShowSignatureSetup(object ParentWindow, SignatureSetup psigsetup) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowSigningCeremony`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.showsigningceremony?view=office-pia"/>
  public void ShowSigningCeremony(object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SignXmlDsig`.
  /// </summary>
  /// <param name="QueryContinue">The `QueryContinue` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="XmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.signxmldsig?view=office-pia"/>
  public void SignXmlDsig(object QueryContinue, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `NotifySignatureAdded`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.notifysignatureadded?view=office-pia"/>
  public void NotifySignatureAdded(object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `VerifyXmlDsig`.
  /// </summary>
  /// <param name="QueryContinue">The `QueryContinue` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="XmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <param name="pcontverres">The `pcontverres` parameter.</param>
  /// <param name="pcertverres">The `pcertverres` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.verifyxmldsig?view=office-pia"/>
  public void VerifyXmlDsig
  (object QueryContinue, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowSignatureDetails`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="XmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <param name="pcontverres">The `pcontverres` parameter.</param>
  /// <param name="pcertverres">The `pcertverres` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.showsignaturedetails?view=office-pia"/>
  public void ShowSignatureDetails
  (object ParentWindow, SignatureSetup psigsetup, SignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `GetProviderDetail`.
  /// </summary>
  /// <param name="sigprovdet">The `sigprovdet` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.getproviderdetail?view=office-pia"/>
  public object GetProviderDetail(SignatureProviderDetail sigprovdet) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `HashStream`.
  /// </summary>
  /// <param name="QueryContinue">The `QueryContinue` parameter.</param>
  /// <param name="Stream">The `Stream` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.hashstream?view=office-pia"/>
  public Array HashStream(object QueryContinue, object Stream) { throw new NotImplementedException(); }

  #endregion methods
}
