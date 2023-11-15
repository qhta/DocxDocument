namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Column Definition.
/// </summary>
public partial class Column: ModelElement<DXW.Column>
{
  public Column(): base(){ }
  
  public Column(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Column(DXW.Column openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Column Width
  /// </summary>
  [DataMember]
  public String? Width
  {
    get => _Element?.Width;
    set => _ExistingElement.Width = value;
  }
  
  
  /// <summary>
  ///   Space Before Following Column
  /// </summary>
  [DataMember]
  public String? Space
  {
    get => _Element?.Space;
    set => _ExistingElement.Space = value;
  }
  
}
