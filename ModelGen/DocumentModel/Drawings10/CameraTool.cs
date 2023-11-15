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
    get => _Element?.CellRange;
    set => _ExistingElement.CellRange = value;
  }
  
  
  /// <summary>
  ///   spid, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get => _Element?.ShapeId;
    set => _ExistingElement.ShapeId = value;
  }
  
}
