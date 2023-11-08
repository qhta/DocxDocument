namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextFontType Class.
/// </summary>
public partial class TextFontType: ModelElement<DXD.TextFontType>
{
  public TextFontType(): base(){ }
  
  public TextFontType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextFontType(DXD.TextFontType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Typeface
  /// </summary>
  [DataMember]
  public String? Typeface
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Typeface);
    }
    set
    {
      _ExistingElement.Typeface = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Panose Setting
  /// </summary>
  [DataMember]
  public DM.HexBinary? Panose
  {
    get
    {
      if (_Element?.Panose?.Value != null)
        return Convert.FromHexString(_ExistingElement.Panose.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Panose = Convert.ToHexString(value);
      else
        _ExistingElement.Panose = null;
    }
  }
  
  
  /// <summary>
  ///   Similar Font Family
  /// </summary>
  [DataMember]
  public SByte? PitchFamily
  {
    get
    {
      return _Element?.PitchFamily?.Value;
    }
    set
    {
      _ExistingElement.PitchFamily = value;
    }
  }
  
  
  /// <summary>
  ///   Similar Character Set
  /// </summary>
  [DataMember]
  public SByte? CharacterSet
  {
    get
    {
      return _Element?.CharacterSet?.Value;
    }
    set
    {
      _ExistingElement.CharacterSet = value;
    }
  }
  
}
