namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a plane in which effects, such as glow and shadow, are applied in relation to the shape they are being applied to.  The points and vectors contained within the backdrop define a plane in 3D space.
/// </summary>
public partial class Backdrop: ModelElement<DXD.Backdrop>
{
  public Backdrop(): base(){ }
  
  public Backdrop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Backdrop(DXD.Backdrop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Anchor Point.
  /// </summary>
  [DataMember]
  public DMD.Anchor? Anchor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Anchor>();
      if (element != null)
        return AnchorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Anchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AnchorConverter.CreateOpenXmlElement<DXD.Anchor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Normal.
  /// </summary>
  [DataMember]
  public DMD.Normal? Normal
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Normal>();
      if (element != null)
        return NormalConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Normal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NormalConverter.CreateOpenXmlElement<DXD.Normal>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Up Vector.
  /// </summary>
  [DataMember]
  public DMD.UpVector? UpVector
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.UpVector>();
      if (element != null)
        return UpVectorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.UpVector>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UpVectorConverter.CreateOpenXmlElement<DXD.UpVector>(value);
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
