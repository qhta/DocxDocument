namespace DocumentModel;
public partial class BuiltInProperties : DMPr.IDocumentProperties
{
 IEnumerator<DMPr.IDocumentProperty> IEnumerable<DMPr.IDocumentProperty>.GetEnumerator() => this.GetEnumerator();
 DMPr.IDocumentProperty IModelCollection<DMPr.IDocumentProperty>.this[object index]
 {
  get
  {
   if (index is string propertyName)
    if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
     index = mappedName;
   return this[(string)index];
  }

  set
  {
   if (index is string propertyName)
    if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
     index = mappedName;
   this[(string)index] = (BuiltInProperty)value;
  }
 }
 private static readonly BiDiDictionary<string, string> propertyNameMapping = new()
 {
  {
   "Title",
   "Title"
  },
  {
   "Subject",
   "Subject"
  },
  {
   "Creator",
   "Author"
  },
  {
   "Keywords",
   "Keywords"
  },
  {
   "Description",
   "Comments"
  },
  {
   "LastModifiedBy",
   "LastAuthor"
  },
  {
   "Revision",
   "RevisionNumber"
  },
  {
   "Created",
   "CreationDate"
  },
  {
   "Modified",
   "ModificationDate"
  },
 };
}
