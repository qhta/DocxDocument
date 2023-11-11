namespace DocumentModel.Math;


/// <summary>
///   n-ary Properties.
/// </summary>
public partial class NaryProperties: ModelElement<DXM.NaryProperties>
{
  public NaryProperties(): base(){ }
  
  public NaryProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NaryProperties(DXM.NaryProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  [DataMember]
  public DMM.AccentChar? AccentChar
  {
    get
    {
      return _Element?.GetObject<DMM.AccentChar,DXM.AccentChar>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.AccentChar,DXM.AccentChar>(value);
    }
  }
  
  
  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  [DataMember]
  public DMM.LimitLocation? LimitLocation
  {
    get
    {
      return _Element?.GetObject<DMM.LimitLocation,DXM.LimitLocation>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.LimitLocation,DXM.LimitLocation>(value);
    }
  }
  
  
  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  [DataMember]
  public DMM.GrowOperators? GrowOperators
  {
    get
    {
      return _Element?.GetObject<DMM.GrowOperators,DXM.GrowOperators>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.GrowOperators,DXM.GrowOperators>(value);
    }
  }
  
  
  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  [DataMember]
  public DMM.HideSubArgument? HideSubArgument
  {
    get
    {
      return _Element?.GetObject<DMM.HideSubArgument,DXM.HideSubArgument>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideSubArgument,DXM.HideSubArgument>(value);
    }
  }
  
  
  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  [DataMember]
  public DMM.HideSuperArgument? HideSuperArgument
  {
    get
    {
      return _Element?.GetObject<DMM.HideSuperArgument,DXM.HideSuperArgument>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HideSuperArgument,DXM.HideSuperArgument>(value);
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
