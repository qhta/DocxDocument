namespace DocumentModel.Math;
/// <summary>
///   This element specifies the collection of columns of the matrix .
/// </summary>
[OpenXmlType(typeof(MatrixColumn))]
[XmlRoot("MatrixColumns", Namespace = "DocumentModel.Math")]
public class MatrixColumns : ModelElementCollection<MatrixColumn, DXM.MatrixColumns, DXM.MatrixColumn>
{
}