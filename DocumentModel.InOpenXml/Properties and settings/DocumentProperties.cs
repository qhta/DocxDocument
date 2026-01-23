namespace DocumentModel;
using DocumentModel.Wordprocessing;

/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, statistics properties, and custom properties. 
/// Document settings and web settings are also contained in this collection.
/// </summary>
public partial class DocumentProperties : ModelElement
{
    /// <summary>
    /// Collection of core properties, which represents document properties defined in Dublin Core standard
    /// and Open Packaging Conventions. 
    /// </summary>
    [XmlIgnore]
    public CoreProperties? CoreProperties { get => _CoreProperties; set => UpdateField(ref _CoreProperties, value, nameof(CoreProperties)); }

    private CoreProperties? _CoreProperties;
    /// <summary>
    /// Collection of content properties, which represents document properties defined in Microsoft Office standard.
    /// </summary>
    [XmlIgnore]
    public ContentProperties? ContentProperties { get => _ContentProperties; set => UpdateField(ref _ContentProperties, value, nameof(ContentProperties)); }

    private ContentProperties? _ContentProperties;
    /// <summary>
    /// Collection of statistic properties, which represents document metrics like characters count.
    /// </summary>
    [XmlIgnore]
    public StatisticProperties? StatisticProperties { get => _StatisticProperties; set => UpdateField(ref _StatisticProperties, value, nameof(StatisticProperties)); }

    private StatisticProperties? _StatisticProperties;
    /// <summary>
    /// Collection of custom-defined document properties.
    /// </summary>
    [XmlIgnore]
    public CustomProperties? CustomProperties { get => _CustomProperties; set => UpdateField(ref _CustomProperties, value, nameof(CustomProperties)); }

    private CustomProperties? _CustomProperties;
}