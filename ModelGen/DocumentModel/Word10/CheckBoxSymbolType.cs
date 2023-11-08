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
      if (_Element?.Val?.Value != null)
        return Convert.FromHexString(_ExistingElement.Val.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Val = Convert.ToHexString(value);
      else
        _ExistingElement.Val = null;
    }
  }
  
}
