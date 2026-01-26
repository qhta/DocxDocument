namespace DocumentModel.Math;
/// <summary>
///   This element specifies a single column in a matrix.
/// </summary>
[OpenXmlType(typeof(DXM.MatrixColumn))]
public partial class MatrixColumn : ModelElement<DXM.MatrixColumn>
{
 /// <summary>
 ///   Matrix IColumn Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.MatrixColumn.MatrixColumnProperties))]
 /// <summary>
 ///   Matrix IColumn Properties.
 /// </summary>
 [OpenXmlElement(typeof(DXM.MatrixColumn))]
 public MatrixColumnProperties? MatrixColumnProperties { get => _MatrixColumnProperties; set => UpdateField(ref _MatrixColumnProperties, value, nameof(MatrixColumnProperties)); }

 private MatrixColumnProperties? _MatrixColumnProperties;
}