namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class NonVisualPicturePropertiesExtension: ModelElement<DXD.NonVisualPicturePropertiesExtension>
{
  public NonVisualPicturePropertiesExtension(): base(){ }
  
  public NonVisualPicturePropertiesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualPicturePropertiesExtension(DXD.NonVisualPicturePropertiesExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMD10.CameraTool? CameraTool
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.CameraTool>();
      if (element != null)
        return CameraToolConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.CameraTool>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CameraToolConverter.CreateOpenXmlElement<DXO10D.CameraTool>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SignatureLine? SignatureLine
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13D.SignatureLine>();
      if (element != null)
        return SignatureLineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13D.SignatureLine>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SignatureLineConverter.CreateOpenXmlElement<DXO13D.SignatureLine>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ObjectProperties? ObjectProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13D.ObjectProperties>();
      if (element != null)
        return ObjectPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13D.ObjectProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectPropertiesConverter.CreateOpenXmlElement<DXO13D.ObjectProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.LiveFeedProperties? LiveFeedProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DL.LiveFeedProperties>();
      if (element != null)
        return LiveFeedPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DL.LiveFeedProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LiveFeedPropertiesConverter.CreateOpenXmlElement<DXO21DL.LiveFeedProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDIF.ImageFormula? ImageFormula
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD22IF.ImageFormula>();
      if (element != null)
        return ImageFormulaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD22IF.ImageFormula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageFormulaConverter.CreateOpenXmlElement<DXOD22IF.ImageFormula>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
