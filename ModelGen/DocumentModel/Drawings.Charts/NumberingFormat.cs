namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Format.
/// </summary>
public partial class NumberingFormat: ModelElement<DXDC.NumberingFormat>
{
  public NumberingFormat(): base(){ }
  
  public NumberingFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingFormat(DXDC.NumberingFormat openXmlElement): base(openXmlElement) { }
  
  
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
        _ExistingElement.SourceLinked = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SourceLinked = null;
    }
  }
  
}
