namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Text Properties.
/// </summary>
public partial class TextProperties: ModelElement<DXDDD.TextProperties>
{
  public TextProperties(): base(){ }
  
  public TextProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextProperties(DXDDD.TextProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Apply 3D shape properties.
  /// </summary>
  [DataMember]
  public DMD.Shape3DType? Shape3DType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Shape3DType>();
      if (element != null)
        return Shape3DTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DTypeConverter.CreateOpenXmlElement<DXD.Shape3DType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   No text in 3D scene.
  /// </summary>
  [DataMember]
  public DMD.FlatText? FlatText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.FlatText>();
      if (element != null)
        return FlatTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.FlatText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FlatTextConverter.CreateOpenXmlElement<DXD.FlatText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
