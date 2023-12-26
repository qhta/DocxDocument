namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HorizontalAlignmentValues enumeration.
/// </summary>
public partial class HorizontalAlignmentValues: ModelElement<DXW.HorizontalAlignmentValues>
{
  public HorizontalAlignmentValues(): base(){ }
  
  public HorizontalAlignmentValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HorizontalAlignmentValues(DXW.HorizontalAlignmentValues openXmlElement): base(openXmlElement) { }
  
}
