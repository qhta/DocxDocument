namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableWidthDxaNilType Class.
/// </summary>
public partial class TableWidthDxaNilType: ModelElement<DXW.TableWidthDxaNilType>
{
  public TableWidthDxaNilType(): base(){ }
  
  public TableWidthDxaNilType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableWidthDxaNilType(DXW.TableWidthDxaNilType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w
  /// </summary>
  [DataMember]
  public Int16? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
  }
  
}
