namespace DocumentModel.Vml.Office;


/// <summary>
///   Digital Signature Line.
/// </summary>
public partial class SignatureLine
{
  
  /// <summary>
  ///   VML Extension Handling Behavior
  /// </summary>
  [SchemaAttr("v:ext")]
  public DocumentModel.Vml.ExtensionHandlingBehaviorValues? Extension { get; set; }
  
  
  /// <summary>
  ///   Signature Line Flag
  /// </summary>
  [SchemaAttr("issignatureline")]
  public Boolean? IsSignatureLine { get; set; }
  
  
  /// <summary>
  ///   Unique ID
  /// </summary>
  [SchemaAttr("id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  [SchemaAttr("provid")]
  public String? ProviderId { get; set; }
  
  
  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  [SchemaAttr("signinginstructionsset")]
  public Boolean? SigningInstructionsSet { get; set; }
  
  
  /// <summary>
  ///   User-specified Comments Flag
  /// </summary>
  [SchemaAttr("allowcomments")]
  public Boolean? AllowComments { get; set; }
  
  
  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  [SchemaAttr("showsigndate")]
  public Boolean? ShowSignDate { get; set; }
  
  
  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  [SchemaAttr("o:suggestedsigner")]
  public String? SuggestedSigner { get; set; }
  
  
  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  [SchemaAttr("o:suggestedsigner2")]
  public String? SuggestedSigner2 { get; set; }
  
  
  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  [SchemaAttr("o:suggestedsigneremail")]
  public String? SuggestedSignerEmail { get; set; }
  
  
  /// <summary>
  ///   Instructions for Signing
  /// </summary>
  [SchemaAttr("signinginstructions")]
  public String? SigningInstructions { get; set; }
  
  
  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  [SchemaAttr("addlxml")]
  public String? AdditionalXml { get; set; }
  
  
  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  [SchemaAttr("sigprovurl")]
  public String? SignatureProviderUrl { get; set; }
  
}
