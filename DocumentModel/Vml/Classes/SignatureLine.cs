namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Digital Signature ILine.
/// </summary>
public class SignatureLine: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }

  /// <summary>
  ///   Signature ILine Flag
  /// </summary>
  public bool? IsSignatureLine { get; set; }

  /// <summary>
  ///   Unique ID
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  public string? ProviderId { get; set; }

  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  public bool? SigningInstructionsSet { get; set; }

  /// <summary>
  ///   User-specified IComments Flag
  /// </summary>
  public bool? AllowComments { get; set; }

  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  public bool? ShowSignDate { get; set; }

  /// <summary>
  ///   Suggested Signer ILine 1
  /// </summary>
  public string? SuggestedSigner { get; set; }

  /// <summary>
  ///   Suggested Signer ILine 2
  /// </summary>
  public string? SuggestedSigner2 { get; set; }

  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  public string? SuggestedSignerEmail { get; set; }

  /// <summary>
  ///   Instructions Ifor Signing
  /// </summary>
  public string? SigningInstructions { get; set; }

  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  public string? AdditionalXml { get; set; }

  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  public string? SignatureProviderUrl { get; set; }
}
