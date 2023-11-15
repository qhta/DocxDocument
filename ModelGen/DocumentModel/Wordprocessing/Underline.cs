namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run should be displayed along with an underline appearing directly below the character height (less all spacing above and below the characters on the line).
/// </summary>
public partial class Underline: ModelElement<DXW.Underline>
{
  public Underline(): base(){ }
  
  public Underline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Underline(DXW.Underline openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Underline Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Underline Theme Color Tint
  /// </summary>
  [DataMember]
  public String? ThemeTint
  {
    get => _Element?.ThemeTint;
    set => _ExistingElement.ThemeTint = value;
  }
  
  
  /// <summary>
  ///   Underline Theme Color Shade
  /// </summary>
  [DataMember]
  public String? ThemeShade
  {
    get => _Element?.ThemeShade;
    set => _ExistingElement.ThemeShade = value;
  }
  
}
