namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class DataModelExtension: ModelElement<DXD.DataModelExtension>
{
  public DataModelExtension(): base(){ }
  
  public DataModelExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModelExtension(DXD.DataModelExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the URI, or uniform resource identifier that represents the data stored under this tag. The URI is used to identify the correct 'server' that can process the contents of this tag.
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDO.DataModelExtensionBlock? DataModelExtensionBlock
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.DataModelExtensionBlock>();
      if (element != null)
        return DataModelExtensionBlockConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.DataModelExtensionBlock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelExtensionBlockConverter.CreateOpenXmlElement<DXOD.DataModelExtensionBlock>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public Boolean? RecolorImages
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXO10DD.RecolorImages>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXO10DD.RecolorImages>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXO10DD.RecolorImages();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
