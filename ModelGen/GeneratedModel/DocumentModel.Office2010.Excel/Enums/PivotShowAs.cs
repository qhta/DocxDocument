namespace DocumentModel.Office2010.Excel;

public enum PivotShowAs
{

  [XmlEnum("percentOfParent")]
  PercentOfParent,

  [XmlEnum("percentOfParentRow")]
  PercentOfParentRow,

  [XmlEnum("percentOfParentCol")]
  PercentOfParentColumn,

  [XmlEnum("percentOfRunningTotal")]
  PercentOfRunningTotal,

  [XmlEnum("rankAscending")]
  RankAscending,

  [XmlEnum("rankDescending")]
  RankDescending,
}
