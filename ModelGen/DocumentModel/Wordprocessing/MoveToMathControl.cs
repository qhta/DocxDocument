namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public partial class MoveToMathControl: ModelElement<DXW.MoveToMathControl>
{
  public MoveToMathControl(): base(){ }
  
  public MoveToMathControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveToMathControl(DXW.MoveToMathControl openXmlElement): base(openXmlElement) { }
  
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
  
}
