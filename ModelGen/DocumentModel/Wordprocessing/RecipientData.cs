namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data About Single Data Source Record.
/// </summary>
public partial class RecipientData: ModelElement<DXW.RecipientData>
{
  public RecipientData(): base(){ }
  
  public RecipientData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RecipientData(DXW.RecipientData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  [DataMember]
  public DMW.Active? Active
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Index of Column Containing Unique Values for Record.
  /// </summary>
  [DataMember]
  public DMW.ColumnIndex? ColumnIndex
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.UnsignedDecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.UnsignedDecimalNumberType");
  }
  
  
  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  [DataMember]
  public DM.Base64Binary? UniqueTag
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
