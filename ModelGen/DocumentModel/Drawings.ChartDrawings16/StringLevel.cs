namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the StringLevel Class.
/// </summary>
public partial class StringLevel: ModelElement<DXO16DCD.StringLevel>
{
  public StringLevel(): base(){ }
  
  public StringLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringLevel(DXO16DCD.StringLevel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? PtCount
  {
    get
    {
      return _Element?.PtCount?.Value;
    }
    set
    {
      _ExistingElement.PtCount = value;
    }
  }
  
  
  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
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
  
}
