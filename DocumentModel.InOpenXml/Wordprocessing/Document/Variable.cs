namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a document variable with a name and a string value in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for the variable name and value, enabling advanced storage and retrieval of custom metadata or automation variables within the document.
/// </summary>
[OpenXmlType(typeof(DXW.DocumentVariable))]
public partial class Variable : ModelElement<DXW.DocumentVariable>
{
 /// <summary>
 /// FontName of the document variable, specifying the unique identifier for the variable.
 /// </summary>
 [XmlAttribute]
 /// <summary>
 /// FontName of the document variable, specifying the unique identifier for the variable.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentVariable.Name))]
 /// <summary>
 /// FontName of the document variable, specifying the unique identifier for the variable.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DocumentVariable))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

 private string? _Name;
 /// <summary>
 /// Value of the document variable, specified as a string.
 /// </summary>
 [XmlAttribute]
 /// <summary>
 /// Value of the document variable, specified as a string.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentVariable.Val))]
 /// <summary>
 /// Value of the document variable, specified as a string.
 /// </summary>
 [OpenXmlElement(typeof(DXW.DocumentVariable))]
 public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

 private string? _Val;
}