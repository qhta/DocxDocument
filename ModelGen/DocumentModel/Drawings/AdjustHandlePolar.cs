namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a polar adjust handle for a custom shape. The position of this adjust handle is specified by the corresponding pos child element. The allowed adjustment of this adjust handle are specified via it's min and max attributes. Based on the adjustment of this adjust handle certain corresponding guides are updated to contain these values.
/// </summary>
public partial class AdjustHandlePolar: ModelElement<DXD.AdjustHandlePolar>
{
  public AdjustHandlePolar(): base(){ }
  
  public AdjustHandlePolar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AdjustHandlePolar(DXD.AdjustHandlePolar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment radius from this adjust handle.
  /// </summary>
  [DataMember]
  public String? RadialAdjustmentGuide
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RadialAdjustmentGuide);
    }
    set
    {
      _ExistingElement.RadialAdjustmentGuide = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the minimum radial position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move radially. That is the maxR and minR are equal.
  /// </summary>
  [DataMember]
  public String? MinRadial
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MinRadial);
    }
    set
    {
      _ExistingElement.MinRadial = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the maximum radial position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move radially. That is the maxR and minR are equal.
  /// </summary>
  [DataMember]
  public String? MaxRadial
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MaxRadial);
    }
    set
    {
      _ExistingElement.MaxRadial = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment angle from this adjust handle.
  /// </summary>
  [DataMember]
  public String? AngleAdjustmentGuide
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AngleAdjustmentGuide);
    }
    set
    {
      _ExistingElement.AngleAdjustmentGuide = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the minimum angle position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move angularly. That is the maxAng and minAng are equal.
  /// </summary>
  [DataMember]
  public String? MinAngle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MinAngle);
    }
    set
    {
      _ExistingElement.MinAngle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Specifies the maximum angle position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move angularly. That is the maxAng and minAng are equal.
  /// </summary>
  [DataMember]
  public String? MaxAngle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.MaxAngle);
    }
    set
    {
      _ExistingElement.MaxAngle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Position Coordinate.
  /// </summary>
  [DataMember]
  public DMD.Position? Position
  {
    get
    {
      return _Element?.GetObject<DMD.Position,DXD.Position>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Position,DXD.Position>(value);
    }
  }
  
}
