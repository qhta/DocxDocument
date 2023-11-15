namespace DocumentModel.CustomUI;


/// <summary>
///   Defines the DynamicMenu Class.
/// </summary>
public partial class DynamicMenu: ModelElement<DXOCUI.DynamicMenu>
{
  public DynamicMenu(): base(){ }
  
  public DynamicMenu(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DynamicMenu(DXOCUI.DynamicMenu openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   getSize
  /// </summary>
  [DataMember]
  public String? GetSize
  {
    get => _Element?.GetSize;
    set => _ExistingElement.GetSize = value;
  }
  
  
  /// <summary>
  ///   description
  /// </summary>
  [DataMember]
  public String? Description
  {
    get => _Element?.Description;
    set => _ExistingElement.Description = value;
  }
  
  
  /// <summary>
  ///   getDescription
  /// </summary>
  [DataMember]
  public String? GetDescription
  {
    get => _Element?.GetDescription;
    set => _ExistingElement.GetDescription = value;
  }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   idQ
  /// </summary>
  [DataMember]
  public String? IdQ
  {
    get => _Element?.IdQ;
    set => _ExistingElement.IdQ = value;
  }
  
  
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
  ///   tag
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get => _Element?.Tag;
    set => _ExistingElement.Tag = value;
  }
  
  
  /// <summary>
  ///   getContent
  /// </summary>
  [DataMember]
  public String? GetContent
  {
    get => _Element?.GetContent;
    set => _ExistingElement.GetContent = value;
  }
  
  
  /// <summary>
  ///   invalidateContentOnDrop
  /// </summary>
  [DataMember]
  public Boolean? InvalidateContentOnDrop
  {
    get => _Element?.InvalidateContentOnDrop?.Value;
    set => _ExistingElement.InvalidateContentOnDrop = value;
  }
  
  
  /// <summary>
  ///   image
  /// </summary>
  [DataMember]
  public String? Image
  {
    get => _Element?.Image;
    set => _ExistingElement.Image = value;
  }
  
  
  /// <summary>
  ///   imageMso
  /// </summary>
  [DataMember]
  public String? ImageMso
  {
    get => _Element?.ImageMso;
    set => _ExistingElement.ImageMso = value;
  }
  
  
  /// <summary>
  ///   getImage
  /// </summary>
  [DataMember]
  public String? GetImage
  {
    get => _Element?.GetImage;
    set => _ExistingElement.GetImage = value;
  }
  
  
  /// <summary>
  ///   screentip
  /// </summary>
  [DataMember]
  public String? Screentip
  {
    get => _Element?.Screentip;
    set => _ExistingElement.Screentip = value;
  }
  
  
  /// <summary>
  ///   getScreentip
  /// </summary>
  [DataMember]
  public String? GetScreentip
  {
    get => _Element?.GetScreentip;
    set => _ExistingElement.GetScreentip = value;
  }
  
  
  /// <summary>
  ///   supertip
  /// </summary>
  [DataMember]
  public String? Supertip
  {
    get => _Element?.Supertip;
    set => _ExistingElement.Supertip = value;
  }
  
  
  /// <summary>
  ///   getSupertip
  /// </summary>
  [DataMember]
  public String? GetSupertip
  {
    get => _Element?.GetSupertip;
    set => _ExistingElement.GetSupertip = value;
  }
  
  
  /// <summary>
  ///   enabled
  /// </summary>
  [DataMember]
  public Boolean? Enabled
  {
    get => _Element?.Enabled?.Value;
    set => _ExistingElement.Enabled = value;
  }
  
  
  /// <summary>
  ///   getEnabled
  /// </summary>
  [DataMember]
  public String? GetEnabled
  {
    get => _Element?.GetEnabled;
    set => _ExistingElement.GetEnabled = value;
  }
  
  
  /// <summary>
  ///   label
  /// </summary>
  [DataMember]
  public String? Label
  {
    get => _Element?.Label;
    set => _ExistingElement.Label = value;
  }
  
  
  /// <summary>
  ///   getLabel
  /// </summary>
  [DataMember]
  public String? GetLabel
  {
    get => _Element?.GetLabel;
    set => _ExistingElement.GetLabel = value;
  }
  
  
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  [DataMember]
  public String? InsertAfterMso
  {
    get => _Element?.InsertAfterMso;
    set => _ExistingElement.InsertAfterMso = value;
  }
  
  
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  [DataMember]
  public String? InsertBeforeMso
  {
    get => _Element?.InsertBeforeMso;
    set => _ExistingElement.InsertBeforeMso = value;
  }
  
  
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  [DataMember]
  public String? InsertAfterQ
  {
    get => _Element?.InsertAfterQ;
    set => _ExistingElement.InsertAfterQ = value;
  }
  
  
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  [DataMember]
  public String? InsertBeforeQ
  {
    get => _Element?.InsertBeforeQ;
    set => _ExistingElement.InsertBeforeQ = value;
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
  
  
  /// <summary>
  ///   keytip
  /// </summary>
  [DataMember]
  public String? Keytip
  {
    get => _Element?.Keytip;
    set => _ExistingElement.Keytip = value;
  }
  
  
  /// <summary>
  ///   getKeytip
  /// </summary>
  [DataMember]
  public String? GetKeytip
  {
    get => _Element?.GetKeytip;
    set => _ExistingElement.GetKeytip = value;
  }
  
  
  /// <summary>
  ///   showLabel
  /// </summary>
  [DataMember]
  public Boolean? ShowLabel
  {
    get => _Element?.ShowLabel?.Value;
    set => _ExistingElement.ShowLabel = value;
  }
  
  
  /// <summary>
  ///   getShowLabel
  /// </summary>
  [DataMember]
  public String? GetShowLabel
  {
    get => _Element?.GetShowLabel;
    set => _ExistingElement.GetShowLabel = value;
  }
  
  
  /// <summary>
  ///   showImage
  /// </summary>
  [DataMember]
  public Boolean? ShowImage
  {
    get => _Element?.ShowImage?.Value;
    set => _ExistingElement.ShowImage = value;
  }
  
  
  /// <summary>
  ///   getShowImage
  /// </summary>
  [DataMember]
  public String? GetShowImage
  {
    get => _Element?.GetShowImage;
    set => _ExistingElement.GetShowImage = value;
  }
  
}
