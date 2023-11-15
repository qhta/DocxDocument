namespace DocumentModel.Word10;


/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public partial class MarkupType: ModelElement<DXO10W.MarkupType>
{
  public MarkupType(): base(){ }
  
  public MarkupType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MarkupType(DXO10W.MarkupType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
