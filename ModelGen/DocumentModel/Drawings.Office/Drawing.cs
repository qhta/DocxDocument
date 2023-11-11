namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the Drawing Class.
/// </summary>
public partial class Drawing: ModelElement<DXOD.Drawing>
{
  public Drawing(): base(){ }
  
  public Drawing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Drawing(DXOD.Drawing openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  [DataMember]
  public DMDO.ShapeTree? ShapeTree
  {
    get
    {
      return _Element?.GetObject<DMDO.ShapeTree,DXOD.ShapeTree>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.ShapeTree,DXOD.ShapeTree>(value);
    }
  }
  
}
