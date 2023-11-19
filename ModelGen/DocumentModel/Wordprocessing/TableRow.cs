namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single table row, which contains the table’s cells. Table rows in WordprocessingML are analogous to HTML tr elements.
/// </summary>
public partial class TableRow: ModelElement<DXW.TableRow>
{
  public TableRow(): base(){ }
  
  public TableRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableRow(DXW.TableRow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowMarkRevision
  {
    get => HexIntConverter.GetValue(_Element?.RsidTableRowMarkRevision);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowAddition
  {
    get => HexIntConverter.GetValue(_Element?.RsidTableRowAddition);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Deletion
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowDeletion
  {
    get => HexIntConverter.GetValue(_Element?.RsidTableRowDeletion);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Properties
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowProperties
  {
    get => HexIntConverter.GetValue(_Element?.RsidTableRowProperties);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ParagraphId
  {
    get => HexIntConverter.GetValue(_Element?.ParagraphId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? TextId
  {
    get => HexIntConverter.GetValue(_Element?.TextId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Table-Level Property Exceptions.
  /// </summary>
  [DataMember]
  public DMW.TablePropertyExceptions? TablePropertyExceptions
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.TableRowProperties? TableRowProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
