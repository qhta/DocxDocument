namespace DocumentModel.Vml;

/// <summary>
///   Digital Signature Line.
/// </summary>
public class SignatureLine: ModelElement
{
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension { get; set; }
  /// <summary>
  ///   Signature Line Flag
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
  ///   User-specified Comments Flag
  /// </summary>
  public bool? AllowComments { get; set; }
  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  public bool? ShowSignDate { get; set; }
  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  public string? SuggestedSigner { get; set; }
  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  public string? SuggestedSigner2 { get; set; }
  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  public string? SuggestedSignerEmail { get; set; }
  /// <summary>
  ///   Instructions for Signing
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