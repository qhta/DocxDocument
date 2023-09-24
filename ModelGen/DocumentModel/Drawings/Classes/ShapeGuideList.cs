namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all the guides that are used for this shape. A guide is specified by the gd element and defines a calculated value that can be used for the construction of the corresponding shape.
/// </summary>
public partial class ShapeGuideList
{
  public ElementCollection<ShapeGuide>? Items { get; set; }
  
}
