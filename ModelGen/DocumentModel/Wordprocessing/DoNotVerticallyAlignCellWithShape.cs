namespace DocumentModel.Wordprocessing;


/// <summary>
///   Don't Vertically Align Cells Containing Floating Objects.
/// </summary>
public partial class DoNotVerticallyAlignCellWithShape: ModelElement<DXW.DoNotVerticallyAlignCellWithShape>
{
  public DoNotVerticallyAlignCellWithShape(): base(){ }
  
  public DoNotVerticallyAlignCellWithShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotVerticallyAlignCellWithShape(DXW.DoNotVerticallyAlignCellWithShape openXmlElement): base(openXmlElement) { }
  
}
