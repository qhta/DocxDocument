namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public partial class ContentPart: ModelElement<DXO10DCD.ContentPart>
{
  public ContentPart(): base(){ }
  
  public ContentPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContentPart(DXO10DCD.ContentPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelationshipId);
    }
    set
    {
      _ExistingElement.RelationshipId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   NonVisualContentPartProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.NonVisualContentPartProperties? NonVisualContentPartProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DCD.NonVisualContentPartProperties>();
      if (element != null)
        return NonVisualContentPartPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DCD.NonVisualContentPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualContentPartPropertiesConverter.CreateOpenXmlElement<DXO10DCD.NonVisualContentPartProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ApplicationNonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DCD.ApplicationNonVisualDrawingProperties>();
      if (element != null)
        return ApplicationNonVisualDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DCD.ApplicationNonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ApplicationNonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO10DCD.ApplicationNonVisualDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Transform2D.
  /// </summary>
  [DataMember]
  public DMDCD10.Transform2D? Transform2D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DCD.Transform2D>();
      if (element != null)
        return Transform2DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DCD.Transform2D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Transform2DConverter.CreateOpenXmlElement<DXO10DCD.Transform2D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD10.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DCD.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DCD.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO10DCD.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
