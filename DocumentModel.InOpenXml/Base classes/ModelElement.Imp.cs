#pragma warning disable CS0659
namespace DocumentModel;
public abstract partial class ModelElement : IModelObject, IDocumentElement
{
 /// <summary>
 /// Gets the parent document that contains this element, if available.
 /// </summary>
 /// <remarks>This property traverses the parent or collection hierarchy to locate the nearest containing
 /// document. If the element is not part of a document, the property returns null.</remarks>
 [NotMapped]
 [XmlIgnore]
 [JsonIgnore]
 public DMW.Document? ParentDocument
 {
  get
  {
   if (Parent is DMW.Document document)
    return document;
   if (Parent is IDocumentElement parentElement)
    return parentElement.ParentDocument;
   if (Collection is IDocumentElement collectionElement)
    return collectionElement.ParentDocument;
   return null;
  }
 }
}
