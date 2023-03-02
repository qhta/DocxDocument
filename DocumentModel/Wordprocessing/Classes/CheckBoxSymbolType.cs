namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public record CheckBoxSymbolType
{
  /// <summary>
  ///   font, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Font { get; set; }

  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public HexChar? Val { get; set; }
}