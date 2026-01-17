namespace DocumentModel.Drawings;

/// <summary>
///   Represents a signature line, including identification, provider, signer information, instructions, and display options.
/// </summary>
public class SignatureLine: ModelElement<DXO13D.SignatureLine>
{
  /// <summary>
  ///   Indicates whether this element is a signature line.
  /// </summary>
  public bool? IsSignatureLine { get; set; }

  /// <summary>
  ///   Unique identifier for the signature line.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Provider identifier for the signature line.
  /// </summary>
  public string? ProviderId { get; set; }

  /// <summary>
  ///   Indicates whether signing instructions are set.
  /// </summary>
  public bool? SigningInstructionsSet { get; set; }

  /// <summary>
  ///   Indicates whether comments are allowed.
  /// </summary>
  public bool? AllowComments { get; set; }

  /// <summary>
  ///   Indicates whether to show the signing date.
  /// </summary>
  public bool? ShowSignDate { get; set; }

  /// <summary>
  ///   Suggested signer name.
  /// </summary>
  public string? SuggestedSigner { get; set; }

  /// <summary>
  ///   Additional suggested signer name.
  /// </summary>
  public string? SuggestedSigner2 { get; set; }

  /// <summary>
  ///   Suggested signer email address.
  /// </summary>
  public string? SuggestedSignerEmail { get; set; }

  /// <summary>
  ///   Instructions for signing.
  /// </summary>
  public string? SigningInstructions { get; set; }

  /// <summary>
  ///   Additional XML data for the signature line.
  /// </summary>
  public string? AdditionalXml { get; set; }

  /// <summary>
  ///   URL for the signature provider.
  /// </summary>
  public string? SignatureProviderUrl { get; set; }
}