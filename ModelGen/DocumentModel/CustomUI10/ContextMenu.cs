namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the ContextMenu Class.
/// </summary>
public partial class ContextMenu: ModelElement<DXO10CUI.ContextMenu>
{
  public ContextMenu(): base(){ }
  
  public ContextMenu(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContextMenu(DXO10CUI.ContextMenu openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? IdMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.IdMso);
    }
    set
    {
      _ExistingElement.IdMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
