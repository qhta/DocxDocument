namespace DocumentModel.Vml;

/// <summary>
///   Digital Signature Line.
/// </summary>
[OpenXmlType(typeof(DXVO.SignatureLine))]
[DataContract]
[XmlRoot("SignatureLine", Namespace = "DocumentModel.Vml")]
public partial class SignatureLine: ModelElement<DXVO.SignatureLine>
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.Extension))]
  public ExtensionHandlingBehavior? Extension
  {
    get => _Extension ??= GetProperty<ExtensionHandlingBehavior?>(GetUpdatableElement()?.Extension);
    set => UpdateField(ref _Extension, value, nameof(Extension));
  }

  private ExtensionHandlingBehavior? _Extension;

  /// <summary>
  ///   Signature Line Flag
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.IsSignatureLine))]
  public bool? IsSignatureLine
  {
    get => _IsSignatureLine ??= GetProperty<bool?>(GetUpdatableElement()?.IsSignatureLine);
    set => UpdateField(ref _IsSignatureLine, value, nameof(IsSignatureLine));
  }

  private bool? _IsSignatureLine;

  /// <summary>
  ///   Unique ID
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.ProviderId))]
  public string? ProviderId
  {
    get => _ProviderId ??= GetProperty<string?>(GetUpdatableElement()?.ProviderId);
    set => UpdateField(ref _ProviderId, value, nameof(ProviderId));
  }

  private string? _ProviderId;

  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.SigningInstructionsSet))]
  public bool? SigningInstructionsSet
  {
    get => _SigningInstructionsSet ??= GetProperty<bool?>(GetUpdatableElement()?.SigningInstructionsSet);
    set => UpdateField(ref _SigningInstructionsSet, value, nameof(SigningInstructionsSet));
  }

  private bool? _SigningInstructionsSet;

  /// <summary>
  ///   User-specified Comments Flag
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.AllowComments))]
  public bool? AllowComments
  {
    get => _AllowComments ??= GetProperty<bool?>(GetUpdatableElement()?.AllowComments);
    set => UpdateField(ref _AllowComments, value, nameof(AllowComments));
  }

  private bool? _AllowComments;

  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.ShowSignDate))]
  public bool? ShowSignDate
  {
    get => _ShowSignDate ??= GetProperty<bool?>(GetUpdatableElement()?.ShowSignDate);
    set => UpdateField(ref _ShowSignDate, value, nameof(ShowSignDate));
  }

  private bool? _ShowSignDate;

  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.SuggestedSigner))]
  public string? SuggestedSigner
  {
    get => _SuggestedSigner ??= GetProperty<string?>(GetUpdatableElement()?.SuggestedSigner);
    set => UpdateField(ref _SuggestedSigner, value, nameof(SuggestedSigner));
  }

  private string? _SuggestedSigner;

  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.SuggestedSigner2))]
  public string? SuggestedSigner2
  {
    get => _SuggestedSigner2 ??= GetProperty<string?>(GetUpdatableElement()?.SuggestedSigner2);
    set => UpdateField(ref _SuggestedSigner2, value, nameof(SuggestedSigner2));
  }

  private string? _SuggestedSigner2;

  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.SuggestedSignerEmail))]
  public string? SuggestedSignerEmail
  {
    get => _SuggestedSignerEmail ??= GetProperty<string?>(GetUpdatableElement()?.SuggestedSignerEmail);
    set => UpdateField(ref _SuggestedSignerEmail, value, nameof(SuggestedSignerEmail));
  }

  private string? _SuggestedSignerEmail;

  /// <summary>
  ///   Instructions for Signing
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.SigningInstructions))]
  public string? SigningInstructions
  {
    get => _SigningInstructions ??= GetProperty<string?>(GetUpdatableElement()?.SigningInstructions);
    set => UpdateField(ref _SigningInstructions, value, nameof(SigningInstructions));
  }

  private string? _SigningInstructions;

  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.AdditionalXml))]
  public string? AdditionalXml
  {
    get => _AdditionalXml ??= GetProperty<string?>(GetUpdatableElement()?.AdditionalXml);
    set => UpdateField(ref _AdditionalXml, value, nameof(AdditionalXml));
  }

  private string? _AdditionalXml;

  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.SignatureLine.SignatureProviderUrl))]
  public string? SignatureProviderUrl
  {
    get => _SignatureProviderUrl ??= GetProperty<string?>(GetUpdatableElement()?.SignatureProviderUrl);
    set => UpdateField(ref _SignatureProviderUrl, value, nameof(SignatureProviderUrl));
  }

  private string? _SignatureProviderUrl;
}