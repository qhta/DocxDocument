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
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Extrusion Viewpoint Origin
  /// </summary>
  [DataMember]
  public String? ViewpointOrigin
  {
    get => _Element?.ViewpointOrigin;
    set => _ExistingElement.ViewpointOrigin = value;
  }
  
  
  /// <summary>
  ///   Extrusion Viewpoint
  /// </summary>
  [DataMember]
  public String? Viewpoint
  {
    get => _Element?.Viewpoint;
    set => _ExistingElement.Viewpoint = value;
  }
  
  
  /// <summary>
  ///   Extrusion Skew Angle
  /// </summary>
  [DataMember]
  public Single? SkewAngle
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
  }
  
  
  /// <summary>
  ///   Extrusion Skew
  /// </summary>
  [DataMember]
  public String? SkewAmount
  {
    get => _Element?.SkewAmount;
    set => _ExistingElement.SkewAmount = value;
  }
  
  
  /// <summary>
  ///   Forward Extrusion
  /// </summary>
  [DataMember]
  public String? ForceDepth
  {
    get => _Element?.ForceDepth;
    set => _ExistingElement.ForceDepth = value;
  }
  
  
  /// <summary>
  ///   Backward Extrusion Depth
  /// </summary>
  [DataMember]
  public String? BackDepth
  {
    get => _Element?.BackDepth;
    set => _ExistingElement.BackDepth = value;
  }
  
  
  /// <summary>
  ///   Rotation Axis
  /// </summary>
  [DataMember]
  public String? Orientation
  {
    get => _Element?.Orientation;
    set => _ExistingElement.Orientation = value;
  }
  
  
  /// <summary>
  ///   Rotation Around Axis
  /// </summary>
  [DataMember]
  public Single? OrientationAngle
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
  }
  
  
  /// <summary>
  ///   Rotation Toggle
  /// </summary>
  [DataMember]
  public Boolean? LockRotationCenter
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Center of Rotation Toggle
  /// </summary>
  [DataMember]
  public Boolean? AutoRotationCenter
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Rotation Center
  /// </summary>
  [DataMember]
  public String? RotationCenter
  {
    get => _Element?.RotationCenter;
    set => _ExistingElement.RotationCenter = value;
  }
  
  
  /// <summary>
  ///   X-Y Rotation Angle
  /// </summary>
  [DataMember]
  public String? RotationAngle
  {
    get => _Element?.RotationAngle;
    set => _ExistingElement.RotationAngle = value;
  }
  
  
  /// <summary>
  ///   Extrusion Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Shininess
  /// </summary>
  [DataMember]
  public Single? Shininess
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
  }
  
  
  /// <summary>
  ///   Specularity
  /// </summary>
  [DataMember]
  public String? Specularity
  {
    get => _Element?.Specularity;
    set => _ExistingElement.Specularity = value;
  }
  
  
  /// <summary>
  ///   Diffuse Reflection
  /// </summary>
  [DataMember]
  public String? Diffusity
  {
    get => _Element?.Diffusity;
    set => _ExistingElement.Diffusity = value;
  }
  
  
  /// <summary>
  ///   Metallic Surface Toggle
  /// </summary>
  [DataMember]
  public Boolean? Metal
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Simulated Bevel
  /// </summary>
  [DataMember]
  public String? Edge
  {
    get => _Element?.Edge;
    set => _ExistingElement.Edge = value;
  }
  
  
  /// <summary>
  ///   Faceting Quality
  /// </summary>
  [DataMember]
  public String? Facet
  {
    get => _Element?.Facet;
    set => _ExistingElement.Facet = value;
  }
  
  
  /// <summary>
  ///   Shape Face Lighting Toggle
  /// </summary>
  [DataMember]
  public Boolean? LightFace
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Brightness
  /// </summary>
  [DataMember]
  public String? Brightness
  {
    get => _Element?.Brightness;
    set => _ExistingElement.Brightness = value;
  }
  
  
  /// <summary>
  ///   Primary Light Position
  /// </summary>
  [DataMember]
  public String? LightPosition
  {
    get => _Element?.LightPosition;
    set => _ExistingElement.LightPosition = value;
  }
  
  
  /// <summary>
  ///   Primary Light Intensity
  /// </summary>
  [DataMember]
  public String? LightLevel
  {
    get => _Element?.LightLevel;
    set => _ExistingElement.LightLevel = value;
  }
  
  
  /// <summary>
  ///   Primary Light Harshness Toggle
  /// </summary>
  [DataMember]
  public Boolean? LightHarsh
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Secondary Light Position
  /// </summary>
  [DataMember]
  public String? LightPosition2
  {
    get => _Element?.LightPosition2;
    set => _ExistingElement.LightPosition2 = value;
  }
  
  
  /// <summary>
  ///   Secondary Light Intensity
  /// </summary>
  [DataMember]
  public String? LightLevel2
  {
    get => _Element?.LightLevel2;
    set => _ExistingElement.LightLevel2 = value;
  }
  
  
  /// <summary>
  ///   Secondary Light Harshness Toggle
  /// </summary>
  [DataMember]
  public Boolean? LightHarsh2
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
}
