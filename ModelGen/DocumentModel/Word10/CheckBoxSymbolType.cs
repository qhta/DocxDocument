namespace DocumentModel.Word10;


/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public partial class CheckBoxSymbolType: ModelElement<DXO10W.CheckBoxSymbolType>
{
  public CheckBoxSymbolType(): base(){ }
  
  public CheckBoxSymbolType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CheckBoxSymbolType(DXO10W.CheckBoxSymbolType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   font, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Font
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Font);
    }
    set
    {
      _ExistingElement.Font = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? Val
  {
    get
    {
      return Convert.FromHexString(_Element?.Val.Value);
    }
    set
    {
      _ExistingElement.Val = Convert.ToHexString(value);
    }
  }
  
}
