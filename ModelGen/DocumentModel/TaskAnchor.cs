namespace DocumentModel;


/// <summary>
///   Defines the TaskAnchor Class.
/// </summary>
public partial class TaskAnchor: ModelElement<DXO21DT.TaskAnchor>
{
  public TaskAnchor(): base(){ }
  
  public TaskAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskAnchor(DXO21DT.TaskAnchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   CommentAnchor.
  /// </summary>
  [DataMember]
  public DM.CommentAnchor? CommentAnchor
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DM.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
