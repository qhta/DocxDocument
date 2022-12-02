namespace DocumentModel.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public interface ISignatureLine // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Signature Line Flag
  /// </summary>
  public System.Boolean? IsSignatureLine { get ; set; }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  public System.String? ProviderId { get ; set; }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  public System.Boolean? SigningInstructionsSet { get ; set; }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  public System.Boolean? AllowComments { get ; set; }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  public System.Boolean? ShowSignDate { get ; set; }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  public System.String? SuggestedSigner { get ; set; }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  public System.String? SuggestedSigner2 { get ; set; }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  public System.String? SuggestedSignerEmail { get ; set; }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  public System.String? SigningInstructions { get ; set; }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  public System.String? AdditionalXml { get ; set; }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  public System.String? SignatureProviderUrl { get ; set; }
  
}
