namespace DocumentModel;


/// <summary>
///   Defines the TaskUndo Class.
/// </summary>
public partial class TaskUndo: ModelElement<DXO21DT.TaskUndo>
{
  public TaskUndo(): base(){ }
  
  public TaskUndo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskUndo(DXO21DT.TaskUndo openXmlElement): base(openXmlElement) { }
  
  
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
