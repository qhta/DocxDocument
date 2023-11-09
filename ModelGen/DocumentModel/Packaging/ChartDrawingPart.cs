namespace DocumentModel.Packaging;


/// <summary>
///   Defines the ChartDrawingPart
/// </summary>
public partial class ChartDrawingPart: ModelPartElement<DXPack.ChartDrawingPart>
{
  public ChartDrawingPart(): base(){ }
  
  public ChartDrawingPart(DXPack.OpenXmlPart openXmlElement): base(openXmlElement) { }
  
  public ChartDrawingPart(DXPack.ChartDrawingPart openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public String? ContentType
  {
    get
    {
      return _Element?.ContentType;
    }
    set
    {
      _ExistingElement.ContentType = value;
    }
  }
  
  [DataMember]
  public String? RelationshipType
  {
    get
    {
      return _Element?.RelationshipType;
    }
    set
    {
      _ExistingElement.RelationshipType = value;
    }
  }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDC.UserShapes? UserShapes
  {
    get
    {
        return UserShapesConverter.CreateModelElement(_Element?.RootElement as DXDC.UserShapes);
    }
    set
    {
      if (value != null)
      {
         var rootElement = UserShapesConverter.CreateOpenXmlElement<DXDC.UserShapes>(value);
         if (rootElement != null)
           _ExistingElement.UserShapes = rootElement;
      }
    }
  }
  
}
