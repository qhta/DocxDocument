namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a table present in the document. A table is a set of paragraphs (and other block-level content) arranged in rows and columns. Tables in WordprocessingML are defined via the tbl element, which is analogous to the HTML table tag.
/// </summary>
public partial class Table: ModelElement<DXW.Table>
{
  public Table(): base(){ }
  
  public Table(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Table(DXW.Table openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.TableProperties? TableProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW.TableGrid? TableGrid
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
