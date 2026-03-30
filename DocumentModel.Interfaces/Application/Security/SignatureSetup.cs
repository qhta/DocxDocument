
namespace DocumentModel.Application;

/// <summary>
/// Represents the `SignatureSetup` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SignatureSetup: IModelObject
{
  /// <summary>
  /// Gets the `ReadOnly` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.readonly?view=office-pia"/>
  public bool ReadOnly { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.id?view=office-pia"/>
  public string Id { get; }
  /// <summary>
  /// Gets the `SignatureProvider` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.signatureprovider?view=office-pia"/>
  public string SignatureProvider { get; }
  /// <summary>
  /// Gets or sets the `SuggestedSigner` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.suggestedsigner?view=office-pia"/>
  public string SuggestedSigner { get; set; }
  /// <summary>
  /// Gets or sets the `SuggestedSignerLine2` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.suggestedsignerline2?view=office-pia"/>
  public string SuggestedSignerLine2 { get; set; }
  /// <summary>
  /// Gets or sets the `SuggestedSignerEmail` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.suggestedsigneremail?view=office-pia"/>
  public string SuggestedSignerEmail { get; set; }
  /// <summary>
  /// Gets or sets the `SigningInstructions` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.signinginstructions?view=office-pia"/>
  public string SigningInstructions { get; set; }
  /// <summary>
  /// Gets or sets the `AllowComments` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.allowcomments?view=office-pia"/>
  public bool AllowComments { get; set; }
  /// <summary>
  /// Gets or sets the `ShowSignDate` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.showsigndate?view=office-pia"/>
  public bool ShowSignDate { get; set; }
  /// <summary>
  /// Gets or sets the `AdditionalXml` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturesetup.additionalxml?view=office-pia"/>
  public string AdditionalXml { get; set; }
}

