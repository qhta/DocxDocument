
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureSetup` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SignatureSetup: InteropObject
{
  /// <summary>
  /// Gets or sets the `ReadOnly` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.readonly?view=office-pia
  /// </remarks>
  public bool ReadOnly { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.id?view=office-pia
  /// </remarks>
  public string Id { get; }
  /// <summary>
  /// Gets the `SignatureProvider` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.signatureprovider?view=office-pia
  /// </remarks>
  public string SignatureProvider { get; }
  /// <summary>
  /// Gets or sets the `SuggestedSigner` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.suggestedsigner?view=office-pia
  /// </remarks>
  public string SuggestedSigner { get; set; }
  /// <summary>
  /// Gets or sets the `SuggestedSignerLine2` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.suggestedsignerline2?view=office-pia
  /// </remarks>
  public string SuggestedSignerLine2 { get; set; }
  /// <summary>
  /// Gets or sets the `SuggestedSignerEmail` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.suggestedsigneremail?view=office-pia
  /// </remarks>
  public string SuggestedSignerEmail { get; set; }
  /// <summary>
  /// Gets or sets the `SigningInstructions` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.signinginstructions?view=office-pia
  /// </remarks>
  public string SigningInstructions { get; set; }
  /// <summary>
  /// Gets or sets the `AllowComments` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.allowcomments?view=office-pia
  /// </remarks>
  public bool AllowComments { get; set; }
  /// <summary>
  /// Gets or sets the `ShowSignDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.showsigndate?view=office-pia
  /// </remarks>
  public bool ShowSignDate { get; set; }
  /// <summary>
  /// Gets or sets the `AdditionalXml` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.additionalxml?view=office-pia
  /// </remarks>
  public string AdditionalXml { get; set; }
}
