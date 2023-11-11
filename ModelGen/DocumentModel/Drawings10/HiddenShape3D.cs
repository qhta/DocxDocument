namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenShape3D Class.
/// </summary>
public partial class HiddenShape3D: ModelElement<DXO10D.HiddenShape3D>
{
  public HiddenShape3D(): base(){ }
  
  public HiddenShape3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenShape3D(DXO10D.HiddenShape3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape Depth
  /// </summary>
  [DataMember]
  public Int64? Z
  {
    get
    {
      return _Element?.Z?.Value;
    }
    set
    {
      _ExistingElement.Z = value;
    }
  }
  
  
  /// <summary>
  ///   Extrusion Height
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
  ///   Contour Width
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
  ///   Top Bevel.
  /// </summary>
  [DataMember]
  public DMD.BevelTop? BevelTop
  {
    get
    {
      return _Element?.GetObject<DMD.BevelTop,DXD.BevelTop>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BevelTop,DXD.BevelTop>(value);
    }
  }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  [DataMember]
  public DMD.BevelBottom? BevelBottom
  {
    get
    {
      return _Element?.GetObject<DMD.BevelBottom,DXD.BevelBottom>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BevelBottom,DXD.BevelBottom>(value);
    }
  }
  
  
  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  [DataMember]
  public DMD.ExtrusionColor? ExtrusionColor
  {
    get
    {
      return _Element?.GetObject<DMD.ExtrusionColor,DXD.ExtrusionColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtrusionColor,DXD.ExtrusionColor>(value);
    }
  }
  
  
  /// <summary>
  ///   Contour Color.
  /// </summary>
  [DataMember]
  public DMD.ContourColor? ContourColor
  {
    get
    {
      return _Element?.GetObject<DMD.ContourColor,DXD.ContourColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ContourColor,DXD.ContourColor>(value);
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
