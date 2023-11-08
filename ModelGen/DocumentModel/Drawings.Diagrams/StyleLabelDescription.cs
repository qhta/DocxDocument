namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Style Label Description.
/// </summary>
public partial class StyleLabelDescription: ModelElement<DXDDD.StyleLabelDescription>
{
  public StyleLabelDescription(): base(){ }
  
  public StyleLabelDescription(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleLabelDescription(DXDDD.StyleLabelDescription openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Natural Language
  /// </summary>
  [DataMember]
  public String? Language
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Language);
    }
    set
    {
      _ExistingElement.Language = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Description Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
