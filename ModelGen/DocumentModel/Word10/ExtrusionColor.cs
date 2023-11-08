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
