namespace DocumentModel.Vml;


/// <summary>
///   UI Default Colors.
/// </summary>
public partial class ColorMenu: ModelElement<DXVO.ColorMenu>
{
  public ColorMenu(): base(){ }
  
  public ColorMenu(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorMenu(DXVO.ColorMenu openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Default stroke color
  /// </summary>
  [DataMember]
  public String? StrokeColor
  {
    get => _Element?.StrokeColor;
    set => _ExistingElement.StrokeColor = value;
  }
  
  
  /// <summary>
  ///   Default fill color
  /// </summary>
  [DataMember]
  public String? FillColor
  {
    get => _Element?.FillColor;
    set => _ExistingElement.FillColor = value;
  }
  
  
  /// <summary>
  ///   Default shadow color
  /// </summary>
  [DataMember]
  public String? ShadowColor
  {
    get => _Element?.ShadowColor;
    set => _ExistingElement.ShadowColor = value;
  }
  
  
  /// <summary>
  ///   Default extrusion color
  /// </summary>
  [DataMember]
  public String? ExtrusionColor
  {
    get => _Element?.ExtrusionColor;
    set => _ExistingElement.ExtrusionColor = value;
  }
  
}
