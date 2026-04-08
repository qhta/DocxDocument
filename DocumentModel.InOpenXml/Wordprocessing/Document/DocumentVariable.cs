namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a document variable with a name and a string value in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for the variable name and value, enabling advanced storage and retrieval of custom metadata or automation variables within the document.
/// </summary>
[OpenXmlType(typeof(DXW.DocumentVariable))]
public partial class DocumentVariable : ModelElement<DXW.DocumentVariable>
{
 /// <summary>
 /// Name of the document variable, specifying the unique identifier for the variable.
 /// </summary>
 [XmlAttribute]
 [OpenXmlProperty(nameof(DXW.DocumentVariable.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;
 /// <summary>
 /// Value of the document variable, specified as a string.
 /// </summary>
 [XmlAttribute]
 [OpenXmlProperty(nameof(DXW.DocumentVariable.Val))]
 public string? Value { get => _value; set => UpdateField(ref _value, value, nameof(Value)); }
 private string? _value;
}