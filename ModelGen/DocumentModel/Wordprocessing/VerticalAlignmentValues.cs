namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the VerticalAlignmentValues enumeration.
/// </summary>
public partial class VerticalAlignmentValues: ModelElement<DXW.VerticalAlignmentValues>
{
  public VerticalAlignmentValues(): base(){ }
  
  public VerticalAlignmentValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public VerticalAlignmentValues(DXW.VerticalAlignmentValues openXmlElement): base(openXmlElement) { }
  
}
