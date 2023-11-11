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
      return _Element?.GetObject<DMD10.CompatExtension,DXO10D.CompatExtension>();
    }
    set
    {
      _ExistingElement.SetObject<DMD10.CompatExtension,DXO10D.CompatExtension>(value);
    }
  }
  
  [DataMember]
  public DMD.BackgroundProperties? BackgroundProperties
  {
    get
    {
      return _Element?.GetObject<DMD.BackgroundProperties,DXO13D.BackgroundProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BackgroundProperties,DXO13D.BackgroundProperties>(value);
    }
  }
  
  [DataMember]
  public DMD.CreationId? CreationId
  {
    get
    {
      return _Element?.GetObject<DMD.CreationId,DXO16D.CreationId>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CreationId,DXO16D.CreationId>(value);
    }
  }
  
  [DataMember]
  public DMD.PredecessorDrawingElementReference? PredecessorDrawingElementReference
  {
    get
    {
      return _Element?.GetObject<DMD.PredecessorDrawingElementReference,DXO16D.PredecessorDrawingElementReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PredecessorDrawingElementReference,DXO16D.PredecessorDrawingElementReference>(value);
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
      return _Element?.GetObject<DMD.ClassificationOutcome,DXO21DDC.ClassificationOutcome>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ClassificationOutcome,DXO21DDC.ClassificationOutcome>(value);
    }
  }
  
  [DataMember]
  public DMDSL.ScriptLink? ScriptLink
  {
    get
    {
      return _Element?.GetObject<DMDSL.ScriptLink,DXOD21SL.ScriptLink>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSL.ScriptLink,DXOD21SL.ScriptLink>(value);
    }
  }
  
}
