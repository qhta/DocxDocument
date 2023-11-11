namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the theme formatting options for the theme and is the workhorse of the theme.  This is where the bulk of the shared theme information is contained and used by a document.  This element contains the color scheme, font scheme, and format scheme elements which define the different formatting aspects of what a theme defines.
/// </summary>
public partial class ThemeElements: ModelElement<DXD.ThemeElements>
{
  public ThemeElements(): base(){ }
  
  public ThemeElements(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeElements(DXD.ThemeElements openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Font Scheme.
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
  ///   Format Scheme.
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
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
