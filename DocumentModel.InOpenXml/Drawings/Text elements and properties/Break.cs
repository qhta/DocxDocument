namespace DocumentModel.Drawings;
/// <summary>
/// Represents a text line break within a drawing, optionally including run properties for the break.
/// </summary>
[OpenXmlType(typeof(DXW.Break))]
[DataContract]
[XmlRoot("Break", Namespace = "DocumentModel.Drawings")]
public partial class Break : ModelElement<DXW.Break>
{
  /// <summary>
  /// Text run properties applied to the break.
  /// </summary>
  public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }
  private RunProperties? _RunProperties;
}