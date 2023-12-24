namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comment Content.
/// </summary>
public partial class Comment: ModelElement<DXW.Comment>
{
  public Comment(): base(){ }
  
  public Comment(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Comment(DXW.Comment openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   initials
  /// </summary>
  [DataMember]
  public String? Initials
  {
    get => _Element?.Initials;
    set => _ExistingElement.Initials = value;
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
