namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a color bound to the document’s theme and an optional list of color transforms to apply to the base color.
/// </summary>
public partial class SolidColorFillProperties: ModelElement<DXO10W.SolidColorFillProperties>
{
  public SolidColorFillProperties(): base(){ }
  
  public SolidColorFillProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SolidColorFillProperties(DXO10W.SolidColorFillProperties openXmlElement): base(openXmlElement) { }
  
  
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
