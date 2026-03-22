namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a glossary document entry (DocPart) in a WordprocessingML document.
/// This class provides properties for entry name, associated style, categorization, types, behaviors, description, and unique identifier, enabling advanced management, classification, and configuration of reusable document parts such as building blocks and autotext entries.
/// </summary>
[OpenXmlType(typeof(DXW.DocPartProperties))]
public partial class DocPartProperties : ModelElement<DXW.DocPartProperties>
{
 /// <summary>
 /// Entry name, specifying the unique identifier or display name for the glossary document entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.DocPartName))]
 public DocPartName? DocPartName { get => _DocPartName; set => UpdateField(ref _DocPartName, value, nameof(DocPartName)); }
 private DocPartName? _DocPartName;
 /// <summary>
 /// Associated paragraph style name for the entry, linking the entry to a specific style.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.StyleId))]
 public string? StyleId { get => _StyleId; set => UpdateField(ref _StyleId, value, nameof(StyleId)); }
 private string? _StyleId;
 /// <summary>
 /// Entry categorization, specifying the category and gallery for the entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.Category))]
 public Category? Category { get => _Category; set => UpdateField(ref _Category, value, nameof(Category)); }
 private Category? _Category;
 /// <summary>
 /// Entry types, specifying the types of document parts represented by the entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.DocPartTypes))]
 public DocPartTypes? DocPartTypes { get => _DocPartTypes; set => UpdateField(ref _DocPartTypes, value, nameof(DocPartTypes)); }
 private DocPartTypes? _DocPartTypes;
 /// <summary>
 /// Entry insertion behaviors, specifying how the entry behaves when inserted into a document.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.Behaviors))]
 public Behaviors? Behaviors { get => _Behaviors; set => UpdateField(ref _Behaviors, value, nameof(Behaviors)); }
 private Behaviors? _Behaviors;
 /// <summary>
 /// Description for the entry, providing additional information or context.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.Description))]
 public string? Description { get => _Description; set => UpdateField(ref _Description, value, nameof(Description)); }
 private string? _Description;
 /// <summary>
 /// Unique identifier for the entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocPartProperties.DocPartId))]
 public string? DocPartId { get => _DocPartId; set => UpdateField(ref _DocPartId, value, nameof(DocPartId)); }
 private string? _DocPartId;
}