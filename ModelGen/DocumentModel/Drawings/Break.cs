namespace DocumentModel.Drawings;


/// <summary>
///   Text Line Break.
/// </summary>
public partial class Break: ModelElement<DXD.Break>
{
  public Break(): base(){ }
  
  public Break(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Break(DXD.Break openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  [DataMember]
  public DMD.RunProperties? RunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.RunProperties>();
      if (element != null)
        return RunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DXD.RunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
