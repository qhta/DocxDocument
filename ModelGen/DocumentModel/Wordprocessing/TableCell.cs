namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single cell in a table row, which contains the table’s content. Table cells in WordprocessingML are analogous to HTML td elements.
/// </summary>
public partial class TableCell: ModelElement<DXW.TableCell>
{
  public TableCell(): base(){ }
  
  public TableCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCell(DXW.TableCell openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.TableCellProperties? TableCellProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
