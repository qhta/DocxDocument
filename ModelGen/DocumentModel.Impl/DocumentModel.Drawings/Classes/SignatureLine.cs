namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SignatureLine Class.
/// </summary>
public partial class SignatureLineImpl: ModelElementImpl, SignatureLine
{
  public DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SignatureLineImpl(): base() {}
  
  public SignatureLineImpl(DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// isSignatureLine, this property is only available in Office 2013 and later.
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
  /// id, this property is only available in Office 2013 and later.
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
  /// provId, this property is only available in Office 2013 and later.
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
  /// signingInstructionsSet, this property is only available in Office 2013 and later.
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
  /// allowComments, this property is only available in Office 2013 and later.
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
  /// showSignDate, this property is only available in Office 2013 and later.
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
  /// suggestedSigner, this property is only available in Office 2013 and later.
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
  /// suggestedSigner2, this property is only available in Office 2013 and later.
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
  /// suggestedSignerEmail, this property is only available in Office 2013 and later.
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
  /// signingInstructions, this property is only available in Office 2013 and later.
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
  /// addlXml, this property is only available in Office 2013 and later.
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
  /// sigProvUrl, this property is only available in Office 2013 and later.
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
