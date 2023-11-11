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
      return _Element?.GetObject<DMDCD10.NonVisualContentPartProperties,DXO10DCD.NonVisualContentPartProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD10.NonVisualContentPartProperties,DXO10DCD.NonVisualContentPartProperties>(value);
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
      return _Element?.GetObject<DMDCD10.ApplicationNonVisualDrawingProperties,DXO10DCD.ApplicationNonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD10.ApplicationNonVisualDrawingProperties,DXO10DCD.ApplicationNonVisualDrawingProperties>(value);
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
      return _Element?.GetObject<DMDCD10.Transform2D,DXO10DCD.Transform2D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD10.Transform2D,DXO10DCD.Transform2D>(value);
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
      return _Element?.GetObject<DMDCD10.OfficeArtExtensionList,DXO10DCD.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD10.OfficeArtExtensionList,DXO10DCD.OfficeArtExtensionList>(value);
    }
  }
  
}
