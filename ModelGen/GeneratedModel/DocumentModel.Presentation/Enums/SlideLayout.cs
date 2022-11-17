namespace DocumentModel.Presentation;

public enum SlideLayout
{
  
  [XmlEnum("title")]
  Title,
  
  [XmlEnum("tx")]
  Text,
  
  [XmlEnum("twoColTx")]
  TwoColumnText,
  
  [XmlEnum("tbl")]
  Table,
  
  [XmlEnum("txAndChart")]
  TextAndChart,
  
  [XmlEnum("chartAndTx")]
  ChartAndText,
  
  [XmlEnum("dgm")]
  Diagram,
  
  [XmlEnum("chart")]
  Chart,
  
  [XmlEnum("txAndClipArt")]
  TextAndClipArt,
  
  [XmlEnum("clipArtAndTx")]
  ClipArtAndText,
  
  [XmlEnum("titleOnly")]
  TitleOnly,
  
  [XmlEnum("blank")]
  Blank,
  
  [XmlEnum("txAndObj")]
  TextAndObject,
  
  [XmlEnum("objAndTx")]
  ObjectAndText,
  
  [XmlEnum("objOnly")]
  ObjectOnly,
  
  [XmlEnum("obj")]
  Object,
  
  [XmlEnum("txAndMedia")]
  TextAndMedia,
  
  [XmlEnum("mediaAndTx")]
  MidiaAndText,
  
  [XmlEnum("objOverTx")]
  ObjectOverText,
  
  [XmlEnum("txOverObj")]
  TextOverObject,
  
  [XmlEnum("txAndTwoObj")]
  TextAndTwoObjects,
  
  [XmlEnum("twoObjAndTx")]
  TwoObjectsAndText,
  
  [XmlEnum("twoObjOverTx")]
  TwoObjectsOverText,
  
  [XmlEnum("fourObj")]
  FourObjects,
  
  [XmlEnum("vertTx")]
  VerticalText,
  
  [XmlEnum("clipArtAndVertTx")]
  ClipArtAndVerticalText,
  
  [XmlEnum("vertTitleAndTx")]
  VerticalTitleAndText,
  
  [XmlEnum("vertTitleAndTxOverChart")]
  VerticalTitleAndTextOverChart,
  
  [XmlEnum("twoObj")]
  TwoObjects,
  
  [XmlEnum("objAndTwoObj")]
  ObjectAndTwoObjects,
  
  [XmlEnum("twoObjAndObj")]
  TwoObjectsAndObject,
  
  [XmlEnum("cust")]
  Custom,
  
  [XmlEnum("secHead")]
  SectionHeader,
  
  [XmlEnum("twoTxTwoObj")]
  TwoTextAndTwoObjects,
  
  [XmlEnum("objTx")]
  ObjectText,
  
  [XmlEnum("picTx")]
  PictureText,
}
