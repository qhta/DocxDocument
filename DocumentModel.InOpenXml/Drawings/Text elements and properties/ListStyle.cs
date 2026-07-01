namespace DocumentModel.Drawings;
/// <summary>
///   Represents a list style, including default and per-level paragraph formatting for multi-level lists.
/// </summary>
[DataContract]
[XmlRoot("ListStyle", Namespace = "DocumentModel.Drawings")]
public partial class ListStyle : ModelElement, IExtendableElement
{
 /// <summary>
 ///   Default paragraph style for the list.
 /// </summary>
 public ParagraphProperties? DefaultParagraphProperties { get => _DefaultParagraphProperties; set => UpdateField(ref _DefaultParagraphProperties, value, nameof(DefaultParagraphProperties)); }
 private ParagraphProperties? _DefaultParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 1.
 /// </summary>
 public ParagraphProperties? Level1ParagraphProperties { get => _Level1ParagraphProperties; set => UpdateField(ref _Level1ParagraphProperties, value, nameof(Level1ParagraphProperties)); }
 private ParagraphProperties? _Level1ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 2.
 /// </summary>
 public ParagraphProperties? Level2ParagraphProperties { get => _Level2ParagraphProperties; set => UpdateField(ref _Level2ParagraphProperties, value, nameof(Level2ParagraphProperties)); }
 private ParagraphProperties? _Level2ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 3.
 /// </summary>
 public ParagraphProperties? Level3ParagraphProperties { get => _Level3ParagraphProperties; set => UpdateField(ref _Level3ParagraphProperties, value, nameof(Level3ParagraphProperties)); }
 private ParagraphProperties? _Level3ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 4.
 /// </summary>
 public ParagraphProperties? Level4ParagraphProperties { get => _Level4ParagraphProperties; set => UpdateField(ref _Level4ParagraphProperties, value, nameof(Level4ParagraphProperties)); }
 private ParagraphProperties? _Level4ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 5.
 /// </summary>
 public ParagraphProperties? Level5ParagraphProperties { get => _Level5ParagraphProperties; set => UpdateField(ref _Level5ParagraphProperties, value, nameof(Level5ParagraphProperties)); }
 private ParagraphProperties? _Level5ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 6.
 /// </summary>
 public ParagraphProperties? Level6ParagraphProperties { get => _Level6ParagraphProperties; set => UpdateField(ref _Level6ParagraphProperties, value, nameof(Level6ParagraphProperties)); }
 private ParagraphProperties? _Level6ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 7.
 /// </summary>
 public ParagraphProperties? Level7ParagraphProperties { get => _Level7ParagraphProperties; set => UpdateField(ref _Level7ParagraphProperties, value, nameof(Level7ParagraphProperties)); }
 private ParagraphProperties? _Level7ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 8.
 /// </summary>
 public ParagraphProperties? Level8ParagraphProperties { get => _Level8ParagraphProperties; set => UpdateField(ref _Level8ParagraphProperties, value, nameof(Level8ParagraphProperties)); }
 private ParagraphProperties? _Level8ParagraphProperties;

 /// <summary>
 ///   Paragraph style for list level 9.
 /// </summary>
 public ParagraphProperties? Level9ParagraphProperties { get => _Level9ParagraphProperties; set => UpdateField(ref _Level9ParagraphProperties, value, nameof(Level9ParagraphProperties)); }
 private ParagraphProperties? _Level9ParagraphProperties;

 /// <summary>
 /// List of extension properties for the list style, used for extensibility scenarios.
 /// </summary>
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}