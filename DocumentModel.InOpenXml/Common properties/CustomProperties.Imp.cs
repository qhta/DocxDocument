using DocumentModel.Interop;

namespace DocumentModel;

public partial class CustomProperties: DMP.ICustomProperties
{

  IEnumerator<DMP.ICustomProperty> IEnumerable<DMP.ICustomProperty>.GetEnumerator()
  => this.GetEnumerator();

 
  DMP.ICustomProperty IModelCollection<DMP.ICustomProperty>.this[object index]
  {
    get => this[index]; 
    set => this[index] = (CustomProperty)value;
  }
  DMP.ICustomProperty DMP.ICustomProperties.Add(string name, object value)
  {
    var newItem = new CustomProperty{Name = name, Value = new Variant(value)};
    Add(newItem);
  }
}