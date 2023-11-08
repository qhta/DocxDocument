namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveFromMathControl Class.
/// </summary>
public partial class MoveFromMathControl: ModelElement<DXW.MoveFromMathControl>
{
  public MoveFromMathControl(): base(){ }
  
  public MoveFromMathControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MoveFromMathControl(DXW.MoveFromMathControl openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunProperties>();
      if (element != null)
        return RunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.InsertedMathControl? InsertedMathControl
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.InsertedMathControl>();
      if (element != null)
        return InsertedMathControlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.InsertedMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsertedMathControlConverter.CreateOpenXmlElement<DXW.InsertedMathControl>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.DeletedMathControl? DeletedMathControl
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DeletedMathControl>();
      if (element != null)
        return DeletedMathControlConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DeletedMathControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeletedMathControlConverter.CreateOpenXmlElement<DXW.DeletedMathControl>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
