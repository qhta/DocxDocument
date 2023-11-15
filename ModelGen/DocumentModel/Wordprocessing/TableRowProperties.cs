namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of row-level properties applied to the current table row. Each unique property is specified by a child element of this element. These properties affect the appearance of all cells in the current row within the parent table but can be overridden by individual cell-level properties, as defined by each property.
/// </summary>
public partial class TableRowProperties: ModelElement<DXW.TableRowProperties>
{
  public TableRowProperties(): base(){ }
  
  public TableRowProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableRowProperties(DXW.TableRowProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.Inserted? Inserted
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
  [DataMember]
  public DMW.Deleted? Deleted
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.TrackChangeType");
  }
  
  [DataMember]
  public DMW.TableRowPropertiesChange? TableRowPropertiesChange
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW10.ConflictInsertion? ConflictInsertion
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
  }
  
  [DataMember]
  public DMW10.ConflictDeletion? ConflictDeletion
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.TrackChangeType");
  }
  
}
