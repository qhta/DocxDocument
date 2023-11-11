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
      return _Element?.GetObject<DMM.EquationArrayProperties,DXM.EquationArrayProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.EquationArrayProperties,DXM.EquationArrayProperties>(value);
    }
  }
  
}
