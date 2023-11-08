namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Numeric Value.
/// </summary>
public partial class NumericValue: ModelElement<DXDC.NumericValue>
{
  public NumericValue(): base(){ }
  
  public NumericValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericValue(DXDC.NumericValue openXmlElement): base(openXmlElement) { }
  
}
