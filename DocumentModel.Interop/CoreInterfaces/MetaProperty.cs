using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MetaProperty: InteropObject
{
  public object Value { get; set; }
  public string Name { get; }
  public string Id { get; }
  public bool IsReadOnly { get; }
  public bool IsRequired { get; }
  public MsoMetaPropertyType Type { get; }
  public string Validate();
  public string ValidationError { get; }
}
