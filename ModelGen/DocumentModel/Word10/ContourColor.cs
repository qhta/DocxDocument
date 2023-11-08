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
