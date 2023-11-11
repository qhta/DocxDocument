namespace DocumentModel.Drawings;


/// <summary>
///   Defines the FontCollectionType Class.
/// </summary>
public partial class FontCollectionType: ModelElement<DXD.FontCollectionType>
{
  public FontCollectionType(): base(){ }
  
  public FontCollectionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontCollectionType(DXD.FontCollectionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Latin Font.
  /// </summary>
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get
    {
      return _Element?.GetObject<DMD.LatinFont,DXD.LatinFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LatinFont,DXD.LatinFont>(value);
    }
  }
  
  
  /// <summary>
  ///   East Asian Font.
  /// </summary>
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get
    {
      return _Element?.GetObject<DMD.EastAsianFont,DXD.EastAsianFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EastAsianFont,DXD.EastAsianFont>(value);
    }
  }
  
  
  /// <summary>
  ///   Complex Script Font.
  /// </summary>
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get
    {
      return _Element?.GetObject<DMD.ComplexScriptFont,DXD.ComplexScriptFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ComplexScriptFont,DXD.ComplexScriptFont>(value);
    }
  }
  
}
