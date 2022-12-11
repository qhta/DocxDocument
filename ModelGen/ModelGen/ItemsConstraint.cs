using System.Collections.ObjectModel;

using Microsoft.VisualBasic;

namespace ModelGen;

public class ItemsConstraint
{
  public ConstraintType ConstraintType { get; set; }
  public bool IsRequired { get; set; }
  public bool IsMultiple { get; set; }
}