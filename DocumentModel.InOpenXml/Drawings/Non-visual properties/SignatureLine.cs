namespace DocumentModel.Drawings;
/// <summary>
///   Represents a signature line, including identification, provider, signer information, instructions, and display options.
/// </summary>
[OpenXmlType(typeof(DXO13D.SignatureLine))]
public partial class SignatureLine : ModelElement<DXO13D.SignatureLine>
{
 /// <summary>
 ///   Indicates whether this element is a signature line.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.IsSignatureLine))]
 /// <summary>
 ///   Indicates whether this element is a signature line.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public bool? IsSignatureLine { get => _IsSignatureLine; set => UpdateField(ref _IsSignatureLine, value, nameof(IsSignatureLine)); }

 private bool? _IsSignatureLine;
 /// <summary>
 ///   Unique identifier for the signature line.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.Id))]
 /// <summary>
 ///   Unique identifier for the signature line.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Provider identifier for the signature line.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.ProviderId))]
 /// <summary>
 ///   Provider identifier for the signature line.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? ProviderId { get => _ProviderId; set => UpdateField(ref _ProviderId, value, nameof(ProviderId)); }

 private string? _ProviderId;
 /// <summary>
 ///   Indicates whether signing instructions are set.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.SigningInstructionsSet))]
 /// <summary>
 ///   Indicates whether signing instructions are set.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public bool? SigningInstructionsSet { get => _SigningInstructionsSet; set => UpdateField(ref _SigningInstructionsSet, value, nameof(SigningInstructionsSet)); }

 private bool? _SigningInstructionsSet;
 /// <summary>
 ///   Indicates whether comments are allowed.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.AllowComments))]
 /// <summary>
 ///   Indicates whether comments are allowed.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public bool? AllowComments { get => _AllowComments; set => UpdateField(ref _AllowComments, value, nameof(AllowComments)); }

 private bool? _AllowComments;
 /// <summary>
 ///   Indicates whether to show the signing date.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.ShowSignDate))]
 /// <summary>
 ///   Indicates whether to show the signing date.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public bool? ShowSignDate { get => _ShowSignDate; set => UpdateField(ref _ShowSignDate, value, nameof(ShowSignDate)); }

 private bool? _ShowSignDate;
 /// <summary>
 ///   Suggested signer name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.SuggestedSigner))]
 /// <summary>
 ///   Suggested signer name.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? SuggestedSigner { get => _SuggestedSigner; set => UpdateField(ref _SuggestedSigner, value, nameof(SuggestedSigner)); }

 private string? _SuggestedSigner;
 /// <summary>
 ///   Additional suggested signer name.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.SuggestedSigner2))]
 /// <summary>
 ///   Additional suggested signer name.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? SuggestedSigner2 { get => _SuggestedSigner2; set => UpdateField(ref _SuggestedSigner2, value, nameof(SuggestedSigner2)); }

 private string? _SuggestedSigner2;
 /// <summary>
 ///   Suggested signer email address.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.SuggestedSignerEmail))]
 /// <summary>
 ///   Suggested signer email address.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? SuggestedSignerEmail { get => _SuggestedSignerEmail; set => UpdateField(ref _SuggestedSignerEmail, value, nameof(SuggestedSignerEmail)); }

 private string? _SuggestedSignerEmail;
 /// <summary>
 ///   Instructions for signing.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.SigningInstructions))]
 /// <summary>
 ///   Instructions for signing.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? SigningInstructions { get => _SigningInstructions; set => UpdateField(ref _SigningInstructions, value, nameof(SigningInstructions)); }

 private string? _SigningInstructions;
 /// <summary>
 ///   Additional XML data for the signature line.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.AdditionalXml))]
 /// <summary>
 ///   Additional XML data for the signature line.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? AdditionalXml { get => _AdditionalXml; set => UpdateField(ref _AdditionalXml, value, nameof(AdditionalXml)); }

 private string? _AdditionalXml;
 /// <summary>
 ///   URL for the signature provider.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13D.SignatureLine.SignatureProviderUrl))]
 /// <summary>
 ///   URL for the signature provider.
 /// </summary>
 [OpenXmlElement(typeof(DXO13D.SignatureLine))]
 public string? SignatureProviderUrl { get => _SignatureProviderUrl; set => UpdateField(ref _SignatureProviderUrl, value, nameof(SignatureProviderUrl)); }

 private string? _SignatureProviderUrl;
}