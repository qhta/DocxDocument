namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineStyleType enumeration.
/// </summary>
public enum TimelineStyleType
{
  /// <summary>
  /// selectionLabel.
  /// </summary>
  [XmlEnum("selectionLabel")]
  SelectionLabel,
  
  /// <summary>
  /// timeLevel.
  /// </summary>
  [XmlEnum("timeLevel")]
  TimeLevel,
  
  /// <summary>
  /// periodLabel1.
  /// </summary>
  [XmlEnum("periodLabel1")]
  PeriodLabel1,
  
  /// <summary>
  /// periodLabel2.
  /// </summary>
  [XmlEnum("periodLabel2")]
  PeriodLabel2,
  
  /// <summary>
  /// selectedTimeBlock.
  /// </summary>
  [XmlEnum("selectedTimeBlock")]
  SelectedTimeBlock,
  
  /// <summary>
  /// unselectedTimeBlock.
  /// </summary>
  [XmlEnum("unselectedTimeBlock")]
  UnselectedTimeBlock,
  
  /// <summary>
  /// selectedTimeBlockSpace.
  /// </summary>
  [XmlEnum("selectedTimeBlockSpace")]
  SelectedTimeBlockSpace,
  
}
