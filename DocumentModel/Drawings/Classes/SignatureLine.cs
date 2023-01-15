namespace DocumentModel.Drawings;

/// <summary>
///   Defines the SignatureLine Class.
/// </summary>
public class SignatureLine
{
  /// <summary>
  ///   isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsSignatureLine { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   provId, this property is only available in Office 2013 and later.
  /// </summary>
  public String? ProviderId { get; set; }

  /// <summary>
  ///   signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? SigningInstructionsSet { get; set; }

  /// <summary>
  ///   allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? AllowComments { get; set; }

  /// <summary>
  ///   showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? ShowSignDate { get; set; }

  /// <summary>
  ///   suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SuggestedSigner { get; set; }

  /// <summary>
  ///   suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SuggestedSigner2 { get; set; }

  /// <summary>
  ///   suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SuggestedSignerEmail { get; set; }

  /// <summary>
  ///   signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SigningInstructions { get; set; }

  /// <summary>
  ///   addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  public String? AdditionalXml { get; set; }

  /// <summary>
  ///   sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  public String? SignatureProviderUrl { get; set; }
}