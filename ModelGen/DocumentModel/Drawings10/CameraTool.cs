namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the CameraTool Class.
/// </summary>
public partial class CameraTool: ModelElement<DXO10D.CameraTool>
{
  public CameraTool(): base(){ }
  
  public CameraTool(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CameraTool(DXO10D.CameraTool openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? CellRange
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CellRange);
    }
    set
    {
      _ExistingElement.CellRange = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ShapeId);
    }
    set
    {
      _ExistingElement.ShapeId = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
