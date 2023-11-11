namespace DocumentModel.Math;


/// <summary>
///   Phantom Properties.
/// </summary>
public partial class PhantomProperties: ModelElement<DXM.PhantomProperties>
{
  public PhantomProperties(): base(){ }
  
  public PhantomProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PhantomProperties(DXM.PhantomProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  [DataMember]
  public DMM.ShowPhantom? ShowPhantom
  {
    get
    {
      return _Element?.GetObject<DMM.ShowPhantom,DXM.ShowPhantom>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ShowPhantom,DXM.ShowPhantom>(value);
    }
  }
  
  
  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  [DataMember]
  public DMM.ZeroWidth? ZeroWidth
  {
    get
    {
      return _Element?.GetObject<DMM.ZeroWidth,DXM.ZeroWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ZeroWidth,DXM.ZeroWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  [DataMember]
  public DMM.ZeroAscent? ZeroAscent
  {
    get
    {
      return _Element?.GetObject<DMM.ZeroAscent,DXM.ZeroAscent>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ZeroAscent,DXM.ZeroAscent>(value);
    }
  }
  
  
  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  [DataMember]
  public DMM.ZeroDescent? ZeroDescent
  {
    get
    {
      return _Element?.GetObject<DMM.ZeroDescent,DXM.ZeroDescent>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ZeroDescent,DXM.ZeroDescent>(value);
    }
  }
  
  
  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  [DataMember]
  public DMM.Transparent? Transparent
  {
    get
    {
      return _Element?.GetObject<DMM.Transparent,DXM.Transparent>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Transparent,DXM.Transparent>(value);
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
