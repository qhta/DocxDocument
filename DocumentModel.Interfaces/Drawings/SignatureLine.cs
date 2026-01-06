namespace DocumentModel.Drawings;

/// <summary>
///   Defines the SignatureLine interface.
/// </summary>
public interface SignatureLine
{
  /// <summary>
  ///   isSignatureLine
  /// </summary>
  public bool? IsSignatureLine { get; set; }
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   provId
  /// </summary>
  public string? ProviderId { get; set; }
  /// <summary>
  ///   signingInstructionsSet
  /// </summary>
  public bool? SigningInstructionsSet { get; set; }
  /// <summary>
  ///   allowComments
  /// </summary>
  public bool? AllowComments { get; set; }
  /// <summary>
  ///   showSignDate
  /// </summary>
  public bool? ShowSignDate { get; set; }
  /// <summary>
  ///   suggestedSigner
  /// </summary>
  public string? SuggestedSigner { get; set; }
  /// <summary>
  ///   suggestedSigner2
  /// </summary>
  public string? SuggestedSigner2 { get; set; }
  /// <summary>
  ///   suggestedSignerEmail
  /// </summary>
  public string? SuggestedSignerEmail { get; set; }
  /// <summary>
  ///   signingInstructions
  /// </summary>
  public string? SigningInstructions { get; set; }
  /// <summary>
  ///   addlXml
  /// </summary>
  public string? AdditionalXml { get; set; }
  /// <summary>
  ///   sigProvUrl
  /// </summary>
  public string? SignatureProviderUrl { get; set; }
}