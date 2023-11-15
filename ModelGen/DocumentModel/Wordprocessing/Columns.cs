namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Columns Class.
/// </summary>
public partial class Columns: ModelElement<DXW.Columns>
{
  public Columns(): base(){ }
  
  public Columns(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Columns(DXW.Columns openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Equal Column Widths
  /// </summary>
  [DataMember]
  public Boolean? EqualWidth
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Spacing Between Equal Width Columns
  /// </summary>
  [DataMember]
  public String? Space
  {
    get => _Element?.Space;
    set => _ExistingElement.Space = value;
  }
  
  
  /// <summary>
  ///   Number of Equal Width Columns
  /// </summary>
  [DataMember]
  public Int16? ColumnCount
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int16]");
  }
  
  
  /// <summary>
  ///   Draw Line Between Columns
  /// </summary>
  [DataMember]
  public Boolean? Separator
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
