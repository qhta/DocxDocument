namespace DocumentModel.Packaging;


/// <summary>
///   An instance of this part type contains information about each of the fonts used by content in the document. When a consumer reads a WordprocessingML document, it shall use this information to determine which fonts to use to display the document when the specified fonts are not available on the consumer’s system.
/// </summary>
public partial class FontTablePart: ModelElement<DXPack.FontTablePart>
{
  public FontTablePart(): base(){ }
  
  public FontTablePart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontTablePart(DXPack.FontTablePart openXmlElement): base(openXmlElement) { }
  
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
  public DMW.Fonts? Fonts
  {
    get
    {
        return FontsConverter.CreateModelElement(_Element?.RootElement as DXW.Fonts);
    }
    set
    {
      if (value != null)
      {
         var rootElement = FontsConverter.CreateOpenXmlElement<DXW.Fonts>(value);
         if (rootElement != null)
           _ExistingElement.Fonts = rootElement;
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
