namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Subtotals Class.
/// </summary>
public partial class Subtotals: ModelElement<DXO16DCD.Subtotals>
{
  public Subtotals(): base(){ }
  
  public Subtotals(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Subtotals(DXO16DCD.Subtotals openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.ElementCollection<UInt32>? Items
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentModel.ModelElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentModel.ModelElement");
  }
  
}
