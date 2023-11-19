namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public partial class PermEnd: ModelElement<DXW.PermEnd>
{
  public PermEnd(): base(){ }
  
  public PermEnd(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PermEnd(DXW.PermEnd openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
