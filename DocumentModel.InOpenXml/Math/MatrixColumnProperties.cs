namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the matrix column mn, including the number of columns and the type of justification.
/// </summary>
[OpenXmlType(typeof(DXM.MatrixColumnProperties))]
[XmlRoot("MatrixColumnProperties", Namespace = "DocumentModel.Math")]
public partial class MatrixColumnProperties : ModelElement<DXM.MatrixColumnProperties>
{
 /// <summary>
 ///   Matrix IColumn Count.
 /// </summary>
 public Int32? MatrixColumnCount { get => _MatrixColumnCount; set => UpdateField(ref _MatrixColumnCount, value, nameof(MatrixColumnCount)); }
 private Int32? _MatrixColumnCount;

 /// <summary>
 ///   Matrix IColumn Justification.
 /// </summary>
 public HorizontalAlignment? MatrixColumnJustification { get => _MatrixColumnJustification; set => UpdateField(ref _MatrixColumnJustification, value, nameof(MatrixColumnJustification)); }
 private HorizontalAlignment? _MatrixColumnJustification;
}