
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Signature` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISignature: IInteropObject
{
  /// <summary>
  /// Gets the `Signer` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.signer?view=office-pia"/>
  public string Signer { get; }
  /// <summary>
  /// Gets the `Issuer` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.issuer?view=office-pia"/>
  public string Issuer { get; }
  /// <summary>
  /// Gets the `ExpireDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.expiredate?view=office-pia"/>
  public object ExpireDate { get; }
  /// <summary>
  /// Gets the `IsValid` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.isvalid?view=office-pia"/>
  public bool IsValid { get; }
  /// <summary>
  /// Gets or sets the `AttachCertificate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.attachcertificate?view=office-pia"/>
  public bool AttachCertificate { get; set; }
  /// <summary>
  /// Gets the `IsCertificateExpired` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.iscertificateexpired?view=office-pia"/>
  public bool IsCertificateExpired { get; }
  /// <summary>
  /// Gets the `IsCertificateRevoked` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.iscertificaterevoked?view=office-pia"/>
  public bool IsCertificateRevoked { get; }
  /// <summary>
  /// Gets the `SignDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.signdate?view=office-pia"/>
  public object SignDate { get; }
  /// <summary>
  /// Gets the `IsSigned` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.issigned?view=office-pia"/>
  public bool IsSigned { get; }
  /// <summary>
  /// Gets the `Details` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.details?view=office-pia"/>
  public SignatureInfo Details { get; }
  /// <summary>
  /// Gets the `CanSetup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.cansetup?view=office-pia"/>
  public bool CanSetup { get; }
  /// <summary>
  /// Gets the `Setup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.setup?view=office-pia"/>
  public SignatureSetup Setup { get; }
  /// <summary>
  /// Gets the `IsSignatureLine` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.issignatureline?view=office-pia"/>
  public bool IsSignatureLine { get; }
  /// <summary>
  /// Gets the `SignatureLineShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.signaturelineshape?view=office-pia"/>
  public object SignatureLineShape { get; }
  /// <summary>
  /// Gets the `SortHint` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.sorthint?view=office-pia"/>
  public int SortHint { get; }
}

