namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the glow effect, a colored, blurred outline that is added outside the edges of text. By default, text does not have glow.
/// </summary>
public partial class Glow: ModelElement<DXO10W.Glow>
{
  public Glow(): base(){ }
  
  public Glow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Glow(DXO10W.Glow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   rad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? GlowRadius
  {
    get
    {
      return _Element?.GlowRadius?.Value;
    }
    set
    {
      _ExistingElement.GlowRadius = value;
    }
  }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
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
  
  
  /// <summary>
  ///   SchemeColor.
  /// </summary>
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
