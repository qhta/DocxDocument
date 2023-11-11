namespace DocumentModel.Math;


/// <summary>
///   Box Properties.
/// </summary>
public partial class BoxProperties: ModelElement<DXM.BoxProperties>
{
  public BoxProperties(): base(){ }
  
  public BoxProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BoxProperties(DXM.BoxProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  [DataMember]
  public DMM.OperatorEmulator? OperatorEmulator
  {
    get
    {
      return _Element?.GetObject<DMM.OperatorEmulator,DXM.OperatorEmulator>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.OperatorEmulator,DXM.OperatorEmulator>(value);
    }
  }
  
  
  /// <summary>
  ///   No Break.
  /// </summary>
  [DataMember]
  public DMM.NoBreak? NoBreak
  {
    get
    {
      return _Element?.GetObject<DMM.NoBreak,DXM.NoBreak>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.NoBreak,DXM.NoBreak>(value);
    }
  }
  
  
  /// <summary>
  ///   Differential.
  /// </summary>
  [DataMember]
  public DMM.Differential? Differential
  {
    get
    {
      return _Element?.GetObject<DMM.Differential,DXM.Differential>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Differential,DXM.Differential>(value);
    }
  }
  
  
  /// <summary>
  ///   Break.
  /// </summary>
  [DataMember]
  public DMM.Break? Break
  {
    get
    {
      return _Element?.GetObject<DMM.Break,DXM.Break>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Break,DXM.Break>(value);
    }
  }
  
  
  /// <summary>
  ///   Alignment.
  /// </summary>
  [DataMember]
  public DMM.Alignment? Alignment
  {
    get
    {
      return _Element?.GetObject<DMM.Alignment,DXM.Alignment>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Alignment,DXM.Alignment>(value);
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
