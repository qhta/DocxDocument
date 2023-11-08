namespace DocumentModel.Math;


/// <summary>
///   Equation-Array Function.
/// </summary>
public partial class EquationArray: ModelElement<DXM.EquationArray>
{
  public EquationArray(): base(){ }
  
  public EquationArray(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EquationArray(DXM.EquationArray openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Equation Array Properties.
  /// </summary>
  [DataMember]
  public DMM.EquationArrayProperties? EquationArrayProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.EquationArrayProperties>();
      if (element != null)
        return EquationArrayPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.EquationArrayProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EquationArrayPropertiesConverter.CreateOpenXmlElement<DXM.EquationArrayProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
