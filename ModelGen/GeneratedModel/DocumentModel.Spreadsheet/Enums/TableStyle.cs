namespace DocumentModel.Spreadsheet;

public enum TableStyle
{
  
  [XmlEnum("wholeTable")]
  WholeTable,
  
  [XmlEnum("headerRow")]
  HeaderRow,
  
  [XmlEnum("totalRow")]
  TotalRow,
  
  [XmlEnum("firstColumn")]
  FirstColumn,
  
  [XmlEnum("lastColumn")]
  LastColumn,
  
  [XmlEnum("firstRowStripe")]
  FirstRowStripe,
  
  [XmlEnum("secondRowStripe")]
  SecondRowStripe,
  
  [XmlEnum("firstColumnStripe")]
  FirstColumnStripe,
  
  [XmlEnum("secondColumnStripe")]
  SecondColumnStripe,
  
  [XmlEnum("firstHeaderCell")]
  FirstHeaderCell,
  
  [XmlEnum("lastHeaderCell")]
  LastHeaderCell,
  
  [XmlEnum("firstTotalCell")]
  FirstTotalCell,
  
  [XmlEnum("lastTotalCell")]
  LastTotalCell,
  
  [XmlEnum("firstSubtotalColumn")]
  FirstSubtotalColumn,
  
  [XmlEnum("secondSubtotalColumn")]
  SecondSubtotalColumn,
  
  [XmlEnum("thirdSubtotalColumn")]
  ThirdSubtotalColumn,
  
  [XmlEnum("firstSubtotalRow")]
  FirstSubtotalRow,
  
  [XmlEnum("secondSubtotalRow")]
  SecondSubtotalRow,
  
  [XmlEnum("thirdSubtotalRow")]
  ThirdSubtotalRow,
  
  [XmlEnum("blankRow")]
  BlankRow,
  
  [XmlEnum("firstColumnSubheading")]
  FirstColumnSubheading,
  
  [XmlEnum("secondColumnSubheading")]
  SecondColumnSubheading,
  
  [XmlEnum("thirdColumnSubheading")]
  ThirdColumnSubheading,
  
  [XmlEnum("firstRowSubheading")]
  FirstRowSubheading,
  
  [XmlEnum("secondRowSubheading")]
  SecondRowSubheading,
  
  [XmlEnum("thirdRowSubheading")]
  ThirdRowSubheading,
  
  [XmlEnum("pageFieldLabels")]
  PageFieldLabels,
  
  [XmlEnum("pageFieldValues")]
  PageFieldValues,
}
