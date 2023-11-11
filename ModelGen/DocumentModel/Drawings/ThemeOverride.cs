namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for an override which changes just the colors, fonts, or effects of a single object, like a table for example.  Currently it is used only to control overrides on the non-top-level masters within a presentation.
/// </summary>
public partial class ThemeOverride: ModelElement<DXD.ThemeOverride>
{
  public ThemeOverride(): base(){ }
  
  public ThemeOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeOverride(DXD.ThemeOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Color Scheme.
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
  ///   FontScheme.
  /// </summary>
  [DataMember]
  public DMD.FontScheme? FontScheme
  {
    get
    {
      return _Element?.GetObject<DMD.FontScheme,DXD.FontScheme>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FontScheme,DXD.FontScheme>(value);
    }
  }
  
  
  /// <summary>
  ///   FormatScheme.
  /// </summary>
  [DataMember]
  public DMD.FormatScheme? FormatScheme
  {
    get
    {
      return _Element?.GetObject<DMD.FormatScheme,DXD.FormatScheme>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FormatScheme,DXD.FormatScheme>(value);
    }
  }
  
}
