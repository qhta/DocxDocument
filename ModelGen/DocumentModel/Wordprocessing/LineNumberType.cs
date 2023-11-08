namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineNumberType Class.
/// </summary>
public partial class LineNumberType: ModelElement<DXW.LineNumberType>
{
  public LineNumberType(): base(){ }
  
  public LineNumberType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineNumberType(DXW.LineNumberType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Line Number Increments to Display
  /// </summary>
  [DataMember]
  public Int16? CountBy
  {
    get
    {
      return _Element?.CountBy?.Value;
    }
    set
    {
      _ExistingElement.CountBy = value;
    }
  }
  
  
  /// <summary>
  ///   Line Numbering Starting Value
  /// </summary>
  [DataMember]
  public Int16? Start
  {
    get
    {
      return _Element?.Start?.Value;
    }
    set
    {
      _ExistingElement.Start = value;
    }
  }
  
  
  /// <summary>
  ///   Distance Between Text and Line Numbering
  /// </summary>
  [DataMember]
  public String? Distance
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Distance);
    }
    set
    {
      _ExistingElement.Distance = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
