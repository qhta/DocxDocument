using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface MetaProperty: InteropObject
{
  object Value { get; set; }
  string Name { get; }
  string Id { get; }
  bool IsReadOnly { get; }
  bool IsRequired { get; }
  MsoMetaPropertyType Type { get; }
  string Validate();
  string ValidationError { get; }
}