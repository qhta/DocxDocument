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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office.Drawing.GroupShapeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office.Drawing.GroupShapeType");
  }
  
}
