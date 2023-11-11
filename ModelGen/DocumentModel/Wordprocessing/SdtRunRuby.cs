namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.). The two child elements of this element shall be used to specify the properties and content of the current structured document tag via the sdtPr and sdtContent elements, respectively.
/// </summary>
public partial class SdtRunRuby: ModelElement<DXW.SdtRunRuby>
{
  public SdtRunRuby(): base(){ }
  
  public SdtRunRuby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtRunRuby(DXW.SdtRunRuby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SdtContentRunRuby.
  /// </summary>
  [DataMember]
  public DMW.SdtContentRunRuby? SdtContentRunRuby
  {
    get
    {
      return _Element?.GetObject<DMW.SdtContentRunRuby,DXW.SdtContentRunRuby>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtContentRunRuby,DXW.SdtContentRunRuby>(value);
    }
  }
  
  [DataMember]
  public DMW.SdtProperties? SdtProperties
  {
    get
    {
      return _Element?.GetObject<DMW.SdtProperties,DXW.SdtProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtProperties,DXW.SdtProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.SdtEndCharProperties? SdtEndCharProperties
  {
    get
    {
      return _Element?.GetObject<DMW.SdtEndCharProperties,DXW.SdtEndCharProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SdtEndCharProperties,DXW.SdtEndCharProperties>(value);
    }
  }
  
}
