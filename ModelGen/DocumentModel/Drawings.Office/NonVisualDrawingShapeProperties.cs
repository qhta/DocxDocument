namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualDrawingShapeProperties: ModelElement<DXOD.NonVisualDrawingShapeProperties>
{
  public NonVisualDrawingShapeProperties(): base(){ }
  
  public NonVisualDrawingShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualDrawingShapeProperties(DXOD.NonVisualDrawingShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Text Box
  /// </summary>
  [DataMember]
  public Boolean? TextBox
  {
    get
    {
      return _Element?.TextBox?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextBox = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.TextBox = null;
    }
  }
  
  
  /// <summary>
  ///   Shape Locks.
  /// </summary>
  [DataMember]
  public DMD.ShapeLocks? ShapeLocks
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ShapeLocks>();
      if (element != null)
        return ShapeLocksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeLocksConverter.CreateOpenXmlElement<DXD.ShapeLocks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
