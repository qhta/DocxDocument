namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the NumberingFormat Class.
/// </summary>
public partial class NumberingFormat: ModelElement<DXO13DC.NumberingFormat>
{
  public NumberingFormat(): base(){ }
  
  public NumberingFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingFormat(DXO13DC.NumberingFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Number Format Code
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FormatCode);
    }
    set
    {
      _ExistingElement.FormatCode = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Linked to Source
  /// </summary>
  [DataMember]
  public Boolean? SourceLinked
  {
    get
    {
      return _Element?.SourceLinked?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SourceLinked = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SourceLinked = null;
    }
  }
  
}
