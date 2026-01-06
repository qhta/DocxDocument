namespace DocumentModel;
/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, statistics properties, and custom properties. 
/// Document settings and web settings are also contained in this collection.
/// </summary>
public interface AllDocumentProperties : ICollection<DocumentProperty>
{
  /// <summary>
  /// Collection of core properties, which represents document properties defined in Dublin Core standard
  /// and Open Packaging Conventions. 
  /// </summary>
  [XmlIgnore]
  public CoreProperties? CoreProperties { get; set; }
  /// <summary>
  /// Collection of content properties, which represents document properties defined in Microsoft Office standard.
  /// </summary>
  [XmlIgnore]
  public ContentProperties? ContentProperties { get; set; }
  /// <summary>
  /// Collection of statistic properties, which represents document metrics like characters count.
  /// </summary>
  [XmlIgnore]
  public StatisticProperties? StatisticProperties { get; set; }
  /// <summary>
  /// Collection of document settings, which represent Word document settings.
  /// </summary>
  [XmlIgnore]
  public DocumentSettings? DocumentSettings { get; set; }
  /// <summary>
  /// Collection of web settings, which affect HTML generation.
  /// </summary>
  [XmlIgnore]
  public DMW.WebSettings? WebSettings { get; set; }
  /// <summary>
  /// Collection of custom-defined document properties.
  /// </summary>
  [XmlIgnore]
  public CustomProperties? CustomProperties { get; set; }
}