namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SignatureLine Class.
/// </summary>
public class SignatureLine: ModelElement
{
  /// <summary>
  ///   isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsSignatureLine { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   provId, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ProviderId { get; set; }

  /// <summary>
  ///   signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? SigningInstructionsSet { get; set; }

  /// <summary>
  ///   allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? AllowComments { get; set; }

  /// <summary>
  ///   showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? ShowSignDate { get; set; }

  /// <summary>
  ///   suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SuggestedSigner { get; set; }

  /// <summary>
  ///   suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SuggestedSigner2 { get; set; }

  /// <summary>
  ///   suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SuggestedSignerEmail { get; set; }

  /// <summary>
  ///   signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SigningInstructions { get; set; }

  /// <summary>
  ///   addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  public string? AdditionalXml { get; set; }

  /// <summary>
  ///   sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SignatureProviderUrl { get; set; }
}