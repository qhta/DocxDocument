namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the VerticalPositionValues enumeration.
/// </summary>
public partial class VerticalPositionValues: ModelElement<DXW.VerticalPositionValues>
{
  public VerticalPositionValues(): base(){ }
  
  public VerticalPositionValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public VerticalPositionValues(DXW.VerticalPositionValues openXmlElement): base(openXmlElement) { }
  
}
