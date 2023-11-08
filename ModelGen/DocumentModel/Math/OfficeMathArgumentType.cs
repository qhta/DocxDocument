namespace DocumentModel.Math;


/// <summary>
///   Defines the OfficeMathArgumentType Class.
/// </summary>
public partial class OfficeMathArgumentType: ModelElement<DXM.OfficeMathArgumentType>
{
  public OfficeMathArgumentType(): base(){ }
  
  public OfficeMathArgumentType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfficeMathArgumentType(DXM.OfficeMathArgumentType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Argument Properties.
  /// </summary>
  [DataMember]
  public DMM.ArgumentProperties? ArgumentProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ArgumentProperties>();
      if (element != null)
        return ArgumentPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ArgumentProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ArgumentPropertiesConverter.CreateOpenXmlElement<DXM.ArgumentProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
