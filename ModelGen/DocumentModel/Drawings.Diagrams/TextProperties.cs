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
      return _Element?.GetObject<DMD.Shape3DType,DXD.Shape3DType>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Shape3DType,DXD.Shape3DType>(value);
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
      return _Element?.GetObject<DMD.FlatText,DXD.FlatText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.FlatText,DXD.FlatText>(value);
    }
  }
  
}
