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
      var element = _Element?.GetFirstChild<DXOD.ShapeTree>();
      if (element != null)
        return ShapeTreeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.ShapeTree>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeTreeConverter.CreateOpenXmlElement<DXOD.ShapeTree>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
