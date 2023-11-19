namespace DocumentModel;


/// <summary>
///   Defines the CommentAnchor Class.
/// </summary>
public partial class CommentAnchor: ModelElement<DXO21DT.CommentAnchor>
{
  public CommentAnchor(): base(){ }
  
  public CommentAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentAnchor(DXO21DT.CommentAnchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
