namespace DocumentModel.Vml;
/// <summary>
///   Digital Signature Line.
/// </summary>
[OpenXmlType(typeof(DXVO.SignatureLine))]
public partial class SignatureLine : ModelElement<DXVO.SignatureLine>
{
 /// <summary>
 ///   VML Extension Handling Behavior
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.Extension))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public ExtensionHandlingBehaviorKind? Extension { get => _Extension; set => UpdateField(ref _Extension, value, nameof(Extension)); }

 private ExtensionHandlingBehaviorKind? _Extension;
 /// <summary>
 ///   Signature Line Flag
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.IsSignatureLine))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public bool? IsSignatureLine { get => _IsSignatureLine; set => UpdateField(ref _IsSignatureLine, value, nameof(IsSignatureLine)); }

 private bool? _IsSignatureLine;
 /// <summary>
 ///   Unique ID
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.Id))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Signature Provider ID
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.ProviderId))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? ProviderId { get => _ProviderId; set => UpdateField(ref _ProviderId, value, nameof(ProviderId)); }

 private string? _ProviderId;
 /// <summary>
 ///   Use Signing Instructions Flag
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.SigningInstructionsSet))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public bool? SigningInstructionsSet { get => _SigningInstructionsSet; set => UpdateField(ref _SigningInstructionsSet, value, nameof(SigningInstructionsSet)); }

 private bool? _SigningInstructionsSet;
 /// <summary>
 ///   User-specified Comments Flag
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.AllowComments))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public bool? AllowComments { get => _AllowComments; set => UpdateField(ref _AllowComments, value, nameof(AllowComments)); }

 private bool? _AllowComments;
 /// <summary>
 ///   Show Signed Date Flag
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.ShowSignDate))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public bool? ShowSignDate { get => _ShowSignDate; set => UpdateField(ref _ShowSignDate, value, nameof(ShowSignDate)); }

 private bool? _ShowSignDate;
 /// <summary>
 ///   Suggested Signer Line 1
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.SuggestedSigner))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? SuggestedSigner { get => _SuggestedSigner; set => UpdateField(ref _SuggestedSigner, value, nameof(SuggestedSigner)); }

 private string? _SuggestedSigner;
 /// <summary>
 ///   Suggested Signer Line 2
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.SuggestedSigner2))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? SuggestedSigner2 { get => _SuggestedSigner2; set => UpdateField(ref _SuggestedSigner2, value, nameof(SuggestedSigner2)); }

 private string? _SuggestedSigner2;
 /// <summary>
 ///   Suggested Signer E-mail Address
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.SuggestedSignerEmail))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? SuggestedSignerEmail { get => _SuggestedSignerEmail; set => UpdateField(ref _SuggestedSignerEmail, value, nameof(SuggestedSignerEmail)); }

 private string? _SuggestedSignerEmail;
 /// <summary>
 ///   Instructions for Signing
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.SigningInstructions))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? SigningInstructions { get => _SigningInstructions; set => UpdateField(ref _SigningInstructions, value, nameof(SigningInstructions)); }

 private string? _SigningInstructions;
 /// <summary>
 ///   Additional Signature Information
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.AdditionalXml))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? AdditionalXml { get => _AdditionalXml; set => UpdateField(ref _AdditionalXml, value, nameof(AdditionalXml)); }

 private string? _AdditionalXml;
 /// <summary>
 ///   Signature Provider Download URL
 /// </summary>
 [OpenXmlProperty(nameof(DXVO.SignatureLine.SignatureProviderUrl))]
 [OpenXmlElement(typeof(DXVO.SignatureLine))]
 public string? SignatureProviderUrl { get => _SignatureProviderUrl; set => UpdateField(ref _SignatureProviderUrl, value, nameof(SignatureProviderUrl)); }

 private string? _SignatureProviderUrl;
}