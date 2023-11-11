namespace DocumentModel.Drawings;


/// <summary>
///   Underline Fill.
/// </summary>
public partial class UnderlineFill: ModelElement<DXD.UnderlineFill>
{
  public UnderlineFill(): base(){ }
  
  public UnderlineFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnderlineFill(DXD.UnderlineFill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      return _Element?.GetObject<DMD.NoFill,DXD.NoFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoFill,DXD.NoFill>(value);
    }
  }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      return _Element?.GetObject<DMD.SolidFill,DXD.SolidFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SolidFill,DXD.SolidFill>(value);
    }
  }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      return _Element?.GetObject<DMD.GradientFill,DXD.GradientFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GradientFill,DXD.GradientFill>(value);
    }
  }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get
    {
      return _Element?.GetObject<DMD.BlipFill,DXD.BlipFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BlipFill,DXD.BlipFill>(value);
    }
  }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      return _Element?.GetObject<DMD.PatternFill,DXD.PatternFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PatternFill,DXD.PatternFill>(value);
    }
  }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get
    {
      return _Element?.GetObject<DMD.GroupFill,DXD.GroupFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GroupFill,DXD.GroupFill>(value);
    }
  }
  
}
