namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used to transform a piece of text. This operation is known formally as a text warp. The generating application should be able to render all preset geometries enumerated in the ST_TextShapeType list.
/// </summary>
public partial class PresetTextWarp: ModelElement<DXD.PresetTextWarp>
{
  public PresetTextWarp(): base(){ }
  
  public PresetTextWarp(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresetTextWarp(DXD.PresetTextWarp openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  [DataMember]
  public DMD.AdjustValueList? AdjustValueList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.GeometryGuideListType");
  }
  
}
