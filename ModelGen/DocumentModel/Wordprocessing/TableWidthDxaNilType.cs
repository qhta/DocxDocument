namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableWidthDxaNilType Class.
/// </summary>
public partial class TableWidthDxaNilType: ModelElement<DXW.TableWidthDxaNilType>
{
  public TableWidthDxaNilType(): base(){ }
  
  public TableWidthDxaNilType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableWidthDxaNilType(DXW.TableWidthDxaNilType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w
  /// </summary>
  [DataMember]
  public Int16? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
}
