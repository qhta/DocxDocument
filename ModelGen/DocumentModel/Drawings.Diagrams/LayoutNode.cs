namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Layout Node.
/// </summary>
public partial class LayoutNode: ModelElement<DXDDD.LayoutNode>
{
  public LayoutNode(): base(){ }
  
  public LayoutNode(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutNode(DXDDD.LayoutNode openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Style Label
  /// </summary>
  [DataMember]
  public String? StyleLabel
  {
    get => _Element?.StyleLabel;
    set => _ExistingElement.StyleLabel = value;
  }
  
  
  /// <summary>
  ///   Move With
  /// </summary>
  [DataMember]
  public String? MoveWith
  {
    get => _Element?.MoveWith;
    set => _ExistingElement.MoveWith = value;
  }
  
}
