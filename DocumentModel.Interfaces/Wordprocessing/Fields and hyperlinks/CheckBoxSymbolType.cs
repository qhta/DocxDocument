namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public interface CheckBoxSymbolType: IModelElement
{
  /// <summary>
  ///   font
  /// </summary>
  public string? Font { get; set; }
  /// <summary>
  ///   val
  /// </summary>
  public IHexChar? Val { get; set; }
}