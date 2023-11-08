namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Caption Type Definition.
/// </summary>
public partial class Caption: ModelElement<DXW.Caption>
{
  public Caption(): base(){ }
  
  public Caption(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Caption(DXW.Caption openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Caption Type Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Include Chapter Number in Field for Caption
  /// </summary>
  [DataMember]
  public Boolean? ChapterNumber
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.ChapterNumber);
    }
    set
    {
      _ExistingElement.ChapterNumber = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Style for Chapter Headings
  /// </summary>
  [DataMember]
  public Int32? Heading
  {
    get
    {
      return _Element?.Heading?.Value;
    }
    set
    {
      _ExistingElement.Heading = value;
    }
  }
  
  
  /// <summary>
  ///   Do Not Include Name In Caption
  /// </summary>
  [DataMember]
  public Boolean? NoLabel
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.NoLabel);
    }
    set
    {
      _ExistingElement.NoLabel = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
