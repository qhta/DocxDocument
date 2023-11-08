namespace DocumentModel.Wordprocessing;


/// <summary>
///   Drawing Grid Horizontal Grid Unit Size.
/// </summary>
public partial class DrawingGridHorizontalSpacing: ModelElement<DXW.DrawingGridHorizontalSpacing>
{
  public DrawingGridHorizontalSpacing(): base(){ }
  
  public DrawingGridHorizontalSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DrawingGridHorizontalSpacing(DXW.DrawingGridHorizontalSpacing openXmlElement): base(openXmlElement) { }
  
}
