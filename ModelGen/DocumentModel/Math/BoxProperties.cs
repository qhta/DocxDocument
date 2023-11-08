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
      var element = _Element?.GetFirstChild<DXM.OperatorEmulator>();
      if (element != null)
        return OperatorEmulatorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.OperatorEmulator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OperatorEmulatorConverter.CreateOpenXmlElement<DXM.OperatorEmulator>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.NoBreak>();
      if (element != null)
        return NoBreakConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.NoBreak>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoBreakConverter.CreateOpenXmlElement<DXM.NoBreak>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.Differential>();
      if (element != null)
        return DifferentialConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Differential>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DifferentialConverter.CreateOpenXmlElement<DXM.Differential>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.Break>();
      if (element != null)
        return BreakConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Break>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BreakConverter.CreateOpenXmlElement<DXM.Break>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.Alignment>();
      if (element != null)
        return AlignmentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Alignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlignmentConverter.CreateOpenXmlElement<DXM.Alignment>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.ControlProperties>();
      if (element != null)
        return ControlPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
