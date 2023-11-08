namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontRelationshipType Class.
/// </summary>
public partial class FontRelationshipType: ModelElement<DXW.FontRelationshipType>
{
  public FontRelationshipType(): base(){ }
  
  public FontRelationshipType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontRelationshipType(DXW.FontRelationshipType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   fontKey
  /// </summary>
  [DataMember]
  public String? FontKey
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FontKey);
    }
    set
    {
      _ExistingElement.FontKey = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   subsetted
  /// </summary>
  [DataMember]
  public Boolean? Subsetted
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Subsetted);
    }
    set
    {
      _ExistingElement.Subsetted = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
