namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RegionLabelLayoutEnum enumeration.
/// </summary>
public enum RegionLabelLayoutEnum
{
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// bestFitOnly.
  /// </summary>
  [XmlEnum("bestFitOnly")]
  BestFitOnly,
  
  /// <summary>
  /// showAll.
  /// </summary>
  [XmlEnum("showAll")]
  ShowAll,
  
}
