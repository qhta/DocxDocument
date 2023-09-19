namespace DXW;


/// <summary>
///   Defines the DocPartGalleryValues enumeration.
/// </summary>
public enum DocPartGalleryValues
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;placeholder&quot;.
  /// </summary>
  [EnumString("placeholder")]
  Placeholder,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;any&quot;.
  /// </summary>
  [EnumString("any")]
  Any,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;default&quot;.
  /// </summary>
  [EnumString("default")]
  Default,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;docParts&quot;.
  /// </summary>
  [EnumString("docParts")]
  DocumentPart,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;coverPg&quot;.
  /// </summary>
  [EnumString("coverPg")]
  CoverPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;eq&quot;.
  /// </summary>
  [EnumString("eq")]
  Equation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;ftrs&quot;.
  /// </summary>
  [EnumString("ftrs")]
  Footer,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;hdrs&quot;.
  /// </summary>
  [EnumString("hdrs")]
  Header,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pgNum&quot;.
  /// </summary>
  [EnumString("pgNum")]
  PageNumber,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tbls&quot;.
  /// </summary>
  [EnumString("tbls")]
  Table,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;watermarks&quot;.
  /// </summary>
  [EnumString("watermarks")]
  WaterMark,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;autoTxt&quot;.
  /// </summary>
  [EnumString("autoTxt")]
  AutoText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;txtBox&quot;.
  /// </summary>
  [EnumString("txtBox")]
  TextBox,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pgNumT&quot;.
  /// </summary>
  [EnumString("pgNumT")]
  PageNumberTop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pgNumB&quot;.
  /// </summary>
  [EnumString("pgNumB")]
  PageNumberBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;pgNumMargins&quot;.
  /// </summary>
  [EnumString("pgNumMargins")]
  PageNumberMargins,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;tblOfContents&quot;.
  /// </summary>
  [EnumString("tblOfContents")]
  TableOfContents,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;bib&quot;.
  /// </summary>
  [EnumString("bib")]
  Bibliography,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custQuickParts&quot;.
  /// </summary>
  [EnumString("custQuickParts")]
  CustomQuickParts,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custCoverPg&quot;.
  /// </summary>
  [EnumString("custCoverPg")]
  CustomCoverPage,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custEq&quot;.
  /// </summary>
  [EnumString("custEq")]
  CustomEquation,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custFtrs&quot;.
  /// </summary>
  [EnumString("custFtrs")]
  CustomFooter,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custHdrs&quot;.
  /// </summary>
  [EnumString("custHdrs")]
  CustomHeaders,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custPgNum&quot;.
  /// </summary>
  [EnumString("custPgNum")]
  CustomPageNumber,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custTbls&quot;.
  /// </summary>
  [EnumString("custTbls")]
  CustomTable,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custWatermarks&quot;.
  /// </summary>
  [EnumString("custWatermarks")]
  CustomWatermark,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custAutoTxt&quot;.
  /// </summary>
  [EnumString("custAutoTxt")]
  CustomAutoText,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custTxtBox&quot;.
  /// </summary>
  [EnumString("custTxtBox")]
  CustomTextBox,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custPgNumT&quot;.
  /// </summary>
  [EnumString("custPgNumT")]
  CustomPageNumberTop,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custPgNumB&quot;.
  /// </summary>
  [EnumString("custPgNumB")]
  CustomPageNumberBottom,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custPgNumMargins&quot;.
  /// </summary>
  [EnumString("custPgNumMargins")]
  CustomPageNumberMargin,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custTblOfContents&quot;.
  /// </summary>
  [EnumString("custTblOfContents")]
  CustomTableOfContents,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custBib&quot;.
  /// </summary>
  [EnumString("custBib")]
  CustomBibliography,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom1&quot;.
  /// </summary>
  [EnumString("custom1")]
  Custom1,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom2&quot;.
  /// </summary>
  [EnumString("custom2")]
  Custom2,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom3&quot;.
  /// </summary>
  [EnumString("custom3")]
  Custom3,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom4&quot;.
  /// </summary>
  [EnumString("custom4")]
  Custom4,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;custom5&quot;.
  /// </summary>
  [EnumString("custom5")]
  Custom5,
  
}
