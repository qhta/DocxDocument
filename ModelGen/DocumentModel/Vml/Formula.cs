namespace DocumentModel.Vml;


/// <summary>
///   Single Formula.
/// </summary>
public partial class Formula: ModelElement<DXV.Formula>
{
  public Formula(): base(){ }
  
  public Formula(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Formula(DXV.Formula openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Equation
  /// </summary>
  [DataMember]
  public String? Equation
  {
    get => _Element?.Equation;
    set => _ExistingElement.Equation = value;
  }
  
}
