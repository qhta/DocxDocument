namespace DocumentModel.Wordprocessing;
/// <summary>
/// Relationship to embedded font part where embedded font data is stored.
/// This relationship is used to link font definitions in the document to their corresponding embedded font data parts, allowing for proper rendering of fonts that are not available on the user's system.
/// </summary>
[OpenXmlType(typeof(DXW.FontRelationshipType))]
[XmlRoot("FontRelationshipType", Namespace = "DocumentModel.Wordprocessing")]
public class FontRelationshipType : ModelElement<DXW.FontRelationshipType>
{
 /// <summary>
 /// Identifier of the relationship, corresponding to the 'r:id' attribute in the Open XML schema.
 /// This property is used to link the relationship to a specific part or resource within the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FontRelationshipType.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }
 private string? _Id;

 /// <summary>
 /// Specifies the key which was used to obfuscate this embedded font. This key can be used
 /// to retrieve the embedded font for the purposes of viewing this WordprocessingML
 ///  document only, using the algorithm described in §17.8.1.    
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FontRelationshipType.FontKey))]
 public Guid? FontKey { get => _FontKey; set => UpdateField(ref _FontKey, value, nameof(FontKey)); }
 private Guid? _FontKey;

 /// <summary>
 /// Specifies that the embedded font targeted by the id attribute has been subsetted.
 /// Subsetting is a mechanism by which only the glyphs used in the contents of this
 /// WordprocessingML document are stored in an embedded font, in order to prevent the
 /// file from becoming unnecessarily large from the use of a small number of glyphs from a
 /// large embedded font.  
 /// </summary>
 [OpenXmlProperty(nameof(DXW.FontRelationshipType.Subsetted))]
 public bool? Subsetted { get => _Subsetted; set => UpdateField(ref _Subsetted, value, nameof(Subsetted)); }
 private bool? _Subsetted;
///// <summary>
///// Attaches the specified WordprocessingDocument and loads its data into the current instance.
///// </summary>
///// <param name = "wordprocessingDocument">The WordprocessingDocument to attach and load.</param>
//public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
//{
//  base.AttachAndLoad(wordprocessingDocument);
//  if (WordprocessingDocument == null)
//    return;
//  LoadData(WordprocessingDocument);
//}
///// <summary>
///// Attaches the specified WordprocessingDocument and updates the associated data.
///// </summary>
///// <param name = "wordprocessingDocument">The WordprocessingDocument to attach and use for updating data.</param>
//public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
//{
//  base.AttachAndUpdate(wordprocessingDocument);
//  if (WordprocessingDocument == null)
//    return;
//  UpdateData(WordprocessingDocument);
//}
///// <summary>
///// Updates the internal data by loading information from the specified Open XML element.
///// </summary>
///// <remarks>If the associated Document is not available, the method does not perform any
///// update.</remarks>
///// <param name = "openXmlObject">The Open XML element from which to load data. This parameter must represent a valid Open XML element associated
///// with a Document.</param>
//public override void UpdateData(object openXmlObject)
//{
//  if (WordprocessingDocument == null)
//    return;
//  UpdateData(WordprocessingDocument);
//}
///// <summary>
///// Loads data from the specified Document into the current instance.
///// </summary>
///// <remarks>This method updates the Id and Uri properties based on the relationship information found in the
///// provided document, if available. If the relevant relationship is not present, the properties remain
///// unchanged.</remarks>
///// <param name = "document">The Document from which to load data.</param>
//public virtual void LoadData(DXPP.WordprocessingDocument document)
//{
//  DXW.FontRelationshipType? updatedElement = (DXW.FontRelationshipType?)GetUpdatableElement();
//  if (updatedElement != null)
//  {
//    Id = updatedElement.Id;
//      FontKey = updatedElement.FontKey;
//  }
//}
///// <summary>
///// Updates the specified Document with the current Id and Uri values.
///// </summary>
///// <remarks>This method sets the Id property and, if specified, the Uri property on the relationship element
///// within the provided document. The document must contain a relationship element compatible with the update
///// operation.</remarks>
///// <param name = "document">The Document to update with new relationship data. Cannot be null.</param>
//public virtual void UpdateData(DXPP.WordprocessingDocument document)
//{
//  DXW.FontRelationshipType? updatedElement = (DXW.FontRelationshipType?)GetUpdatableElement();
//  if (updatedElement != null)
//  {
//    updatedElement.Id = Id;
//  }
//}
}