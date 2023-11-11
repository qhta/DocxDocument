namespace DocumentModel.Drawings;


/// <summary>
///   This element defines an auxiliary color scheme, which includes both a color scheme and color mapping.  This is mainly used for backward compatibility concerns and roundtrips information required by earlier versions.
/// </summary>
public partial class ExtraColorScheme: ModelElement<DXD.ExtraColorScheme>
{
  public ExtraColorScheme(): base(){ }
  
  public ExtraColorScheme(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExtraColorScheme(DXD.ExtraColorScheme openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  [DataMember]
  public DMD.ColorScheme? ColorScheme
  {
    get
    {
      return _Element?.GetObject<DMD.ColorScheme,DXD.ColorScheme>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ColorScheme,DXD.ColorScheme>(value);
    }
  }
  
  
  /// <summary>
  ///   ColorMap.
  /// </summary>
  [DataMember]
  public DMD.ColorMap? ColorMap
  {
    get
    {
      return _Element?.GetObject<DMD.ColorMap,DXD.ColorMap>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ColorMap,DXD.ColorMap>(value);
    }
  }
  
}
