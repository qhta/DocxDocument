namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a symbol character at the current location in the run’s content. A symbol character is a special character within a run’s content which does not use any of the run fonts specified in the rFonts element (or by the style hierarchy).
/// </summary>
public partial class SymbolChar: ModelElement<DXW.SymbolChar>
{
  public SymbolChar(): base(){ }
  
  public SymbolChar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SymbolChar(DXW.SymbolChar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Symbol Character Font
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
  ///   Symbol Character Code
  /// </summary>
  [DataMember]
  public DM.HexBinary? Char
  {
    get
    {
      return Convert.FromHexString(_Element?.Char.Value);
    }
    set
    {
      _ExistingElement.Char = Convert.ToHexString(value);
    }
  }
  
}
