namespace DocumentModel.Math;


/// <summary>
///   Defines the Run Class.
/// </summary>
public partial class Run: ModelElement<DXM.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXM.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMM.RunProperties? MathRunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.RunProperties>();
      if (element != null)
        return RunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DXM.RunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
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
  
}
