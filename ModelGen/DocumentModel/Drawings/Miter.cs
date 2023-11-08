namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a line join shall be mitered.
/// </summary>
public partial class Miter: ModelElement<DXD.Miter>
{
  public Miter(): base(){ }
  
  public Miter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Miter(DXD.Miter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the amount by which lines is extended to form a miter join - otherwise miter
  /// </summary>
  [DataMember]
  public Int32? Limit
  {
    get
    {
      return _Element?.Limit?.Value;
    }
    set
    {
      _ExistingElement.Limit = value;
    }
  }
  
}
