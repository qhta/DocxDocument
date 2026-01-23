namespace DocumentModel.Math;
/// <summary>
///   This element specifies a single column in a matrix.
/// </summary>
public partial class MatrixColumn : ModelElement<DXM.MatrixColumn>
{
    /// <summary>
    ///   Matrix IColumn Properties.
    /// </summary>
    public MatrixColumnProperties? MatrixColumnProperties { get => _MatrixColumnProperties; set => UpdateField(ref _MatrixColumnProperties, value, nameof(MatrixColumnProperties)); }

    private MatrixColumnProperties? _MatrixColumnProperties;
}