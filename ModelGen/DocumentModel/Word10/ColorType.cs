namespace DocumentModel.Word10;


/// <summary>
///   Defines the ColorType Class.
/// </summary>
public partial class ColorType: ModelElement<DXO10W.ColorType>
{
  public ColorType(): base(){ }
  
  public ColorType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorType(DXO10W.ColorType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RgbColorModelHex.
  /// </summary>
  [DataMember]
  public DM.HexBinary? RgbColorModelHex
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.RgbColorModelHex>();
      if (element != null)
        return DMX.HexBinaryConverter.GetValue(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexBinaryConverter.CreateOpenXmlElement<DXO10W.RgbColorModelHex>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
