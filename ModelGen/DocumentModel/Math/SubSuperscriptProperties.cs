namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Properties.
/// </summary>
public partial class SubSuperscriptProperties: ModelElement<DXM.SubSuperscriptProperties>
{
  public SubSuperscriptProperties(): base(){ }
  
  public SubSuperscriptProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubSuperscriptProperties(DXM.SubSuperscriptProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Align Scripts.
  /// </summary>
  [DataMember]
  public DMM.AlignScripts? AlignScripts
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.AlignScripts>();
      if (element != null)
        return AlignScriptsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.AlignScripts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlignScriptsConverter.CreateOpenXmlElement<DXM.AlignScripts>(value);
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
