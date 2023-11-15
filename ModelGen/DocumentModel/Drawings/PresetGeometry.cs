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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
  }
  
}
