namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont: ModelElement<DXD.MajorFont>
{
  public MajorFont(): base(){ }
  
  public MajorFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorFont(DXD.MajorFont openXmlElement): base(openXmlElement) { }
  
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
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
