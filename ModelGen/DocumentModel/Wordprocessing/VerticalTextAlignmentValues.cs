namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the VerticalTextAlignmentValues enumeration.
/// </summary>
public partial class VerticalTextAlignmentValues: ModelElement<DXW.VerticalTextAlignmentValues>
{
  public VerticalTextAlignmentValues(): base(){ }
  
  public VerticalTextAlignmentValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public VerticalTextAlignmentValues(DXW.VerticalTextAlignmentValues openXmlElement): base(openXmlElement) { }
  
}
