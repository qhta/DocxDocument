namespace DocumentModel.Drawings;


/// <summary>
///   Alignment Type
/// </summary>
public partial class PenAlignmentValues: ModelElement<DXD.PenAlignmentValues>
{
  public PenAlignmentValues(): base(){ }
  
  public PenAlignmentValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PenAlignmentValues(DXD.PenAlignmentValues openXmlElement): base(openXmlElement) { }
  
}
