namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color using the red, green, blue RGB color model. Red, green, and blue is expressed as sequence of hex digits, RRGGBB. A perceptual gamma of 2.2 is used.
/// </summary>
public partial class RgbColorModelHex: ModelElement<DXD.RgbColorModelHex>
{
  public RgbColorModelHex(): base(){ }
  
  public RgbColorModelHex(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RgbColorModelHex(DXD.RgbColorModelHex openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   The actual color value. Expressed as a sequence of hex digits RRGGBB.
  /// </summary>
  [DataMember]
  public DM.HexBinary? Val
  {
    get
    {
      if (_Element?.Val?.Value != null)
        return (DocumentModel.RGB)UInt32.Parse(_ExistingElement.Val.Value, NumberStyles.HexNumber);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Val = ((UInt32)value).ToString("X6");
      else
        _ExistingElement.Val = null;
    }
  }
  
  
  /// <summary>
  ///   legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? LegacySpreadsheetColorIndex
  {
    get
    {
      return _Element?.LegacySpreadsheetColorIndex?.Value;
    }
    set
    {
      _ExistingElement.LegacySpreadsheetColorIndex = value;
    }
  }
  
}
