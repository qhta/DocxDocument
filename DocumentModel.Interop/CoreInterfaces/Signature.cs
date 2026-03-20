
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Signature` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Signature: InteropObject
{
  /// <summary>
  /// Gets or sets the `Signer` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.signer?view=office-pia
  /// </remarks>
  public string Signer { get; }
  /// <summary>
  /// Gets the `Issuer` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.issuer?view=office-pia
  /// </remarks>
  public string Issuer { get; }
  /// <summary>
  /// Gets the `ExpireDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.expiredate?view=office-pia
  /// </remarks>
  public object ExpireDate { get; }
  /// <summary>
  /// Gets the `IsValid` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.isvalid?view=office-pia
  /// </remarks>
  public bool IsValid { get; }
  /// <summary>
  /// Gets or sets the `AttachCertificate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.attachcertificate?view=office-pia
  /// </remarks>
  public bool AttachCertificate { get; set; }
  /// <summary>
  /// Gets the `IsCertificateExpired` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.iscertificateexpired?view=office-pia
  /// </remarks>
  public bool IsCertificateExpired { get; }
  /// <summary>
  /// Gets the `IsCertificateRevoked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.iscertificaterevoked?view=office-pia
  /// </remarks>
  public bool IsCertificateRevoked { get; }
  /// <summary>
  /// Gets the `SignDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.signdate?view=office-pia
  /// </remarks>
  public object SignDate { get; }
  /// <summary>
  /// Gets the `IsSigned` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.issigned?view=office-pia
  /// </remarks>
  public bool IsSigned { get; }
  /// <summary>
  /// Gets the `Details` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.details?view=office-pia
  /// </remarks>
  public SignatureInfo Details { get; }
  /// <summary>
  /// Gets the `CanSetup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.cansetup?view=office-pia
  /// </remarks>
  public bool CanSetup { get; }
  /// <summary>
  /// Gets the `Setup` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.setup?view=office-pia
  /// </remarks>
  public SignatureSetup Setup { get; }
  /// <summary>
  /// Gets the `IsSignatureLine` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.issignatureline?view=office-pia
  /// </remarks>
  public bool IsSignatureLine { get; }
  /// <summary>
  /// Gets the `SignatureLineShape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.signaturelineshape?view=office-pia
  /// </remarks>
  public object SignatureLineShape { get; }
  /// <summary>
  /// Gets the `SortHint` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.sorthint?view=office-pia
  /// </remarks>
  public int SortHint { get; }
}
