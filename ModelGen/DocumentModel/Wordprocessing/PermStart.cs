namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PermStart Class.
/// </summary>
public partial class PermStart: ModelElement<DXW.PermStart>
{
  public PermStart(): base(){ }
  
  public PermStart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PermStart(DXW.PermStart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ed
  /// </summary>
  [DataMember]
  public String? Ed
  {
    get => _Element?.Ed;
    set => _ExistingElement.Ed = value;
  }
  
  
  /// <summary>
  ///   colFirst
  /// </summary>
  [DataMember]
  public Int32? ColumnFirst
  {
    get => _Element?.ColumnFirst?.Value;
    set => _ExistingElement.ColumnFirst = value;
  }
  
  
  /// <summary>
  ///   colLast
  /// </summary>
  [DataMember]
  public Int32? ColumnLast
  {
    get => _Element?.ColumnLast?.Value;
    set => _ExistingElement.ColumnLast = value;
  }
  
  
  /// <summary>
  ///   Annotation ID
  /// </summary>
  [DataMember]
  public Int32? Id
  {
    get => _Element?.Id?.Value;
    set => _ExistingElement.Id = value;
  }
  
}
