namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the inter-line and inter-paragraph spacing which shall be applied to the contents of this paragraph when it is displayed by a consumer.
/// </summary>
public partial class SpacingBetweenLines: ModelElement<DXW.SpacingBetweenLines>
{
  public SpacingBetweenLines(): base(){ }
  
  public SpacingBetweenLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpacingBetweenLines(DXW.SpacingBetweenLines openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Spacing Above Paragraph
  /// </summary>
  [DataMember]
  public String? Before
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Before);
    }
    set
    {
      _ExistingElement.Before = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Spacing Above Paragraph IN Line Units
  /// </summary>
  [DataMember]
  public Int32? BeforeLines
  {
    get
    {
      return _Element?.BeforeLines?.Value;
    }
    set
    {
      _ExistingElement.BeforeLines = value;
    }
  }
  
  
  /// <summary>
  ///   Automatically Determine Spacing Above Paragraph
  /// </summary>
  [DataMember]
  public Boolean? BeforeAutoSpacing
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.BeforeAutoSpacing);
    }
    set
    {
      _ExistingElement.BeforeAutoSpacing = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Spacing Below Paragraph
  /// </summary>
  [DataMember]
  public String? After
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.After);
    }
    set
    {
      _ExistingElement.After = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Spacing Below Paragraph in Line Units
  /// </summary>
  [DataMember]
  public Int32? AfterLines
  {
    get
    {
      return _Element?.AfterLines?.Value;
    }
    set
    {
      _ExistingElement.AfterLines = value;
    }
  }
  
  
  /// <summary>
  ///   Automatically Determine Spacing Below Paragraph
  /// </summary>
  [DataMember]
  public Boolean? AfterAutoSpacing
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.AfterAutoSpacing);
    }
    set
    {
      _ExistingElement.AfterAutoSpacing = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Spacing Between Lines in Paragraph
  /// </summary>
  [DataMember]
  public String? Line
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Line);
    }
    set
    {
      _ExistingElement.Line = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
