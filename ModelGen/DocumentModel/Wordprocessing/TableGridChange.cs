namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table Grid Column Definitions.
/// </summary>
public partial class TableGridChange: ModelElement<DXW.TableGridChange>
{
  public TableGridChange(): base(){ }
  
  public TableGridChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableGridChange(DXW.TableGridChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? PreviousTableGrid
  {
    get => _Element?.GetHexIntVal<DXW.PreviousTableGrid>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
