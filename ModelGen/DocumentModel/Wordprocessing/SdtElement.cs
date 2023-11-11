namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines SdtElement - the base class for the sdt elements.
/// </summary>
public partial class SdtElement: ModelElement<DXW.SdtElement>
{
  public SdtElement(): base(){ }
  
  public SdtElement(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtElement(DXW.SdtElement openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the SdtProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Gets or sets the SdtEndCharProperties.
  /// </summary>
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
