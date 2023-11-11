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
      return _Element?.GetObject<DMD.Anchor,DXD.Anchor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Anchor,DXD.Anchor>(value);
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
      return _Element?.GetObject<DMD.Normal,DXD.Normal>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Normal,DXD.Normal>(value);
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
      return _Element?.GetObject<DMD.UpVector,DXD.UpVector>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.UpVector,DXD.UpVector>(value);
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
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
