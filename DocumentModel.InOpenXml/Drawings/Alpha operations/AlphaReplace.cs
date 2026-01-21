namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha replace effect, which sets the alpha channel of an image or shape to a specified value.
/// </summary>
public partial class AlphaReplace : ModelElement<DXD.AlphaReplace>
{
  /// <summary>
  /// Alpha value to be applied, replacing the existing alpha channel.
  /// </summary>
  public Int32? Alpha { get; set; }
}