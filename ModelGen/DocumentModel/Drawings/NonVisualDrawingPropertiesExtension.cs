namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an extension that is used for future extensions to the current version of DrawingML. This allows for the specifying of currently unknown elements in the future that is used for later versions of generating applications.
/// </summary>
public partial class NonVisualDrawingPropertiesExtension: ModelElement<DXD.NonVisualDrawingPropertiesExtension>
{
  public NonVisualDrawingPropertiesExtension(): base(){ }
  
  public NonVisualDrawingPropertiesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualDrawingPropertiesExtension(DXD.NonVisualDrawingPropertiesExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMD10.CompatExtension? CompatExtension
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10D.CompatExtension>();
      if (element != null)
        return CompatExtensionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10D.CompatExtension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CompatExtensionConverter.CreateOpenXmlElement<DXO10D.CompatExtension>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BackgroundProperties? BackgroundProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13D.BackgroundProperties>();
      if (element != null)
        return BackgroundPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13D.BackgroundProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundPropertiesConverter.CreateOpenXmlElement<DXO13D.BackgroundProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.CreationId? CreationId
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16D.CreationId>();
      if (element != null)
        return CreationIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16D.CreationId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreationIdConverter.CreateOpenXmlElement<DXO16D.CreationId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PredecessorDrawingElementReference? PredecessorDrawingElementReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16D.PredecessorDrawingElementReference>();
      if (element != null)
        return PredecessorDrawingElementReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16D.PredecessorDrawingElementReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PredecessorDrawingElementReferenceConverter.CreateOpenXmlElement<DXO16D.PredecessorDrawingElementReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public Boolean? Decorative
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXO19D.Decorative>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXO19D.Decorative>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXO19D.Decorative();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ClassificationOutcome? ClassificationOutcome
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DDC.ClassificationOutcome>();
      if (element != null)
        return ClassificationOutcomeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DDC.ClassificationOutcome>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ClassificationOutcomeConverter.CreateOpenXmlElement<DXO21DDC.ClassificationOutcome>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDSL.ScriptLink? ScriptLink
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD21SL.ScriptLink>();
      if (element != null)
        return ScriptLinkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD21SL.ScriptLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScriptLinkConverter.CreateOpenXmlElement<DXOD21SL.ScriptLink>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
