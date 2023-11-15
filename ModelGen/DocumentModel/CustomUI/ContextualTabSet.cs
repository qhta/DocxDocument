namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the ContextualTabSet Class.
/// </summary>
public partial class ContextualTabSet: ModelElement<DXOCUI.ContextualTabSet>
{
  public ContextualTabSet(): base(){ }
  
  public ContextualTabSet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContextualTabSet(DXOCUI.ContextualTabSet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idMso
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get => _Element?.IdMso;
    set => _ExistingElement.IdMso = value;
  }
  
  
  /// <summary>
  ///   visible
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   getVisible
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get => _Element?.GetVisible;
    set => _ExistingElement.GetVisible = value;
  }
  
}
