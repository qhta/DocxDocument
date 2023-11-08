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
    get
    {
      return StringValueConverter.GetValue(_Element?.StrokeColor);
    }
    set
    {
      _ExistingElement.StrokeColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default fill color
  /// </summary>
  [DataMember]
  public String? FillColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FillColor);
    }
    set
    {
      _ExistingElement.FillColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default shadow color
  /// </summary>
  [DataMember]
  public String? ShadowColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShadowColor);
    }
    set
    {
      _ExistingElement.ShadowColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Default extrusion color
  /// </summary>
  [DataMember]
  public String? ExtrusionColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ExtrusionColor);
    }
    set
    {
      _ExistingElement.ExtrusionColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
