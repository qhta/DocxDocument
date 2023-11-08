namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies any East Asian typography settings which shall be applied to the contents of the run.
/// </summary>
public partial class EastAsianLayout: ModelElement<DXW.EastAsianLayout>
{
  public EastAsianLayout(): base(){ }
  
  public EastAsianLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EastAsianLayout(DXW.EastAsianLayout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   East Asian Typography Run ID
  /// </summary>
  [DataMember]
  public Int32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  
  /// <summary>
  ///   Two Lines in One
  /// </summary>
  [DataMember]
  public Boolean? Combine
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Combine);
    }
    set
    {
      _ExistingElement.Combine = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Horizontal in Vertical (Rotate Text)
  /// </summary>
  [DataMember]
  public Boolean? Vertical
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Vertical);
    }
    set
    {
      _ExistingElement.Vertical = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Compress Rotated Text to Line Height
  /// </summary>
  [DataMember]
  public Boolean? VerticalCompress
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.VerticalCompress);
    }
    set
    {
      _ExistingElement.VerticalCompress = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
