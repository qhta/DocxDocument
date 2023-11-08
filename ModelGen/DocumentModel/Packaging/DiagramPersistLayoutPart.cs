namespace DocumentModel.Packaging;


/// <summary>
///   Defines the DiagramPersistLayoutPart
/// </summary>
public partial class DiagramPersistLayoutPart: ModelElement<DXPack.DiagramPersistLayoutPart>
{
  public DiagramPersistLayoutPart(): base(){ }
  
  public DiagramPersistLayoutPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramPersistLayoutPart(DXPack.DiagramPersistLayoutPart openXmlElement): base(openXmlElement) { }
  
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
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  [DataMember]
  public DMDO.Drawing? Drawing
  {
    get
    {
        return DrawingConverter.CreateModelElement(_Element?.RootElement as DXOD.Drawing);
    }
    set
    {
      if (value != null)
      {
         var rootElement = DrawingConverter.CreateOpenXmlElement<DXOD.Drawing>(value);
         if (rootElement != null)
           _ExistingElement.Drawing = rootElement;
      }
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
  
}
