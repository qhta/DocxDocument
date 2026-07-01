namespace DocumentModel.Wordprocessing;
/// <summary>
/// Collection of active writing styles applied to the document.
/// </summary>
[OpenXmlType(typeof(ActiveWritingStyle))]
[DataContract]
[XmlRoot("ActiveWritingStyles", Namespace = "DocumentModel.Wordprocessing")]
public class ActiveWritingStyles : ModelElementCollection<ActiveWritingStyle, DXW.Settings, DXW.ActiveWritingStyle>
{
  /// <summary>
  /// Default constructor. Initializes an empty collection of active writing styles.
  /// </summary>
  public ActiveWritingStyles(): base()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "parent">The parent document settings element.</param>
  /// <param name = "openXmlCollection">The underlying OpenXml collection element.</param>
  public ActiveWritingStyles(DocumentSettings parent, DXW.Settings? openXmlCollection) : base(parent, openXmlCollection)
  {
  }

  /// <summary>
  /// Initializes the collection with the specified styles.
  /// </summary>
  /// <param name = "styles">Initial collection of active writing styles.</param>
  public ActiveWritingStyles(IEnumerable<ActiveWritingStyle> styles) : base(styles)
  {
  }
}