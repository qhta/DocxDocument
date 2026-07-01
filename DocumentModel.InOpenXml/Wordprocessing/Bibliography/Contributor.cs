namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a single contributor (author, editor, etc.).
/// </summary>
[OpenXmlType(typeof(DXB.Person))]
[DataContract]
[XmlRoot("Contributor", Namespace = "DocumentModel.Wordprocessing")]
public partial class Contributor : ModelElement<DXB.Person>
{
 /// <summary>
 ///   Gets or sets the first name.
 /// </summary>
 public string? First { get => _First; set => UpdateField(ref _First, value, nameof(First)); }
 private string? _First;

 /// <summary>
 ///   Gets or sets the middle name or initial.
 /// </summary>
 public string? Middle { get => _Middle; set => UpdateField(ref _Middle, value, nameof(Middle)); }
 private string? _Middle;

 /// <summary>
 ///   Gets or sets the last name (surname).
 /// </summary>
 public string? Last { get => _Last; set => UpdateField(ref _Last, value, nameof(Last)); }
 private string? _Last;

 /// <summary>
 ///   Gets or sets the name suffix (Jr., Sr., III, etc.).
 /// </summary>
 public string? Suffix { get => _Suffix; set => UpdateField(ref _Suffix, value, nameof(Suffix)); }
 private string? _Suffix;

 /// <summary>
 ///   Gets or sets the corporate or organizational name.
 /// </summary>
 public string? Corporate { get => _Corporate; set => UpdateField(ref _Corporate, value, nameof(Corporate)); }
 private string? _Corporate;

 /// <summary>
 ///   Gets whether this is a corporate contributor.
 /// </summary>
 public bool IsCorporate => !string.IsNullOrEmpty(Corporate);
}