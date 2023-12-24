namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the MenuSeparator Class.
/// </summary>
public partial class MenuSeparator: ModelElement<DXO10CUI.MenuSeparator>
{
  public MenuSeparator(): base(){ }
  
  public MenuSeparator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MenuSeparator(DXO10CUI.MenuSeparator openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? QualifiedId
  {
    get => _Element?.QualifiedId;
    set => _ExistingElement.QualifiedId = value;
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
  
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertAfterMso
  {
    get => _Element?.InsertAfterMso;
    set => _ExistingElement.InsertAfterMso = value;
  }
  
  
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeMso
  {
    get => _Element?.InsertBeforeMso;
    set => _ExistingElement.InsertBeforeMso = value;
  }
  
  
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertAfterQulifiedId
  {
    get => _Element?.InsertAfterQulifiedId;
    set => _ExistingElement.InsertAfterQulifiedId = value;
  }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeQulifiedId
  {
    get => _Element?.InsertBeforeQulifiedId;
    set => _ExistingElement.InsertBeforeQulifiedId = value;
  }
  
  
  /// <summary>
  ///   title, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetTitle
  {
    get => _Element?.GetTitle;
    set => _ExistingElement.GetTitle = value;
  }
  
}
