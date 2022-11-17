namespace DocumentModel.Office2010.Word;

public enum Ligatures
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("standard")]
  Standard,
  
  [XmlEnum("contextual")]
  Contextual,
  
  [XmlEnum("historical")]
  Historical,
  
  [XmlEnum("discretional")]
  Discretional,
  
  [XmlEnum("standardContextual")]
  StandardContextual,
  
  [XmlEnum("standardHistorical")]
  StandardHistorical,
  
  [XmlEnum("contextualHistorical")]
  ContextualHistorical,
  
  [XmlEnum("standardDiscretional")]
  StandardDiscretional,
  
  [XmlEnum("contextualDiscretional")]
  ContextualDiscretional,
  
  [XmlEnum("historicalDiscretional")]
  HistoricalDiscretional,
  
  [XmlEnum("standardContextualHistorical")]
  StandardContextualHistorical,
  
  [XmlEnum("standardContextualDiscretional")]
  StandardContextualDiscretional,
  
  [XmlEnum("standardHistoricalDiscretional")]
  StandardHistoricalDiscretional,
  
  [XmlEnum("contextualHistoricalDiscretional")]
  ContextualHistoricalDiscretional,
  
  [XmlEnum("all")]
  All,
}
