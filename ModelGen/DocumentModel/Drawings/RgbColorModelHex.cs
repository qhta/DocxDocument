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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   legacySpreadsheetColorIndex, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? LegacySpreadsheetColorIndex
  {
    get => _Element?.LegacySpreadsheetColorIndex?.Value;
    set => _ExistingElement.LegacySpreadsheetColorIndex = value;
  }
  
}
