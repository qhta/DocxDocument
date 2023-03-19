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
  public Boolean? IsSignatureLine { get; set; }

  /// <summary>
  ///   Unique ID
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  public String? ProviderId { get; set; }

  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  public Boolean? SigningInstructionsSet { get; set; }

  /// <summary>
  ///   User-specified Comments Flag
  /// </summary>
  public Boolean? AllowComments { get; set; }

  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  public Boolean? ShowSignDate { get; set; }

  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  public String? SuggestedSigner { get; set; }

  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  public String? SuggestedSigner2 { get; set; }

  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  public String? SuggestedSignerEmail { get; set; }

  /// <summary>
  ///   Instructions for Signing
  /// </summary>
  public String? SigningInstructions { get; set; }

  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  public String? AdditionalXml { get; set; }

  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  public String? SignatureProviderUrl { get; set; }
}