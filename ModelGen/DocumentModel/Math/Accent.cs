namespace DocumentModel.Math;


/// <summary>
///   Accent.
/// </summary>
public partial class Accent: ModelElement<DXM.Accent>
{
  public Accent(): base(){ }
  
  public Accent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Accent(DXM.Accent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Accent Properties.
  /// </summary>
  [DataMember]
  public DMM.AccentProperties? AccentProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.AccentProperties>();
      if (element != null)
        return AccentPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.AccentProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AccentPropertiesConverter.CreateOpenXmlElement<DXM.AccentProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Base>();
      if (element != null)
        return BaseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DXM.Base>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
