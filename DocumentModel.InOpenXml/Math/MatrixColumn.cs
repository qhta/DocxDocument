namespace DocumentModel.Math;
/// <summary>
///   This element specifies a single column in a matrix.
/// </summary>
[OpenXmlType(typeof(DXM.MatrixColumn))]
[XmlRoot("MatrixColumn", Namespace = "DocumentModel.Math")]
public partial class MatrixColumn : ModelElement<DXM.MatrixColumn>
{
 /// <summary>
 ///   Matrix IColumn Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.MatrixColumn.MatrixColumnProperties))]
 public MatrixColumnProperties? MatrixColumnProperties { get => _MatrixColumnProperties; set => UpdateField(ref _MatrixColumnProperties, value, nameof(MatrixColumnProperties)); }

 private MatrixColumnProperties? _MatrixColumnProperties;
}