namespace DocumentModel.Word13;


/// <summary>
///   Defines the CommentEx Class.
/// </summary>
public partial class CommentEx: ModelElement<DXO13W.CommentEx>
{
  public CommentEx(): base(){ }
  
  public CommentEx(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentEx(DXO13W.CommentEx openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParaId
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParaIdParent
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   done, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? Done
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
