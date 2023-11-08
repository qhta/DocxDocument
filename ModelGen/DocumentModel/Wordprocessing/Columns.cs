namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Columns Class.
/// </summary>
public partial class Columns: ModelElement<DXW.Columns>
{
  public Columns(): base(){ }
  
  public Columns(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Columns(DXW.Columns openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Equal Column Widths
  /// </summary>
  [DataMember]
  public Boolean? EqualWidth
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.EqualWidth);
    }
    set
    {
      _ExistingElement.EqualWidth = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Spacing Between Equal Width Columns
  /// </summary>
  [DataMember]
  public String? Space
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Space);
    }
    set
    {
      _ExistingElement.Space = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Number of Equal Width Columns
  /// </summary>
  [DataMember]
  public Int16? ColumnCount
  {
    get
    {
      return _Element?.ColumnCount?.Value;
    }
    set
    {
      _ExistingElement.ColumnCount = value;
    }
  }
  
  
  /// <summary>
  ///   Draw Line Between Columns
  /// </summary>
  [DataMember]
  public Boolean? Separator
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Separator);
    }
    set
    {
      _ExistingElement.Separator = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
