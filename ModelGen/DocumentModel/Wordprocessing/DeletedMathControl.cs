namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DeletedMathControl Class.
/// </summary>
public partial class DeletedMathControl: ModelElement<DXW.DeletedMathControl>
{
  public DeletedMathControl(): base(){ }
  
  public DeletedMathControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DeletedMathControl(DXW.DeletedMathControl openXmlElement): base(openXmlElement) { }
  
  
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
  
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
