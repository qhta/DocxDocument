namespace DocumentModel.Drawings;


/// <summary>
///   Defines the SignatureLine Class.
/// </summary>
public partial class SignatureLine: ModelElement<DXO13D.SignatureLine>
{
  public SignatureLine(): base(){ }
  
  public SignatureLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SignatureLine(DXO13D.SignatureLine openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsSignatureLine
  {
    get
    {
      return _Element?.IsSignatureLine?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.IsSignatureLine = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.IsSignatureLine = null;
    }
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   provId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? ProviderId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ProviderId);
    }
    set
    {
      _ExistingElement.ProviderId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? SigningInstructionsSet
  {
    get
    {
      return _Element?.SigningInstructionsSet?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SigningInstructionsSet = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SigningInstructionsSet = null;
    }
  }
  
  
  /// <summary>
  ///   allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? AllowComments
  {
    get
    {
      return _Element?.AllowComments?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowComments = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.AllowComments = null;
    }
  }
  
  
  /// <summary>
  ///   showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowSignDate
  {
    get
    {
      return _Element?.ShowSignDate?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowSignDate = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ShowSignDate = null;
    }
  }
  
  
  /// <summary>
  ///   suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SuggestedSigner
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SuggestedSigner);
    }
    set
    {
      _ExistingElement.SuggestedSigner = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SuggestedSigner2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SuggestedSigner2);
    }
    set
    {
      _ExistingElement.SuggestedSigner2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SuggestedSignerEmail
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SuggestedSignerEmail);
    }
    set
    {
      _ExistingElement.SuggestedSignerEmail = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SigningInstructions
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SigningInstructions);
    }
    set
    {
      _ExistingElement.SigningInstructions = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? AdditionalXml
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AdditionalXml);
    }
    set
    {
      _ExistingElement.AdditionalXml = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SignatureProviderUrl
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SignatureProviderUrl);
    }
    set
    {
      _ExistingElement.SignatureProviderUrl = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
