namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the height of the current table row within the current table. This height shall be used to determine the resulting height of the table row, which can be absolute or relative (depending on its attribute values).
/// </summary>
public partial class TableRowHeight: ModelElement<DXW.TableRowHeight>
{
  public TableRowHeight(): base(){ }
  
  public TableRowHeight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableRowHeight(DXW.TableRowHeight openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Row Height
  /// </summary>
  [DataMember]
  public UInt32? Val
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
