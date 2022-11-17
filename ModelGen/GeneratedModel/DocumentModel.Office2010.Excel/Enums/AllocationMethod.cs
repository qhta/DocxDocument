namespace DocumentModel.Office2010.Excel;

public enum AllocationMethod
{

  [XmlEnum("equalAllocation")]
  EqualAllocation,

  [XmlEnum("equalIncrement")]
  EqualIncrement,

  [XmlEnum("weightedAllocation")]
  WeightedAllocation,

  [XmlEnum("weightedIncrement")]
  WeightedIncrement,
}
