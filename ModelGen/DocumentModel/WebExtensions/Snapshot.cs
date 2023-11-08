namespace DocumentModel.WebExtensions;


/// <summary>
///   Defines the Snapshot Class.
/// </summary>
public partial class Snapshot: ModelElement<DXO13WE.Snapshot>
{
  public Snapshot(): base(){ }
  
  public Snapshot(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Snapshot(DXO13WE.Snapshot openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [DataMember]
  public String? Embed
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Embed);
    }
    set
    {
      _ExistingElement.Embed = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [DataMember]
  public String? Link
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Link);
    }
    set
    {
      _ExistingElement.Link = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMD.BlipExtensionList? BlipExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BlipExtensionList>();
      if (element != null)
        return BlipExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BlipExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipExtensionListConverter.CreateOpenXmlElement<DXD.BlipExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
