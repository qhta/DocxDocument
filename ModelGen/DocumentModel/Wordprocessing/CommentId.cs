namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentId Class.
/// </summary>
public partial class CommentId: ModelElement<DXO19WC.CommentId>
{
  public CommentId(): base(){ }
  
  public CommentId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentId(DXO19WC.CommentId openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParaId
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   durableId, this property is only available in Office 2019 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? DurableId
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
