namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public interface CheckBoxSymbolType: IModelElement
{
  /// <summary>
  ///   font, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Font { get; set; }
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexChar? Val { get; set; }
}