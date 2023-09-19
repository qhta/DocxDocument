namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of a single graphic object. Document authors should refer to this element when they wish to persist a graphical object of some kind. The specification for this graphical object is provided entirely by the document author and referenced within the graphicData child element.
/// </summary>
public partial class Graphic
{
  
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Drawings.GraphicData? GraphicData { get; set; }
  
}
