using System;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureProvider` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider?view=office-pia` for Office interop details.
/// </remarks>
public interface ISignatureProvider
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.generatesignaturelineimage?view=office-pia"/>
  public object GenerateSignatureLineImage
    (SignatureLineImage siglnimg, ISignatureSetup psigsetup, ISignatureInfo psiginfo, object XmlDsigStream);
  /// <summary>
  /// Invokes `ShowSignatureSetup`.
  /// </summary>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.showsignaturesetup?view=office-pia"/>
  public void ShowSignatureSetup(object parentWindow, ISignatureSetup psigsetup);
  /// <summary>
  /// Invokes `ShowSigningCeremony`.
  /// </summary>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.showsigningceremony?view=office-pia"/>
  public void ShowSigningCeremony(object parentWindow, ISignatureSetup psigsetup, ISignatureInfo psiginfo);
  /// <summary>
  /// Invokes `SignXmlDsig`.
  /// </summary>
  /// <param name="queryContinue">The `QueryContinue` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="xmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.signxmldsig?view=office-pia"/>
  public void SignXmlDsig(object queryContinue, ISignatureSetup psigsetup, ISignatureInfo psiginfo, object xmlDsigStream);
  /// <summary>
  /// Invokes `NotifySignatureAdded`.
  /// </summary>
  /// <param name="parentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.notifysignatureadded?view=office-pia"/>
  public void NotifySignatureAdded(object parentWindow, ISignatureSetup psigsetup, ISignatureInfo psiginfo);
  /// <summary>
  /// Invokes `VerifyXmlDsig`.
  /// </summary>
  /// <param name="QueryContinue">The `QueryContinue` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="XmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <param name="pcontverres">The `pcontverres` parameter.</param>
  /// <param name="pcertverres">The `pcertverres` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.verifyxmldsig?view=office-pia"/>
  public void VerifyXmlDsig
  (object QueryContinue, ISignatureSetup psigsetup, ISignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres);
  /// <summary>
  /// Invokes `ShowSignatureDetails`.
  /// </summary>
  /// <param name="ParentWindow">The `ParentWindow` parameter.</param>
  /// <param name="psigsetup">The `psigsetup` parameter.</param>
  /// <param name="psiginfo">The `psiginfo` parameter.</param>
  /// <param name="XmlDsigStream">The `XmlDsigStream` parameter.</param>
  /// <param name="pcontverres">The `pcontverres` parameter.</param>
  /// <param name="pcertverres">The `pcertverres` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.showsignaturedetails?view=office-pia"/>
  public void ShowSignatureDetails
  (object ParentWindow, ISignatureSetup psigsetup, ISignatureInfo psiginfo, object XmlDsigStream,
    ref ContentVerificationResults pcontverres, ref CertificateVerificationResults pcertverres);
  /// <summary>
  /// Invokes `GetProviderDetail`.
  /// </summary>
  /// <param name="sigprovdet">The `sigprovdet` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.getproviderdetail?view=office-pia"/>
  public object GetProviderDetail(SignatureProviderDetail sigprovdet);
  /// <summary>
  /// Invokes `HashStream`.
  /// </summary>
  /// <param name="queryContinue">The `QueryContinue` parameter.</param>
  /// <param name="stream">The `Stream` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureprovider.hashstream?view=office-pia"/>
  public Array HashStream(object queryContinue, object stream);

  #endregion methods
}
