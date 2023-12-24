namespace DocumentModel.Wordprocessing;


/// <summary>
///   Previous Paragraph Numbering Properties.
/// </summary>
public partial class NumberingChange: ModelElement<DXW.NumberingChange>
{
  public NumberingChange(): base(){ }
  
  public NumberingChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingChange(DXW.NumberingChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   original
  /// </summary>
  [DataMember]
  public String? Original
  {
    get => _Element?.Original;
    set => _ExistingElement.Original = value;
  }
  
  
  /// <summary>
  ///   author
  /// </summary>
  [DataMember]
  public String? Author
  {
    get => _Element?.Author;
    set => _ExistingElement.Author = value;
  }
  
  
  /// <summary>
  ///   date
  /// </summary>
  [DataMember]
  public DateTime? Date
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public DateTime? DateUtc
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
