namespace DocumentModel.Vml;

/// <summary>
/// Digital Signature Line.
/// </summary>
public partial class SignatureLineImpl: ModelElementImpl, SignatureLine
{
  public DocumentFormat.OpenXml.Vml.Office.SignatureLine? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.SignatureLine?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SignatureLineImpl(): base() {}
  
  public SignatureLineImpl(DocumentFormat.OpenXml.Vml.Office.SignatureLine openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Signature Line Flag
  /// </summary>
  public Boolean? IsSignatureLine
  {
    get => (System.Boolean?)OpenXmlElement?.IsSignatureLine?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsSignatureLine = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Unique ID
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Signature Provider ID
  /// </summary>
  public String? ProviderId
  {
    get => (System.String?)OpenXmlElement?.ProviderId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ProviderId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Use Signing Instructions Flag
  /// </summary>
  public Boolean? SigningInstructionsSet
  {
    get => (System.Boolean?)OpenXmlElement?.SigningInstructionsSet?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SigningInstructionsSet = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// User-specified Comments Flag
  /// </summary>
  public Boolean? AllowComments
  {
    get => (System.Boolean?)OpenXmlElement?.AllowComments?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowComments = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Show Signed Date Flag
  /// </summary>
  public Boolean? ShowSignDate
  {
    get => (System.Boolean?)OpenXmlElement?.ShowSignDate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShowSignDate = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Suggested Signer Line 1
  /// </summary>
  public String? SuggestedSigner
  {
    get => (System.String?)OpenXmlElement?.SuggestedSigner?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SuggestedSigner = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Suggested Signer Line 2
  /// </summary>
  public String? SuggestedSigner2
  {
    get => (System.String?)OpenXmlElement?.SuggestedSigner2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SuggestedSigner2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Suggested Signer E-mail Address
  /// </summary>
  public String? SuggestedSignerEmail
  {
    get => (System.String?)OpenXmlElement?.SuggestedSignerEmail?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SuggestedSignerEmail = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Instructions for Signing
  /// </summary>
  public String? SigningInstructions
  {
    get => (System.String?)OpenXmlElement?.SigningInstructions?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SigningInstructions = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Additional Signature Information
  /// </summary>
  public String? AdditionalXml
  {
    get => (System.String?)OpenXmlElement?.AdditionalXml?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AdditionalXml = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Signature Provider Download URL
  /// </summary>
  public String? SignatureProviderUrl
  {
    get => (System.String?)OpenXmlElement?.SignatureProviderUrl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SignatureProviderUrl = (System.String?)value;
    }
  }
  
}
