namespace DocumentModel;

public partial class CustomProperties : DMPr.ICustomProperties
{
  IEnumerator<DMPr.ICustomProperty> IEnumerable<DMPr.ICustomProperty>.GetEnumerator() => this.GetEnumerator();
  DMPr.ICustomProperty IModelCollection<DMPr.ICustomProperty>.this[object index] { get => this[index]; set => this[index] = (CustomProperty)value; }

  DMPr.ICustomProperty DMPr.ICustomProperties.Add(string name, object value) => this.Add(name, value);

}
