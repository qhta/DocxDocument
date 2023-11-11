namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used instead of a custom geometric shape. The generating application should be able to render all preset geometries enumerated in the ST_ShapeType list.
/// </summary>
public partial class PresetGeometry: ModelElement<DXD.PresetGeometry>
{
  public PresetGeometry(): base(){ }
  
  public PresetGeometry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresetGeometry(DXD.PresetGeometry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   List of Shape Adjust Values.
  /// </summary>
  [DataMember]
  public DMD.AdjustValueList? AdjustValueList
  {
    get
    {
      return _Element?.GetObject<DMD.AdjustValueList,DXD.AdjustValueList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.AdjustValueList,DXD.AdjustValueList>(value);
    }
  }
  
}
