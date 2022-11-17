namespace DocumentModel.Office2013.Excel;

public enum TimelineStyleType
{
  
  [XmlEnum("selectionLabel")]
  SelectionLabel,
  
  [XmlEnum("timeLevel")]
  TimeLevel,
  
  [XmlEnum("periodLabel1")]
  PeriodLabel1,
  
  [XmlEnum("periodLabel2")]
  PeriodLabel2,
  
  [XmlEnum("selectedTimeBlock")]
  SelectedTimeBlock,
  
  [XmlEnum("unselectedTimeBlock")]
  UnselectedTimeBlock,
  
  [XmlEnum("selectedTimeBlockSpace")]
  SelectedTimeBlockSpace,
}
