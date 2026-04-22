namespace DocumentModel;
public partial class BuiltInProperties : DMP.IDocumentProperties
{
 IEnumerator<DMP.IDocumentProperty> IEnumerable<DMP.IDocumentProperty>.GetEnumerator() => this.GetEnumerator();
 DMP.IDocumentProperty IModelCollection<DMP.IDocumentProperty>.this[object index]
 {
  get
  {
   if (index is string propertyName)
    if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
     index = mappedName;
   return this[index];
  }

  set
  {
   if (index is string propertyName)
    if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
     index = mappedName;
   this[index] = (BuiltInProperty)value;
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
