namespace DocumentModel.Vml;


/// <summary>
///   3D Extrusion.
/// </summary>
public partial class Extrusion: ModelElement<DXVO.Extrusion>
{
  public Extrusion(): base(){ }
  
  public Extrusion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Extrusion(DXVO.Extrusion openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get
    {
      return _Element?.On?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.On = value;
      else
        _ExistingElement.On = null;
    }
  }
  
  
  /// <summary>
  ///   Extrusion Viewpoint Origin
  /// </summary>
  [DataMember]
  public String? ViewpointOrigin
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ViewpointOrigin);
    }
    set
    {
      _ExistingElement.ViewpointOrigin = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Extrusion Viewpoint
  /// </summary>
  [DataMember]
  public String? Viewpoint
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Viewpoint);
    }
    set
    {
      _ExistingElement.Viewpoint = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Extrusion Skew Angle
  /// </summary>
  [DataMember]
  public Single? SkewAngle
  {
    get
    {
      return _Element?.SkewAngle?.Value;
    }
    set
    {
      _ExistingElement.SkewAngle = value;
    }
  }
  
  
  /// <summary>
  ///   Extrusion Skew
  /// </summary>
  [DataMember]
  public String? SkewAmount
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SkewAmount);
    }
    set
    {
      _ExistingElement.SkewAmount = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Forward Extrusion
  /// </summary>
  [DataMember]
  public String? ForceDepth
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ForceDepth);
    }
    set
    {
      _ExistingElement.ForceDepth = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Backward Extrusion Depth
  /// </summary>
  [DataMember]
  public String? BackDepth
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.BackDepth);
    }
    set
    {
      _ExistingElement.BackDepth = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Rotation Axis
  /// </summary>
  [DataMember]
  public String? Orientation
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Orientation);
    }
    set
    {
      _ExistingElement.Orientation = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Rotation Around Axis
  /// </summary>
  [DataMember]
  public Single? OrientationAngle
  {
    get
    {
      return _Element?.OrientationAngle?.Value;
    }
    set
    {
      _ExistingElement.OrientationAngle = value;
    }
  }
  
  
  /// <summary>
  ///   Rotation Toggle
  /// </summary>
  [DataMember]
  public Boolean? LockRotationCenter
  {
    get
    {
      return _Element?.LockRotationCenter?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LockRotationCenter = value;
      else
        _ExistingElement.LockRotationCenter = null;
    }
  }
  
  
  /// <summary>
  ///   Center of Rotation Toggle
  /// </summary>
  [DataMember]
  public Boolean? AutoRotationCenter
  {
    get
    {
      return _Element?.AutoRotationCenter?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AutoRotationCenter = value;
      else
        _ExistingElement.AutoRotationCenter = null;
    }
  }
  
  
  /// <summary>
  ///   Rotation Center
  /// </summary>
  [DataMember]
  public String? RotationCenter
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RotationCenter);
    }
    set
    {
      _ExistingElement.RotationCenter = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   X-Y Rotation Angle
  /// </summary>
  [DataMember]
  public String? RotationAngle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RotationAngle);
    }
    set
    {
      _ExistingElement.RotationAngle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Extrusion Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color);
    }
    set
    {
      _ExistingElement.Color = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shininess
  /// </summary>
  [DataMember]
  public Single? Shininess
  {
    get
    {
      return _Element?.Shininess?.Value;
    }
    set
    {
      _ExistingElement.Shininess = value;
    }
  }
  
  
  /// <summary>
  ///   Specularity
  /// </summary>
  [DataMember]
  public String? Specularity
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Specularity);
    }
    set
    {
      _ExistingElement.Specularity = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Diffuse Reflection
  /// </summary>
  [DataMember]
  public String? Diffusity
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Diffusity);
    }
    set
    {
      _ExistingElement.Diffusity = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Metallic Surface Toggle
  /// </summary>
  [DataMember]
  public Boolean? Metal
  {
    get
    {
      return _Element?.Metal?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Metal = value;
      else
        _ExistingElement.Metal = null;
    }
  }
  
  
  /// <summary>
  ///   Simulated Bevel
  /// </summary>
  [DataMember]
  public String? Edge
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Edge);
    }
    set
    {
      _ExistingElement.Edge = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Faceting Quality
  /// </summary>
  [DataMember]
  public String? Facet
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Facet);
    }
    set
    {
      _ExistingElement.Facet = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Face Lighting Toggle
  /// </summary>
  [DataMember]
  public Boolean? LightFace
  {
    get
    {
      return _Element?.LightFace?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LightFace = value;
      else
        _ExistingElement.LightFace = null;
    }
  }
  
  
  /// <summary>
  ///   Brightness
  /// </summary>
  [DataMember]
  public String? Brightness
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Brightness);
    }
    set
    {
      _ExistingElement.Brightness = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Primary Light Position
  /// </summary>
  [DataMember]
  public String? LightPosition
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LightPosition);
    }
    set
    {
      _ExistingElement.LightPosition = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Primary Light Intensity
  /// </summary>
  [DataMember]
  public String? LightLevel
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LightLevel);
    }
    set
    {
      _ExistingElement.LightLevel = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Primary Light Harshness Toggle
  /// </summary>
  [DataMember]
  public Boolean? LightHarsh
  {
    get
    {
      return _Element?.LightHarsh?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LightHarsh = value;
      else
        _ExistingElement.LightHarsh = null;
    }
  }
  
  
  /// <summary>
  ///   Secondary Light Position
  /// </summary>
  [DataMember]
  public String? LightPosition2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LightPosition2);
    }
    set
    {
      _ExistingElement.LightPosition2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Secondary Light Intensity
  /// </summary>
  [DataMember]
  public String? LightLevel2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.LightLevel2);
    }
    set
    {
      _ExistingElement.LightLevel2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Secondary Light Harshness Toggle
  /// </summary>
  [DataMember]
  public Boolean? LightHarsh2
  {
    get
    {
      return _Element?.LightHarsh2?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.LightHarsh2 = value;
      else
        _ExistingElement.LightHarsh2 = null;
    }
  }
  
}
