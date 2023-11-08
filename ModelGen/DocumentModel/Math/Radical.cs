namespace DocumentModel.Math;


/// <summary>
///   Radical Function.
/// </summary>
public partial class Radical: ModelElement<DXM.Radical>
{
  public Radical(): base(){ }
  
  public Radical(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Radical(DXM.Radical openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Radical Properties.
  /// </summary>
  [DataMember]
  public DMM.RadicalProperties? RadicalProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.RadicalProperties>();
      if (element != null)
        return RadicalPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.RadicalProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadicalPropertiesConverter.CreateOpenXmlElement<DXM.RadicalProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Degree.
  /// </summary>
  [DataMember]
  public DMM.Degree? Degree
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Degree>();
      if (element != null)
        return DegreeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Degree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DegreeConverter.CreateOpenXmlElement<DXM.Degree>(value);
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
