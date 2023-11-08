namespace DocumentModel.Math;


/// <summary>
///   Superscript Properties.
/// </summary>
public partial class SuperscriptProperties: ModelElement<DXM.SuperscriptProperties>
{
  public SuperscriptProperties(): base(){ }
  
  public SuperscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuperscriptProperties(DXM.SuperscriptProperties openXmlElement): base(openXmlElement) { }
  
  
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
