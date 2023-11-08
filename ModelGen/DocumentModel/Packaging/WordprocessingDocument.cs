namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WordprocessingDocument
/// </summary>
public partial class WordprocessingDocument: ModelElement<DXPack.WordprocessingDocument>
{
  public WordprocessingDocument(): base(){ }
  
  public WordprocessingDocument(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WordprocessingDocument(DXPack.WordprocessingDocument openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets the type of the WordprocessingDocument.
  /// </summary>
  [DataMember]
  public DM.WordprocessingDocumentType? DocumentType
  {
    get
    {
      if (_Element?.DocumentType != null)
        return EnumValueConverter.GetValue<DX.WordprocessingDocumentType, DM.WordprocessingDocumentType>(_Element?.DocumentType);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.DocumentType = EnumValueConverter.GetValue<DM.WordprocessingDocumentType, DX.WordprocessingDocumentType>(value);
    }
  }
  
}
