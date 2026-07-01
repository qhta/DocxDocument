namespace DocumentModel.Math;
/// <summary>
///   This element specifies a single row of the matrix.
/// </summary>
[OpenXmlType(typeof(DXM.MatrixRow))]
[DataContract]
[XmlRoot("MatrixRow", Namespace = "DocumentModel.Math")]
public class MatrixRow : ModelElement<DXM.MatrixRow>, IArgumentCollection, ICollectionItem
{
}