namespace DocumentModel;

public partial class BuiltInDocumentProperties : DMP.IDocumentProperties
{
  IEnumerator<DMP.IDocumentProperty> IEnumerable<DMP.IDocumentProperty>.GetEnumerator()
  => this.GetEnumerator();

  DMP.IDocumentProperty IModelCollection<DMP.IDocumentProperty>.this[object Index] 
  { 
    get => this[Index]; 
    set => this[Index] = (BuiltInDocumentProperty)value;
  }
}