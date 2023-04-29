namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public class CheckBoxSymbolType: ModelElement
{
  /// <summary>
  ///   font, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Font { get; set; }

  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public HexChar? Val { get; set; }
}