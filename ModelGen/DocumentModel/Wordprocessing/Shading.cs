namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the shading applied to the contents of the paragraph.
/// </summary>
public partial class Shading: ModelElement<DXW.Shading>
{
  public Shading(): base(){ }
  
  public Shading(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shading(DXW.Shading openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shading Pattern Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Shading Pattern Theme Color Tint
  /// </summary>
  [DataMember]
  public String? ThemeTint
  {
    get => _Element?.ThemeTint;
    set => _ExistingElement.ThemeTint = value;
  }
  
  
  /// <summary>
  ///   Shading Pattern Theme Color Shade
  /// </summary>
  [DataMember]
  public String? ThemeShade
  {
    get => _Element?.ThemeShade;
    set => _ExistingElement.ThemeShade = value;
  }
  
  
  /// <summary>
  ///   Shading Background Color
  /// </summary>
  [DataMember]
  public String? Fill
  {
    get => _Element?.Fill;
    set => _ExistingElement.Fill = value;
  }
  
  
  /// <summary>
  ///   Shading Background Theme Color Tint
  /// </summary>
  [DataMember]
  public String? ThemeFillTint
  {
    get => _Element?.ThemeFillTint;
    set => _ExistingElement.ThemeFillTint = value;
  }
  
  
  /// <summary>
  ///   Shading Background Theme Color Shade
  /// </summary>
  [DataMember]
  public String? ThemeFillShade
  {
    get => _Element?.ThemeFillShade;
    set => _ExistingElement.ThemeFillShade = value;
  }
  
}
