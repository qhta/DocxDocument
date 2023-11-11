namespace DocumentModel.Math;


/// <summary>
///   Delimiter Function.
/// </summary>
public partial class Delimiter: ModelElement<DXM.Delimiter>
{
  public Delimiter(): base(){ }
  
  public Delimiter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Delimiter(DXM.Delimiter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Delimiter Properties.
  /// </summary>
  [DataMember]
  public DMM.DelimiterProperties? DelimiterProperties
  {
    get
    {
      return _Element?.GetObject<DMM.DelimiterProperties,DXM.DelimiterProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.DelimiterProperties,DXM.DelimiterProperties>(value);
    }
  }
  
}
