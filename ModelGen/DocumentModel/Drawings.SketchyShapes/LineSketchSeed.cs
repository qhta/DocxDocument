namespace DocumentModel.Drawings.SketchyShapes;


/// <summary>
///   Defines the LineSketchSeed Class.
/// </summary>
public partial class LineSketchSeed: ModelElement<DXO21DSS.LineSketchSeed>
{
  public LineSketchSeed(): base(){ }
  
  public LineSketchSeed(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSketchSeed(DXO21DSS.LineSketchSeed openXmlElement): base(openXmlElement) { }
  
}
