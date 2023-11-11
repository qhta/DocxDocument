namespace DocumentModel.Word10;


/// <summary>
///   Defines the ExtrusionColor Class.
/// </summary>
public partial class ExtrusionColor: ModelElement<DXO10W.ExtrusionColor>
{
  public ExtrusionColor(): base(){ }
  
  public ExtrusionColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtrusionColor(DXO10W.ExtrusionColor openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.HexBinary? RgbColorModelHex
  {
    get
    {
      return _Element?.GetObject<DM.HexBinary,DXO10W.RgbColorModelHex>();
    }
    set
    {
      _ExistingElement.SetObject<DM.HexBinary,DXO10W.RgbColorModelHex>(value);
    }
  }
  
  [DataMember]
  public DMW10.SchemeColorKind? SchemeColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SchemeColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Office2010.Word.SchemeColor");
    }
  }
  
}
