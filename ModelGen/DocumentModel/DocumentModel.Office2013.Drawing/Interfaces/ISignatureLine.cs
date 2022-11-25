namespace DocumentModel.Office2013.Drawing;

/// <summary>
/// Defines the SignatureLine Class.
/// </summary>
public interface ISignatureLine // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? IsSignatureLine { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// provId, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? ProviderId { get ; set; }
  
  /// <summary>
  /// signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? SigningInstructionsSet { get ; set; }
  
  /// <summary>
  /// allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? AllowComments { get ; set; }
  
  /// <summary>
  /// showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? ShowSignDate { get ; set; }
  
  /// <summary>
  /// suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SuggestedSigner { get ; set; }
  
  /// <summary>
  /// suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SuggestedSigner2 { get ; set; }
  
  /// <summary>
  /// suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SuggestedSignerEmail { get ; set; }
  
  /// <summary>
  /// signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SigningInstructions { get ; set; }
  
  /// <summary>
  /// addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? AdditionalXml { get ; set; }
  
  /// <summary>
  /// sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? SignatureProviderUrl { get ; set; }
  
}
