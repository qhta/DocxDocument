using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentModel.Attributes;
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class CollectionConstraintAttribute: Attribute
{
  public int? MinCount { get; set; }
  public int? MaxCount { get; set; }
}
