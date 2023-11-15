namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color bound to predefined operating system elements.
/// </summary>
public partial class SystemColor: ModelElement<DXD.SystemColor>
{
  public SystemColor(): base(){ }
  
  public SystemColor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SystemColor(DXD.SystemColor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the color value that was last computed by the generating application.
  /// </summary>
  [DataMember]
  public DM.HexBinary? LastColor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
