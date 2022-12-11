using System.Collections.ObjectModel;

namespace ModelGen;

public class ItemsCompoundConstraint: ItemsConstraint
{
  public Collection<ItemsConstraint> Items { get; } = new Collection<ItemsConstraint>();
}