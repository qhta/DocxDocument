namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout Type
/// </summary>
public enum SlideLayout
{
  /// <summary>
  /// Slide Layout Type Enumeration ( Title ).
  /// </summary>
  [XmlEnum("title")]
  Title,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Text ).
  /// </summary>
  [XmlEnum("tx")]
  Text,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Two Column Text ).
  /// </summary>
  [XmlEnum("twoColTx")]
  TwoColumnText,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Table ).
  /// </summary>
  [XmlEnum("tbl")]
  Table,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Text and Chart ).
  /// </summary>
  [XmlEnum("txAndChart")]
  TextAndChart,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Chart and Text ).
  /// </summary>
  [XmlEnum("chartAndTx")]
  ChartAndText,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Diagram ).
  /// </summary>
  [XmlEnum("dgm")]
  Diagram,
  
  /// <summary>
  /// Chart.
  /// </summary>
  [XmlEnum("chart")]
  Chart,
  
  /// <summary>
  /// Text and Clip Art.
  /// </summary>
  [XmlEnum("txAndClipArt")]
  TextAndClipArt,
  
  /// <summary>
  /// Clip Art and Text.
  /// </summary>
  [XmlEnum("clipArtAndTx")]
  ClipArtAndText,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Title Only ).
  /// </summary>
  [XmlEnum("titleOnly")]
  TitleOnly,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Blank ).
  /// </summary>
  [XmlEnum("blank")]
  Blank,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Text and Object ).
  /// </summary>
  [XmlEnum("txAndObj")]
  TextAndObject,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Object and Text ).
  /// </summary>
  [XmlEnum("objAndTx")]
  ObjectAndText,
  
  /// <summary>
  /// Object.
  /// </summary>
  [XmlEnum("objOnly")]
  ObjectOnly,
  
  /// <summary>
  /// Title and Object.
  /// </summary>
  [XmlEnum("obj")]
  Object,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Text and Media ).
  /// </summary>
  [XmlEnum("txAndMedia")]
  TextAndMedia,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Media and Text ).
  /// </summary>
  [XmlEnum("mediaAndTx")]
  MidiaAndText,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Object over Text).
  /// </summary>
  [XmlEnum("objOverTx")]
  ObjectOverText,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Text over Object).
  /// </summary>
  [XmlEnum("txOverObj")]
  TextOverObject,
  
  /// <summary>
  /// Text and Two Objects.
  /// </summary>
  [XmlEnum("txAndTwoObj")]
  TextAndTwoObjects,
  
  /// <summary>
  /// Two Objects and Text.
  /// </summary>
  [XmlEnum("twoObjAndTx")]
  TwoObjectsAndText,
  
  /// <summary>
  /// Two Objects over Text.
  /// </summary>
  [XmlEnum("twoObjOverTx")]
  TwoObjectsOverText,
  
  /// <summary>
  /// Four Objects.
  /// </summary>
  [XmlEnum("fourObj")]
  FourObjects,
  
  /// <summary>
  /// Vertical Text.
  /// </summary>
  [XmlEnum("vertTx")]
  VerticalText,
  
  /// <summary>
  /// Clip Art and Vertical Text.
  /// </summary>
  [XmlEnum("clipArtAndVertTx")]
  ClipArtAndVerticalText,
  
  /// <summary>
  /// Vertical Title and Text.
  /// </summary>
  [XmlEnum("vertTitleAndTx")]
  VerticalTitleAndText,
  
  /// <summary>
  /// Vertical Title and Text Over Chart.
  /// </summary>
  [XmlEnum("vertTitleAndTxOverChart")]
  VerticalTitleAndTextOverChart,
  
  /// <summary>
  /// Two Objects.
  /// </summary>
  [XmlEnum("twoObj")]
  TwoObjects,
  
  /// <summary>
  /// Object and Two Object.
  /// </summary>
  [XmlEnum("objAndTwoObj")]
  ObjectAndTwoObjects,
  
  /// <summary>
  /// Two Objects and Object.
  /// </summary>
  [XmlEnum("twoObjAndObj")]
  TwoObjectsAndObject,
  
  /// <summary>
  /// Slide Layout Type Enumeration ( Custom ).
  /// </summary>
  [XmlEnum("cust")]
  Custom,
  
  /// <summary>
  /// Section Header.
  /// </summary>
  [XmlEnum("secHead")]
  SectionHeader,
  
  /// <summary>
  /// Two Text and Two Objects.
  /// </summary>
  [XmlEnum("twoTxTwoObj")]
  TwoTextAndTwoObjects,
  
  /// <summary>
  /// Title, Object, and Caption.
  /// </summary>
  [XmlEnum("objTx")]
  ObjectText,
  
  /// <summary>
  /// Picture and Caption.
  /// </summary>
  [XmlEnum("picTx")]
  PictureText,
  
}
