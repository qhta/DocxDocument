namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the TabSet Class.
/// </summary>
public partial class TabSet: ModelElement<DXO10CUI.TabSet>
{
  public TabSet(): base(){ }
  
  public TabSet(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TabSet(DXO10CUI.TabSet openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get => _Element?.IdMso;
    set => _ExistingElement.IdMso = value;
  }
  
  
  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Visible
  {
    get => _Element?.Visible?.Value;
    set => _ExistingElement.Visible = value;
  }
  
  
  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetVisible
  {
    get => _Element?.GetVisible;
    set => _ExistingElement.GetVisible = value;
  }
  
}
