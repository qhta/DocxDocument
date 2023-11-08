namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public partial class LinePropertiesType: ModelElement<DXD.LinePropertiesType>
{
  public LinePropertiesType(): base(){ }
  
  public LinePropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinePropertiesType(DXD.LinePropertiesType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   line width
  /// </summary>
  [DataMember]
  public Int32? Width
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
