namespace DocumentModel.Drawings;


/// <summary>
///   Keep text out of 3D scene entirely.
/// </summary>
public partial class FlatText: ModelElement<DXD.FlatText>
{
  public FlatText(): base(){ }
  
  public FlatText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FlatText(DXD.FlatText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the Z coordinate to be used in positioning the flat text within the 3D scene.
  /// </summary>
  [DataMember]
  public Int64? Z
  {
    get
    {
      return _Element?.Z?.Value;
    }
    set
    {
      _ExistingElement.Z = value;
    }
  }
  
}
