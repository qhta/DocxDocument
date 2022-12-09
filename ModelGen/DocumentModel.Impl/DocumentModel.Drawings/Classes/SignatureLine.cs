namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SignatureLine Class.
/// </summary>
public class SignatureLineImpl: ModelElementImpl, SignatureLine
{
  public DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsSignatureLine
  {
    get => (Boolean?)OpenXmlElement?.IsSignatureLine?.Value;
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
    get => (String?)OpenXmlElement?.Id?.Value;
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
    get => (String?)OpenXmlElement?.ProviderId?.Value;
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
    get => (Boolean?)OpenXmlElement?.SigningInstructionsSet?.Value;
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
    get => (Boolean?)OpenXmlElement?.AllowComments?.Value;
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
    get => (Boolean?)OpenXmlElement?.ShowSignDate?.Value;
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
    get => (String?)OpenXmlElement?.SuggestedSigner?.Value;
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
    get => (String?)OpenXmlElement?.SuggestedSigner2?.Value;
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
    get => (String?)OpenXmlElement?.SuggestedSignerEmail?.Value;
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
    get => (String?)OpenXmlElement?.SigningInstructions?.Value;
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
    get => (String?)OpenXmlElement?.AdditionalXml?.Value;
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
    get => (String?)OpenXmlElement?.SignatureProviderUrl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SignatureProviderUrl = (System.String?)value;
    }
  }
  
}
