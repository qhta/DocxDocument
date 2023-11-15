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
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  [DataMember]
  public DMW.PreviousTableGrid? PreviousTableGrid
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
