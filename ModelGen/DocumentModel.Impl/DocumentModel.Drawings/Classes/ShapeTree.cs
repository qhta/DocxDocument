namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
public class ShapeTreeImpl: DocumentModel.Drawings.GroupShapeTypeImpl, ShapeTree
{
  public override GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get;
    set;
  }
  
  public override GroupShapeProperties1? GroupShapeProperties
  {
    get;
    set;
  }
  
  public OfficeArtExtensionList2? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
