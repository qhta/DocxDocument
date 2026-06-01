using ISystem;
using ISystem.Collections.Generic;
using ISystem.Text;

namespace DocumentModel.Attributes;
[AttributeUsage(AttributeTargets.IField | AttributeTargets.Property)]
public class CollectionConstraintAttribute: Attribute
{
  public int? MinCount { get; set; }
  public int? MaxCount { get; set; }
}

