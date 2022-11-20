namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Style Type
/// </summary>
public enum TableStyleValues
{
  /// <summary>
  /// Whole Table Style.
  /// </summary>
  [XmlEnum("wholeTable")]
  WholeTable,
  
  /// <summary>
  /// Header Row Style.
  /// </summary>
  [XmlEnum("headerRow")]
  HeaderRow,
  
  /// <summary>
  /// Total Row Style.
  /// </summary>
  [XmlEnum("totalRow")]
  TotalRow,
  
  /// <summary>
  /// First Column Style.
  /// </summary>
  [XmlEnum("firstColumn")]
  FirstColumn,
  
  /// <summary>
  /// Last Column Style.
  /// </summary>
  [XmlEnum("lastColumn")]
  LastColumn,
  
  /// <summary>
  /// First Row Stripe Style.
  /// </summary>
  [XmlEnum("firstRowStripe")]
  FirstRowStripe,
  
  /// <summary>
  /// Second Row Stripe Style.
  /// </summary>
  [XmlEnum("secondRowStripe")]
  SecondRowStripe,
  
  /// <summary>
  /// First Column Stripe Style.
  /// </summary>
  [XmlEnum("firstColumnStripe")]
  FirstColumnStripe,
  
  /// <summary>
  /// Second Column Stripe Style.
  /// </summary>
  [XmlEnum("secondColumnStripe")]
  SecondColumnStripe,
  
  /// <summary>
  /// First Header Row Style.
  /// </summary>
  [XmlEnum("firstHeaderCell")]
  FirstHeaderCell,
  
  /// <summary>
  /// Last Header Style.
  /// </summary>
  [XmlEnum("lastHeaderCell")]
  LastHeaderCell,
  
  /// <summary>
  /// First Total Row Style.
  /// </summary>
  [XmlEnum("firstTotalCell")]
  FirstTotalCell,
  
  /// <summary>
  /// Last Total Row Style.
  /// </summary>
  [XmlEnum("lastTotalCell")]
  LastTotalCell,
  
  /// <summary>
  /// First Subtotal Column Style.
  /// </summary>
  [XmlEnum("firstSubtotalColumn")]
  FirstSubtotalColumn,
  
  /// <summary>
  /// Second Subtotal Column Style.
  /// </summary>
  [XmlEnum("secondSubtotalColumn")]
  SecondSubtotalColumn,
  
  /// <summary>
  /// Third Subtotal Column Style.
  /// </summary>
  [XmlEnum("thirdSubtotalColumn")]
  ThirdSubtotalColumn,
  
  /// <summary>
  /// First Subtotal Row Style.
  /// </summary>
  [XmlEnum("firstSubtotalRow")]
  FirstSubtotalRow,
  
  /// <summary>
  /// Second Subtotal Row Style.
  /// </summary>
  [XmlEnum("secondSubtotalRow")]
  SecondSubtotalRow,
  
  /// <summary>
  /// Third Subtotal Row Style.
  /// </summary>
  [XmlEnum("thirdSubtotalRow")]
  ThirdSubtotalRow,
  
  /// <summary>
  /// Blank Row Style.
  /// </summary>
  [XmlEnum("blankRow")]
  BlankRow,
  
  /// <summary>
  /// First Column Subheading Style.
  /// </summary>
  [XmlEnum("firstColumnSubheading")]
  FirstColumnSubheading,
  
  /// <summary>
  /// Second Column Subheading Style.
  /// </summary>
  [XmlEnum("secondColumnSubheading")]
  SecondColumnSubheading,
  
  /// <summary>
  /// Third Column Subheading Style.
  /// </summary>
  [XmlEnum("thirdColumnSubheading")]
  ThirdColumnSubheading,
  
  /// <summary>
  /// First Row Subheading Style.
  /// </summary>
  [XmlEnum("firstRowSubheading")]
  FirstRowSubheading,
  
  /// <summary>
  /// Second Row Subheading Style.
  /// </summary>
  [XmlEnum("secondRowSubheading")]
  SecondRowSubheading,
  
  /// <summary>
  /// Third Row Subheading Style.
  /// </summary>
  [XmlEnum("thirdRowSubheading")]
  ThirdRowSubheading,
  
  /// <summary>
  /// Page Field Labels Style.
  /// </summary>
  [XmlEnum("pageFieldLabels")]
  PageFieldLabels,
  
  /// <summary>
  /// Page Field Values Style.
  /// </summary>
  [XmlEnum("pageFieldValues")]
  PageFieldValues,
  
}
