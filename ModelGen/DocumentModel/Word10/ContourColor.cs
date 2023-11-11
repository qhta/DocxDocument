namespace DocumentModel.Word10;


/// <summary>
///   Defines the ContourColor Class.
/// </summary>
public partial class ContourColor: ModelElement<DXO10W.ContourColor>
{
  public ContourColor(): base(){ }
  
  public ContourColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContourColor(DXO10W.ContourColor openXmlElement): base(openXmlElement) { }
  
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
