namespace DocumentModel.Math;


/// <summary>
///   Control Properties.
/// </summary>
public partial class ControlProperties: ModelElement<DXM.ControlProperties>
{
  public ControlProperties(): base(){ }
  
  public ControlProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ControlProperties(DXM.ControlProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get
    {
      return _Element?.GetObject<DMW.RunProperties,DXW.RunProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunProperties,DXW.RunProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.InsertedMathControl? InsertedMathControl
  {
    get
    {
      return _Element?.GetObject<DMW.InsertedMathControl,DXW.InsertedMathControl>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.InsertedMathControl,DXW.InsertedMathControl>(value);
    }
  }
  
  [DataMember]
  public DMW.DeletedMathControl? DeletedMathControl
  {
    get
    {
      return _Element?.GetObject<DMW.DeletedMathControl,DXW.DeletedMathControl>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DeletedMathControl,DXW.DeletedMathControl>(value);
    }
  }
  
  [DataMember]
  public DMW.MoveFromMathControl? MoveFromMathControl
  {
    get
    {
      return _Element?.GetObject<DMW.MoveFromMathControl,DXW.MoveFromMathControl>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MoveFromMathControl,DXW.MoveFromMathControl>(value);
    }
  }
  
  [DataMember]
  public DMW.MoveToMathControl? MoveToMathControl
  {
    get
    {
      return _Element?.GetObject<DMW.MoveToMathControl,DXW.MoveToMathControl>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MoveToMathControl,DXW.MoveToMathControl>(value);
    }
  }
  
}
