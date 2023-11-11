namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the 3-D properties of text, including bevel, extrusion, contour, and material. By default, text does not have 3-D properties.
/// </summary>
public partial class Properties3D: ModelElement<DXO10W.Properties3D>
{
  public Properties3D(): base(){ }
  
  public Properties3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Properties3D(DXO10W.Properties3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ExtrusionHeight
  {
    get
    {
      return _Element?.ExtrusionHeight?.Value;
    }
    set
    {
      _ExistingElement.ExtrusionHeight = value;
    }
  }
  
  
  /// <summary>
  ///   contourW, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? ContourWidth
  {
    get
    {
      return _Element?.ContourWidth?.Value;
    }
    set
    {
      _ExistingElement.ContourWidth = value;
    }
  }
  
  
  /// <summary>
  ///   BevelTop.
  /// </summary>
  [DataMember]
  public DMW10.BevelTop? BevelTop
  {
    get
    {
      return _Element?.GetObject<DMW10.BevelTop,DXO10W.BevelTop>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.BevelTop,DXO10W.BevelTop>(value);
    }
  }
  
  
  /// <summary>
  ///   BevelBottom.
  /// </summary>
  [DataMember]
  public DMW10.BevelBottom? BevelBottom
  {
    get
    {
      return _Element?.GetObject<DMW10.BevelBottom,DXO10W.BevelBottom>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.BevelBottom,DXO10W.BevelBottom>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtrusionColor.
  /// </summary>
  [DataMember]
  public DMW10.ExtrusionColor? ExtrusionColor
  {
    get
    {
      return _Element?.GetObject<DMW10.ExtrusionColor,DXO10W.ExtrusionColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.ExtrusionColor,DXO10W.ExtrusionColor>(value);
    }
  }
  
  
  /// <summary>
  ///   ContourColor.
  /// </summary>
  [DataMember]
  public DMW10.ContourColor? ContourColor
  {
    get
    {
      return _Element?.GetObject<DMW10.ContourColor,DXO10W.ContourColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.ContourColor,DXO10W.ContourColor>(value);
    }
  }
  
}
